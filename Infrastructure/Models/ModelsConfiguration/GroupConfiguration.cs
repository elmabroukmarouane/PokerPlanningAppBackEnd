using Infrastructure.Models.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Infrastructure.Models.SeedData.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models.ModelsConfiguration
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(r => r.id);
            builder.Seed();
        }
    }
}
