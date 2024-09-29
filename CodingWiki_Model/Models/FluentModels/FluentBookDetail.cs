using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingWiki_Model.Models.FluentModels
{
    public class FluentBookDetail
    {
        [Key]
        public int BookDetailId { get; set; }
        [Required]
        public int NumberOfChapters { get; set; }
        public int NumberOfPages { get; set; } 
        public string Weight { get; set; }
        //[ForeignKey("FluentBook")]
        //public int BookId { get; set; }
        //public FluentBook Book { get; set; }

    }
}
