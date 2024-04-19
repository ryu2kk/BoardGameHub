namespace BoardGameHub.Domain.Entities
{
    public class Jogos
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Category { get; set; }
        public string? Description { get; set; }
        public int PlayerNumber { get; set; }
        public string? ImageUrl { get; set; }
        public string? Additional { get; set; }

    }
}
