using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using LearningCurve.Models;

namespace LearningCurve.Data
{
    public class LocalContext : DbContext
    {
        // Database connection strings, pass one to LocalContext constructor to select
        private static string DefaultConnectionString = "DefaultConnection";
        private static string MySQLConnectionString = "MySQLConnection";

        public LocalContext() : base(MySQLConnectionString)     // Set correct connection string here
        {
        }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
