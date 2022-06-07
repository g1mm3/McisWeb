namespace McisWeb.Models
{
    public class Block
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsFinished { get; set; }

        public List<Pack> Packs { get; set; }
    }
}
