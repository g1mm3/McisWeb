namespace McisWeb.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public int ThingId { get; set; }
        public Thing Thing { get; set; }
    }
}
