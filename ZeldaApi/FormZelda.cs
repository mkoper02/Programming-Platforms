using System.Text.Json;
using ZeldaApi.Schemas;

namespace ZeldaApi {
    public partial class FormZelda : Form {

        private readonly HttpClient _client;

        public FormZelda() {
            InitializeComponent();
            _client = new HttpClient();
        }

        private async void BtnDownloadClick(object sender, EventArgs e) {
            string url = "https://botw-compendium.herokuapp.com/api/v3/compendium/entry/165";
            //url = "https://botw-compendium.herokuapp.com/api/v3/compendium/category/creatures";

            string response = await _client.GetStringAsync(url);

            // Remove "data:" from json file
            response = response.Remove(0, 8);
            response = response.Remove(response.Length - 2);


            //List<Creature> creatures = JsonSerializer.Deserialize<List<Creature>>(response);
            //List<Treasure> treasures = JsonSerializer.Deserialize<List<Treasure>>(response);
            //List<Monster> monsters = JsonSerializer.Deserialize<List<Monster>>(response);
            //List<Material> materials = JsonSerializer.Deserialize<List<Material>>(response);
            //List<Equipment> equipment = JsonSerializer.Deserialize<List<Equipment>>(response);

            //foreach (var creature in creatures) {
            //    textBoxResponse.Text += creature.ToString() + "\r\n\r\n";
            //}


            //Creature creature = JsonSerializer.Deserialize<Creature>(response);
            //Treasure treasure = JsonSerializer.Deserialize<Treasure>(response);
            //Monster monster = JsonSerializer.Deserialize<Monster>(response);
            Material material = JsonSerializer.Deserialize<Material>(response);
            //Equipment equipment = JsonSerializer.Deserialize<Equipment>(response);

            textBoxResponse.Text += material;
        }
    }
}
