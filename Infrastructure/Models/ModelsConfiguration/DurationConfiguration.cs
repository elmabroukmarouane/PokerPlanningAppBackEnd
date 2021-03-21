using Infrastructure.Models.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Infrastructure.Models.SeedData.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models.ModelsConfiguration
{
    public class DurationConfiguration : IEntityTypeConfiguration<Duration>
    {
        public void Configure(EntityTypeBuilder<Duration> builder)
        {
            builder.HasKey(r => r.id);
            builder.Seed();
        }
    }
}
