using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Model.Models
{
    public class SubCategory
    {
        [Key]
        public int SubCategoryId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
