using System.Text.Json.Serialization;

namespace ZeldaApi.Schemas {
    internal class Creature {
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

        [JsonPropertyName("cooking_effect")]
        public string? CookingEffect { get; set; }

        [JsonPropertyName("edible")]
        public bool Edible { get; set; }

        [JsonPropertyName("hearts_recovered")]
        public float? HeartsRevocered { get; set; }

        [JsonPropertyName("drops")]
        public List<string>? Drops { get; set; }

        [JsonPropertyName("dlc")]
        public bool Dlc { get; set; }


        public override string ToString() {
            string s = $"ID: {Id},\r\nName: {Name},\r\nCategory: {Category},\r\nDescription: {Description},\r\nEdible: {Edible},\r\n";

            if (CommonLocations != null) {
                s += "Locations: ";
                foreach (var location in CommonLocations) 
                    s += $"{location}, ";
                s += "\r\n";
            }

            if (CookingEffect != null) 
                s += $"Cooking effect: {CookingEffect},\r\n";

            if (HeartsRevocered != null)
                s += $"Hearts recovered: {HeartsRevocered:0.0},\r\n";

            if (Drops != null) {
                s += "Drops: ";
                foreach (var item in Drops)
                    s += $"{item}, ";
                s += "\r\n";
            }

            s += $"Dlc: {Dlc}.\r\n";

            return s;
        }
    }
}
