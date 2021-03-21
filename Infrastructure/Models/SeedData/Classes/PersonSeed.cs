using Infrastructure.Models.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models.SeedData.Classes
{
    public class PersonSeed
    {
        public static IList<Person> persons { get; set; } = new List<Person>()
        {
            new Person()
            {
                id = 1,
                groupid = 1,
                firstname = "Marouane",
                lastname = "EL MABROUK",
                birthdate = DateTime.Now,
                createdat = DateTime.Now,
                createdby = "Seed Data",
                updatedat = DateTime.Now,
                updatedby = "Seed Data"
            },
            new Person()
            {
                id = 2,
                groupid = 2,
                firstname = "Smith",
                lastname = "JOHN",
                birthdate = DateTime.Now,
                createdat = DateTime.Now,
                createdby = "Seed Data",
                updatedat = DateTime.Now,
                updatedby = "Seed Data"
            },new Person()
            {
                id = 3,
                groupid = 3,
                firstname = "William",
                lastname = "MILLER",
                birthdate = DateTime.Now,
                createdat = DateTime.Now,
                createdby = "Seed Data",
                updatedat = DateTime.Now,
                updatedby = "Seed Data"
            }
        };
    }
}
