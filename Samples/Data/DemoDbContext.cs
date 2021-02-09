using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Samples.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


namespace Samples.Data
{
    public class DemoDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json")
               .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DbConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"data","Employees.json");
            var employees = new List<Employee>();
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                employees = JsonConvert.DeserializeObject<List<Employee>>(json);
            }
            modelBuilder.Entity<Employee>().HasData(employees);
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
