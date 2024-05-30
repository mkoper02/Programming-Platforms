namespace ZeldaApi.Database {
    internal class ApiItem {
        public int Id { get; set; }
        public required int ApiId { get; set; }
        public required string Name { get; set; }
        public required string Category { get; set; }
    }
}
