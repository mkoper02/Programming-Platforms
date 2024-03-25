using System.Text.Json.Serialization;

namespace ZeldaApi.Schemas {
    internal class Monster {
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

        [JsonPropertyName("drops")]
        public List<string>? Drops { get; set; }

        [JsonPropertyName("dlc")]
        public bool Dlc { get; set; }


        public override string ToString() {
            string s = $"ID: {Id},\r\nName: {Name},\r\nCategory: {Category},\r\nDescription: {Description},\r\n";

            if (CommonLocations != null) {
                s += "Locations: ";
                foreach (var location in CommonLocations)
                    s += $"{location}, ";
                s += "\r\n";
            }

            if (Drops != null) {
                s += "Drops: ";
                foreach (var drop in Drops)
                    s += $"{drop}, ";
                s += "\r\n";
            }

            s += $"Dlc: {Dlc}.\r\n";

            return s;
        }
    }
}
