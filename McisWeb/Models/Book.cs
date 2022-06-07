namespace McisWeb.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public List<BookPage> Pages { get; set; }

        public int ThingId { get; set; }
        public Thing Thing { get; set; }
    }
}
