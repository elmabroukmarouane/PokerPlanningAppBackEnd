using Infrastructure.Models.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models.SeedData.Classes
{
    public class GroupSeed
    {
        public static IList<Group> groups { get; set; } = new List<Group>()
        {
            new Group()
            {
                id = 1,
                groupname = "Group 1",
                createdat = DateTime.Now,
                createdby = "Seed Data",
                updatedat = DateTime.Now,
                updatedby = "Seed Data"
            },
            new Group()
            {
                id = 2,
                groupname = "Group 2",
                createdat = DateTime.Now,
                createdby = "Seed Data",
                updatedat = DateTime.Now,
                updatedby = "Seed Data"
            },
            new Group()
            {
                id = 3,
                groupname = "Group 3",
                createdat = DateTime.Now,
                createdby = "Seed Data",
                updatedat = DateTime.Now,
                updatedby = "Seed Data"
            }
        };
    }
}
