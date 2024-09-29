using System.ComponentModel.DataAnnotations;

namespace CodingWiki_Model.Models.FluentModels
{
    public class FluentPublisher
    {
        public int PublisherId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public List<FluentBook> Books { get; set; }
    }
}
