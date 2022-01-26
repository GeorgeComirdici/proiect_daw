using ProiectDAW.Models;
using Microsoft.EntityFrameworkCore;
namespace ProiectDAW.data

{
    public class context : DbContext
    {
        DbSet<angajati> Angajati { get; set; }
        DbSet<Departamente> Departamente { get; set; }
        DbSet<Proiecte> Proiecte { get; set; }
        DbSet<AdreseAngajati> Adrese { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProiectDAW");
        }
    }
}
