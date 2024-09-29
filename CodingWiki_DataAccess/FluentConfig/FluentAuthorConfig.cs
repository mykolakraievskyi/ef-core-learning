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
    public class FluentAuthorConfig : IEntityTypeConfiguration<FluentAuthor>
    {
        public void Configure(EntityTypeBuilder<FluentAuthor> builder)
        {
            builder.HasKey(x => x.AuthorId);
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.FirstName).HasMaxLength(20);
            builder.Property(x => x.LastName).IsRequired();
            builder.Ignore(x => x.FullName);
        }
    }
}
