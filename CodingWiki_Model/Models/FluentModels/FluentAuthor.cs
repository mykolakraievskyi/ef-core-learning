using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingWiki_Model.Models.FluentModels
{
    public class FluentAuthor
    {
        [Key]
        public int AuthorId { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Location { get; set; }
        [NotMapped] public string FullName => $"{FirstName} {LastName}";
        //public List<FluentBookAuthorMap> BookAuthors { get; set; }
    }
}
