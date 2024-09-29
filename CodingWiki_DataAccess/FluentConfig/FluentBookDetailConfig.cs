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
    public class FluentBookDetailConfig : IEntityTypeConfiguration<FluentBookDetail>
    {
        public void Configure(EntityTypeBuilder<FluentBookDetail> builder)
        {
            // name of the table
            builder.ToTable("FluentBookDetail");

            // name of the column
            builder.Property(x => x.NumberOfChapters).HasColumnName("NoOfChapters");

            //primary key
            builder.HasKey(x => x.BookDetailId);

            // other validations
            builder.Property(x => x.NumberOfChapters).IsRequired();

            // relations
            builder.HasOne(x => x.Book)
                .WithOne(x => x.BookDetail)
                .HasForeignKey<FluentBookDetail>(x => x.BookId);
        }
    }
}
