using Infrastructure.Models.Classes;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Infrastructure.Models.SeedData.Classes
{
    public class UserSeed
    {
        public static IList<User> users { get; set; } = new List<User>()
        {
            new User()
            {
                id = 1,
                roleid = 1,
                email = "user1@mail.com",
                password = CreateHashPassword("123456"),
                createdat = DateTime.Now,
                createdby = "Seed Data",
                updatedat = DateTime.Now,
                updatedby = "Seed Data"
            },
            new User()
            {
                id = 2,
                roleid = 2,
                email = "user2@mail.com",
                password = CreateHashPassword("123456"),
                createdat = DateTime.Now,
                createdby = "Seed Data",
                updatedat = DateTime.Now,
                updatedby = "Seed Data"
            },
            new User()
            {
                id = 3,
                roleid = 3,
                email = "user3@mail.com",
                password = CreateHashPassword("123456"),
                createdat = DateTime.Now,
                createdby = "Seed Data",
                updatedat = DateTime.Now,
                updatedby = "Seed Data"
            }
        };

        public static string CreateHashPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");
            using (var sha512Hash = SHA512.Create())
            {
                var bytes = sha512Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
