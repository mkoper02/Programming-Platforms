using System.Text.Json.Serialization;

namespace ZeldaApi.Schemas {
    internal class Material : SchemaBase {
        [JsonPropertyName("hearts_recovered")]
        public float HeartsRevocered { get; set; }

        [JsonPropertyName("cooking_effect")]
        public string? CookingEffect { get; set; }        

        public override string ToString() {
            string s = $"ID: {Id},\r\nName: {Name},\r\nCategory: {Category},\r\nDescription: {Description},\r\n";

            if (CommonLocations != null) {
                s += "Locations: ";
                foreach (var location in CommonLocations)
                    s += $"{location}, ";
                s += "\r\n";
            }

            if (CookingEffect != "")
                s += $"Cooking effect: {CookingEffect},\r\n";

            s += $"Hearts recovered: {HeartsRevocered: 0.0},\r\nDlc: {Dlc}.\r\n";

            return s;
        }
    }
}
