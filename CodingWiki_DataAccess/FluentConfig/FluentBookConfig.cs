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
    public class FluentBookConfig : IEntityTypeConfiguration<FluentBook>
    {
        public void Configure(EntityTypeBuilder<FluentBook> builder)
        {
            builder.HasKey(x => x.BookId);
            builder.Property(x => x.ISBN).IsRequired();
            builder.Property(x => x.ISBN).HasMaxLength(50);
            builder.Ignore(x => x.PriceRange);
            builder.HasOne(x => x.Publisher)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.PublisherId);
        }
    }
}
