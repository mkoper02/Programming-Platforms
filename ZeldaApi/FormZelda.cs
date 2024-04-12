using System.Collections;
using System.Security.Policy;
using System.Text.Json;
using ZeldaApi.Database;
using ZeldaApi.Schemas;

namespace ZeldaApi {
    public partial class FormZelda : Form {

        private readonly HttpClient _client;
        private string? _url;
        private ZeldaApiContext _context;

        public FormZelda() {
            InitializeComponent();
            _client = new HttpClient();
            _context = new ZeldaApiContext();
        }

        private async void BtnDownloadClick(object sender, EventArgs e) {
            // check if any item is selected
            if (listBoxSchemas.SelectedIndex == -1) {
                MessageBox.Show("Please select an Item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // get response from api
            string response = await _client.GetStringAsync(_url);
            response = AlterJson(response);

            IEnumerable<SchemaBase>? deserializedList = JsonSerializer.Deserialize<IEnumerable<SchemaBase>>(response);
            var orderedDeserializedList = deserializedList.OrderBy(r => r.Id);

            dataGridViewMain.Rows.Clear();

            foreach (var item in orderedDeserializedList) {
                var dbItem = _context.ApiItems.Where(r => r.ApiId == item.Id).FirstOrDefault();

                if (dbItem is not null) 
                    dataGridViewMain.Rows.Add(item.Id, item.Name, item.Category, true);

                else
                    dataGridViewMain.Rows.Add(item.Id, item.Name, item.Category, false);
            }
        }

        private async void DataGridViewMainCellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 3) return;

            dataGridViewMain.CurrentRow.Selected = true;

            var itemId = dataGridViewMain.Rows[e.RowIndex].Cells["ItemId"].Value;
            string response = await _client.GetStringAsync($"https://botw-compendium.herokuapp.com/api/v3/compendium/entry/{itemId}");
            response = AlterJson(response);

            if (dataGridViewMain.Rows[e.RowIndex].Cells["Category"].Value is "creatures") DisplayDetailInNewWindow<Creature>(response);
            else if (dataGridViewMain.Rows[e.RowIndex].Cells["Category"].Value is "equipment") DisplayDetailInNewWindow<Equipment>(response);
            else if (dataGridViewMain.Rows[e.RowIndex].Cells["Category"].Value is "materials") DisplayDetailInNewWindow<Material>(response);
            else if (dataGridViewMain.Rows[e.RowIndex].Cells["Category"].Value is "monsters") DisplayDetailInNewWindow<Monster>(response);
            else if (dataGridViewMain.Rows[e.RowIndex].Cells["Category"].Value is "treasure") DisplayDetailInNewWindow<Treasure>(response);
        }

        private void DisplayDetailInNewWindow<T>(string response) where T : SchemaBase {
            T? item = JsonSerializer.Deserialize<T>(response);
            new FormDetails(item.ToString(), item.ImageUrl, item.Name).Show();
        }

        private void ListBoxSchemasSelectedIndexChanged(object sender, EventArgs e) {
            _url = $"https://botw-compendium.herokuapp.com/api/v3/compendium/category/{listBoxSchemas.GetItemText(listBoxSchemas.SelectedItem).ToLower()}";
        }

        private static string AlterJson(string json) {
            json = json.Remove(0, 8);
            json = json.Remove(json.Length - 2);

            return json;
        }

        private void ButtonSaveFavouritesClick(object sender, EventArgs e) {
            foreach (DataGridViewRow row in dataGridViewMain.Rows) {
                var isChecked = row.Cells["Favourite"].Value;
                var dbItem = _context.ApiItems.Where(r => r.ApiId == (int)row.Cells["ItemId"].Value).FirstOrDefault();

                if (isChecked is true) {
                    if (dbItem is not null) 
                        continue;

                    _context.ApiItems.Add(new ApiItem() {
                        ApiId = (int)row.Cells["ItemId"].Value,
                        Name = (string)row.Cells["Name"].Value,
                        Category = (string)row.Cells["Category"].Value});
                }

                else {
                    if (dbItem is null)
                        continue;

                    _context.ApiItems.Remove(dbItem);
                }
            }

            _context.SaveChanges();
        }

        private void ButtonFavouritesClick(object sender, EventArgs e) {
            var itemsList = _context.ApiItems.OrderBy(r => r.ApiId).ToList();

            dataGridViewMain.Rows.Clear();

            foreach (var item in itemsList) {
                dataGridViewMain.Rows.Add(item.ApiId, item.Name, item.Category, true);
            }
        }
    }
}
