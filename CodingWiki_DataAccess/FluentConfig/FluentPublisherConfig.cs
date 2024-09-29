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
    public class FluentPublisherConfig : IEntityTypeConfiguration<FluentPublisher>
    {
        public void Configure(EntityTypeBuilder<FluentPublisher> builder)
        {
            builder.HasKey(x => x.PublisherId);
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
