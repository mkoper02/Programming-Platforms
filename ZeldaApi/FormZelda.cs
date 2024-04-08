using System.Collections;
using System.Text.Json;
using ZeldaApi.Schemas;

namespace ZeldaApi {
    public partial class FormZelda : Form {

        private readonly HttpClient _client;
        private string? _url;

        //public 

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

            // Remove "data:" from json file
            response = response.Remove(0, 8);
            response = response.Remove(response.Length - 2);

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

            foreach (var item in orderedDeserializedList) {
                dataGridViewMain.Rows.Add(item.Id, item.Name, item.Category);
            }

            pictureBox1.Load(orderedDeserializedList.First().ImageUrl);
            //AddToTextBox(deserializeList);
        }

        private void AddToTextBox(IEnumerable list) {
            textBoxResponse.Text = "";

            foreach (var item in list) {
                textBoxResponse.Text += item.ToString() + "\r\n\r\n";
            }
        }

        private void ListBoxSchemasSelectedIndexChanged(object sender, EventArgs e) {
            _url = $"https://botw-compendium.herokuapp.com/api/v3/compendium/category/{listBoxSchemas.GetItemText(listBoxSchemas.SelectedItem).ToLower()}";
        }
    }
}
