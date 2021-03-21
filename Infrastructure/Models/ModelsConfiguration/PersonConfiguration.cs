using Infrastructure.Models.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Infrastructure.Models.SeedData.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models.ModelsConfiguration
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(u => u.id);
            builder.HasOne(u => u.group)
                   .WithMany(g => g.persons)
                   .HasForeignKey(u => u.groupid)
                   .OnDelete(DeleteBehavior.Cascade);
            builder.Seed();
        }
    }
}
