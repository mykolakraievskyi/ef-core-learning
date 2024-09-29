using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingWiki_Model.Models.FluentModels
{
    public class FluentAuthor
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Location { get; set; }
        [NotMapped] public string FullName => $"{FirstName} {LastName}";

        public List<FluentBook> Books { get; set; }
        //public List<FluentBookAuthorMap> BookAuthors { get; set; }
    }
}
