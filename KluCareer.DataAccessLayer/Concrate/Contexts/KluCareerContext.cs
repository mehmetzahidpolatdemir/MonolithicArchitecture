using KluCareer.Entities.Concrate.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace KluCareer.DataAccessLayer.Concrate.Contexts
{
    public class KluCareerContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configurationBuiler = new ConfigurationBuilder();
            /*    var appSettingsPath = "C:\\Users\\halit\\source\repos\\KluCareer\\KluCareer.WebMvc\\bin\\Debug\\netcoreapp3.1\\appsettings.json";
            */
        
            var appSettingsPath = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");

            configurationBuiler.AddJsonFile(appSettingsPath);
            string connectionString = configurationBuiler.Build().GetConnectionString("default");

            //optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.UseSqlServer(connectionString, option => { 
            //yeni yapılandırlamalr geldiğinde buradan eklenebilir...
            });
        }
      
        public DbSet<Cv> Cvs { get; set; }
        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Fakulte> Fakulteler { get; set; }
    }
}
