using Infrastructure.Models.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models.SeedData.Classes
{
    public class IssueSeed
    {
        public static IList<Issue> issues { get; set; } = new List<Issue>()
        {
            new Issue()
            {
                id = 1,
                number = "#1",
                title = "Issue 1",
                url = "https://google.com/",
                assignedto = "EL MABROUK Marouane",
                weight = 4,
                createdate = DateTime.Now,
                createdby = "Seed Data",
                updatedate = DateTime.Now,
                updatedby = "Seed Data"
            },
            new Issue()
            {
                id = 2,
                number = "#2",
                title = "Issue 2",
                url = "https://google.com/",
                assignedto = "JOHN Smith",
                weight = 4,
                createdate = DateTime.Now,
                createdby = "Seed Data",
                updatedate = DateTime.Now,
                updatedby = "Seed Data"
            },
            new Issue()
            {
                id = 3,
                number = "#3",
                title = "Issue 3",
                url = "https://google.com/",
                assignedto = "MILLER William",
                weight = 4,
                createdate = DateTime.Now,
                createdby = "Seed Data",
                updatedate = DateTime.Now,
                updatedby = "Seed Data"
            }
        };
    }
}
