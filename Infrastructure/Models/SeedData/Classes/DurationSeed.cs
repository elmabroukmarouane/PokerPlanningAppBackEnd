using Infrastructure.Models.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models.SeedData.Classes
{
    public class DurationSeed
    {
        public static IList<Duration> durations { get; set; } = new List<Duration>()
        {
            new Duration()
            {
                id = 1,
                duration = 60,
                createdat = DateTime.Now,
                createdby = "Seed Data",
                updatedat = DateTime.Now,
                updatedby = "Seed Data"
            }
        };
    }
}
