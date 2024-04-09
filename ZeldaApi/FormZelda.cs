using System.Collections;
using System.Text.Json;
using ZeldaApi.Schemas;

namespace ZeldaApi {
    public partial class FormZelda : Form {

        private readonly HttpClient _client;
        private string? _url;

        public FormZelda() {
            InitializeComponent();
            _client = new HttpClient();
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

            if (listBoxSchemas.SelectedIndex == 0) DisplaySelected<Creature>(response);
            else if (listBoxSchemas.SelectedIndex == 1) DisplaySelected<Equipment>(response);
            else if (listBoxSchemas.SelectedIndex == 2) DisplaySelected<Material>(response);
            else if (listBoxSchemas.SelectedIndex == 3) DisplaySelected<Monster>(response);
            else if (listBoxSchemas.SelectedIndex == 4) DisplaySelected<Treasure>(response);
        }

        private void DisplaySelected<T>(string response) where T : SchemaBase {
            IEnumerable<T>? deserializedList = JsonSerializer.Deserialize<IEnumerable<T>>(response);
            var orderedDeserializedList = deserializedList.OrderBy(r => r.Id);

            dataGridViewMain.Rows.Clear();

            foreach (var item in orderedDeserializedList) 
                dataGridViewMain.Rows.Add(item.Id, item.Name, item.Category);
        }

        private async void DataGridViewMainCellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 3) return;
            if (e.RowIndex < 0) return;

            dataGridViewMain.CurrentRow.Selected = true;

            var itemId = dataGridViewMain.Rows[e.RowIndex].Cells[0].Value;
            string response = await _client.GetStringAsync($"https://botw-compendium.herokuapp.com/api/v3/compendium/entry/{itemId}");
            response = AlterJson(response);

            if (listBoxSchemas.SelectedIndex == 0) DisplayDetailInNewWindow<Creature>(response);
            else if (listBoxSchemas.SelectedIndex == 1) DisplayDetailInNewWindow<Equipment>(response);
            else if (listBoxSchemas.SelectedIndex == 2) DisplayDetailInNewWindow<Material>(response);
            else if (listBoxSchemas.SelectedIndex == 3) DisplayDetailInNewWindow<Monster>(response);
            else if (listBoxSchemas.SelectedIndex == 4) DisplayDetailInNewWindow<Treasure>(response);
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
    }
}
