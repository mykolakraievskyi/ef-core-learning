using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingWiki_Model.Models.FluentModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodingWiki_DataAccess.FluentConfig
{
    public class FluentBookAuthorMapConfig : IEntityTypeConfiguration<FluentBookAuthorMap>
    {
        public void Configure(EntityTypeBuilder<FluentBookAuthorMap> builder)
        {
            builder.HasKey(x => new { x.AuthorId, x.BookId });
            builder.HasOne(x => x.Author).WithMany(x => x.BookAuthorMap)
                .HasForeignKey(x => x.AuthorId);
            builder.HasOne(x => x.Book).WithMany(x => x.BookAuthorMap)
                .HasForeignKey(x => x.BookId);
        }
    }
}
