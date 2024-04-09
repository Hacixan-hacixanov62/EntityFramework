

using EntityFramework_Crud.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework_Crud.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Setting> Settings { get; set; } 

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-LQO56E8\\SQLEXPRESS;Database=EntityFrameworkPB101Db;Trusted_Connection=true;TrustServerCertificate=True");
        }

    }
}
