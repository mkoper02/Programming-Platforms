using System.Text.Json.Serialization;

namespace ZeldaApi.Schemas {
    internal class Monster : SchemaBase {
        [JsonPropertyName("drops")]
        public List<string>? Drops { get; set; }

        public override string ToString() {
            string s = $"ID: {Id},\r\nName: {Name},\r\nCategory: {Category},\r\nDescription: \"{Description}\",\r\n";

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

            s += $"Dlc: {Dlc}.";

            return s;
        }
    }
}
