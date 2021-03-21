using Microsoft.EntityFrameworkCore;
using Infrastructure.Models.Classes;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Infrastructure.Models.DatabaseContext
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Role> roles { get; set; }
        public DbSet<Group> groups { get; set; }
        public DbSet<Person> persons { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Duration> durations { get; set; }
        public DbSet<Issue> issues { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
