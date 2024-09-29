﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Model.Models
{
    public class BookAuthorMap
    {
        [ForeignKey("FluentBook")]
        public int BookId { get; set; }
        [ForeignKey("FluentAuthor")]
        public int AuthorId { get; set; }


        public Book Book { get; set; }
        public Author Author { get; set; }
    }
}
