using Infrastructure.Models.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Infrastructure.Models.SeedData.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models.ModelsConfiguration
{
    public class IssueConfiguration : IEntityTypeConfiguration<Issue>
    {
        public void Configure(EntityTypeBuilder<Issue> builder)
        {
            builder.HasKey(r => r.id);
            builder.Seed();
        }
    }
}
