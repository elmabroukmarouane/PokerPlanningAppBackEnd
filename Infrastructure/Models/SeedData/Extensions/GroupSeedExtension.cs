using Infrastructure.Models.Classes;
using Infrastructure.Models.SeedData.Classes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models.SeedData.Extensions
{
    public static class GroupSeedExtension
    {
        public static void Seed(this EntityTypeBuilder<Group> builder)
        {
            builder.HasData(GroupSeed.groups);
        }
    }
}
