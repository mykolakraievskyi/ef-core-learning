using System.ComponentModel.DataAnnotations.Schema;

namespace CodingWiki_Model.Models.FluentModels
{
    public class FluentBookAuthorMap
    {
        [ForeignKey("FluentBook")]
        public int BookId { get; set; }
        [ForeignKey("FluentAuthor")]
        public int AuthorId { get; set; }


        public FluentBook Book { get; set; }
        public FluentAuthor Author { get; set; }
    }
}
