namespace ProjectKard.Domain
{
    public class Listing : BaseDomainModel
    {
        public double Price { get; set; }
        public int Amount { get; set; }
        public string? UserId { get; set; }
        public string? CardId { get; set; }
        public string? CategoryId { get; set; }

        public string? Desc { get; set; }
    }
}
