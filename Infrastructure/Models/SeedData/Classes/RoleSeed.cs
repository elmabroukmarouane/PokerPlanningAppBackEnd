using Infrastructure.Models.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models.SeedData.Classes
{
    public class RoleSeed
    {
        public static IList<Role> roles { get; set; } = new List<Role>()
        {
            new Role()
            {
                id = 1,
                role = Roles.SUPER_ADMIN,
                title = "Super Administrator",
                description = "Super Administrator Description",
                createdate = DateTime.Now,
                createdby = "Seed Data",
                updatedate = DateTime.Now,
                updatedby = "Seed Data"
            },
            new Role()
            {
                id = 2,
                role = Roles.ADMIN,
                title = "Administrator",
                description = "Administrator Description",
                createdate = DateTime.Now,
                createdby = "Seed Data",
                updatedate = DateTime.Now,
                updatedby = "Seed Data"
            },
            new Role()
            {
                id = 3,
                role = Roles.USER,
                title = "User",
                description = "User Description",
                createdate = DateTime.Now,
                createdby = "Seed Data",
                updatedate = DateTime.Now,
                updatedby = "Seed Data"
            }
        };
    }
}
