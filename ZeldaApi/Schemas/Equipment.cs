using System.Text.Json.Serialization;

namespace ZeldaApi.Schemas {
    internal class Equipment {
        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; } = null!;

        [JsonPropertyName("description")]
        public string Description { get; set; } = null!;

        [JsonPropertyName("image")]
        public string ImageUrl { get; set; } = null!;

        [JsonPropertyName("common_locations")]
        public List<string>? CommonLocations { get; set; }

        [JsonPropertyName("properties")]
        public Properties Properties { get; set; } = null!;

        [JsonPropertyName("dlc")]
        public bool Dlc {  get; set; }


        public override string ToString() {
            string s = $"ID: {Id},\r\nName: {Name},\r\nCategory: {Category},\r\nDescription: {Description},\r\n";

            if (CommonLocations != null) {
                s += "Locations: ";
                foreach (var location in CommonLocations)
                    s += $"{location}, ";
                s += "\r\n";
            }

            s += $"{Properties},\r\nDlc: {Dlc}.\r\n";

            return s;
        }
    }

    internal class Properties {
        [JsonPropertyName("attack")]
        public int Attack {  get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }


        public override string ToString() {
            return $"Properties:\r\n\tAttack: {Attack},\r\n\tDefense: {Defense}";
        }
    }
}