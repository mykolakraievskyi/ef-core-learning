using System.ComponentModel.DataAnnotations.Schema;

namespace CodingWiki_Model.Models.FluentModels
{
    public class FluentBookAuthorMap
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }


        public FluentBook Book { get; set; }
        public FluentAuthor Author { get; set; }
    }
}
