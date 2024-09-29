using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingWiki_Model.Models.FluentModels
{
    public class FluentBook
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public string PriceRange { get; set; }
        public FluentBookDetail BookDetail { get; set; }
        public int PublisherId { get; set; }
        public FluentPublisher Publisher { get; set; }
        public List<FluentAuthor> Authors { get; set; }

        //public List<FluentBookAuthorMap> BookAuthors { get; set; }
    }
}
