using Infrastructure.Models.Classes;
using Infrastructure.Models.SeedData.Classes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models.SeedData.Extensions
{
    public static class UserSeedExtension
    {
        public static void Seed(this EntityTypeBuilder<User> builder)
        {
            builder.HasData(UserSeed.users);
        }
    }
}
