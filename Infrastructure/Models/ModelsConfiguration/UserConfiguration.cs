using Infrastructure.Models.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Infrastructure.Models.SeedData.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models.ModelsConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.id);
            builder.HasOne(u => u.person)
                  .WithMany(p => p.users)
                  .HasForeignKey(u => u.personid)
                  .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(u => u.role)
                   .WithMany(r => r.users)
                   .HasForeignKey(u => u.roleid)
                   .OnDelete(DeleteBehavior.Cascade);
            builder.Seed();
        }
    }
}
