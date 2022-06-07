using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace McisWeb.Models
{
    public class Pack
    {
        public int Id { get; set; }
        [BindRequired]
        public string Title { get; set; }
        public bool IsFinished { get; set; }

        public Block Block { get; set; }
        public int BlockId { get; set; }

        public List<Thing> Things { get; set; }
    }
}
