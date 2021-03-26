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
                createdate = DateTime.Now,
                createdby = "Seed Data",
                updatedate = DateTime.Now,
                updatedby = "Seed Data"
            },
            new Group()
            {
                id = 2,
                groupname = "Group 2",
                createdate = DateTime.Now,
                createdby = "Seed Data",
                updatedate = DateTime.Now,
                updatedby = "Seed Data"
            },
            new Group()
            {
                id = 3,
                groupname = "Group 3",
                createdate = DateTime.Now,
                createdby = "Seed Data",
                updatedate = DateTime.Now,
                updatedby = "Seed Data"
            },
            new Group()
            {
                id = 4,
                groupname = "Group 4",
                createdate = DateTime.Now,
                createdby = "Seed Data",
                updatedate = DateTime.Now,
                updatedby = "Seed Data"
            },
            new Group()
            {
                id = 5,
                groupname = "Group 5",
                createdate = DateTime.Now,
                createdby = "Seed Data",
                updatedate = DateTime.Now,
                updatedby = "Seed Data"
            },
            new Group()
            {
                id = 6,
                groupname = "Group 6",
                createdate = DateTime.Now,
                createdby = "Seed Data",
                updatedate = DateTime.Now,
                updatedby = "Seed Data"
            },
            new Group()
            {
                id = 7,
                groupname = "Group 7",
                createdate = DateTime.Now,
                createdby = "Seed Data",
                updatedate = DateTime.Now,
                updatedby = "Seed Data"
            },
            new Group()
            {
                id = 8,
                groupname = "Group 8",
                createdate = DateTime.Now,
                createdby = "Seed Data",
                updatedate = DateTime.Now,
                updatedby = "Seed Data"
            },
            new Group()
            {
                id = 9,
                groupname = "Group 9",
                createdate = DateTime.Now,
                createdby = "Seed Data",
                updatedate = DateTime.Now,
                updatedby = "Seed Data"
            },
            new Group()
            {
                id = 10,
                groupname = "Group 10",
                createdate = DateTime.Now,
                createdby = "Seed Data",
                updatedate = DateTime.Now,
                updatedby = "Seed Data"
            },
            new Group()
            {
                id = 11,
                groupname = "Group 11",
                createdate = DateTime.Now,
                createdby = "Seed Data",
                updatedate = DateTime.Now,
                updatedby = "Seed Data"
            },
            new Group()
            {
                id = 12,
                groupname = "Group 12",
                createdate = DateTime.Now,
                createdby = "Seed Data",
                updatedate = DateTime.Now,
                updatedby = "Seed Data"
            }
        };
    }
}
