namespace McisWeb.Models
{
    public class BookPage
    {
        public int Id { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
