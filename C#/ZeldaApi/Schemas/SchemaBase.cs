using System.Text.Json.Serialization;

namespace ZeldaApi.Schemas {
    internal class SchemaBase {
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

        [JsonPropertyName("dlc")]
        public bool Dlc { get; set; }
    }
}
