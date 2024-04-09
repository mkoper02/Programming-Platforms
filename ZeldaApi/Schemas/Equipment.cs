using System.Text.Json.Serialization;

namespace ZeldaApi.Schemas {
    internal class Equipment : SchemaBase {
        [JsonPropertyName("properties")]
        public Properties Properties { get; set; } = null!;

        public override string ToString() {
            string s = $"ID: {Id},\r\nName: {Name},\r\nCategory: {Category},\r\nDescription: \"{Description}\",\r\n";

            if (CommonLocations != null) {
                s += "Locations: ";
                foreach (var location in CommonLocations)
                    s += $"{location}, ";
                s += "\r\n";
            }

            s += $"{Properties},\r\nDlc: {Dlc}.";

            return s;
        }
    }

    internal class Properties {
        [JsonPropertyName("attack")]
        public int? Attack {  get; set; }

        [JsonPropertyName("defense")]
        public int? Defense { get; set; }


        public override string ToString() {
            return $"Properties: attack: {Attack}, defense: {Defense}";
        }
    }
}