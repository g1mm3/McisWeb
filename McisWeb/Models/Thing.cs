namespace McisWeb.Models
{
    public class Thing
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsFinished { get; set; }

        public int PackId { get; set; }
        public Pack Pack { get; set; }

        public Article Article { get; set; }
        public Video Video { get; set; }
        public Book Book { get; set; }
    }
}
