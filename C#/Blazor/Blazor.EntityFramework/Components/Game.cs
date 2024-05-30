using System.ComponentModel.DataAnnotations;

namespace Blazor.EntityFramework.Components
{
    public class Game
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Genre { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }
        public string? Description { get; set; }
        public float? Rate { get; set; }

        public string? Url { get; set; }
    }
}