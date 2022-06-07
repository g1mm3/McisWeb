namespace McisWeb.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public int ThingId { get; set; }
        public Thing Thing { get; set; }
    }
}
