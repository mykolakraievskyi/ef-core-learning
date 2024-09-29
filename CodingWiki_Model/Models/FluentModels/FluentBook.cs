using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingWiki_Model.Models.FluentModels
{
    public class FluentBook
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        [MaxLength(20)]
        [Required]
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        [NotMapped]
        public string PriceRange { get; set; }
        //public BookDetail BookDetail { get; set; }
        //[ForeignKey("FluentPublisher")]
        //public int PublisherId { get; set; }
        //public FluentPublisher Publisher { get; set; }
        //public List<FluentBookAuthorMap> BookAuthors { get; set; }
    }
}
