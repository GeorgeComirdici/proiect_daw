using ProiectDAW.Models;
using Microsoft.EntityFrameworkCore;
namespace ProiectDAW.data

{
    public class context : DbContext
    {
        public context (DbContextOptions options) : base(options)
        { 
        }
        DbSet<angajati> Angajati { get; set; }
        DbSet<Departamente> Departamente { get; set; }
        DbSet<Proiecte> Proiecte { get; set; }
        DbSet<AdreseAngajati> Adrese { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Data Source=DESKTOP-SMUEMVG;Initial Catalog=ProiectDAW;Integrated Security=True");
        }
        public DbSet<angajati> angajatis { get; set; }
        public DbSet<Departamente> departamentes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdreseAngajati>(entity =>
         {
             entity.HasOne(x => x.angajati)
                   .WithOne(x => x.AdreseAngajati)
                   .HasForeignKey<angajati>(x => x.IdAngajat);
         });
            modelBuilder.Entity<angajati>(entity =>
         {
             entity.HasOne(x => x.Departamente)
                   .WithMany(x => x.angajatis)
                   .HasForeignKey(x => x.ForeignKeyDepartamente);
         });
            modelBuilder.Entity<ProiecteAngajati>()
                .HasKey(x => new { x.IdProiect, x.IdAngajat });
            modelBuilder.Entity<ProiecteAngajati>(entity =>
            {
                entity.HasOne(x => x.Proiecte)
                .WithMany(x => x.ProiecteAngajati)
                .HasForeignKey(x => x.IdProiect);
            }
            );
            modelBuilder.Entity<ProiecteAngajati>(entity =>
            {
                entity.HasOne(x => x.angajati)
                .WithMany(x => x.ProiecteAngajati)
                .HasForeignKey(x => x.IdAngajat);
            }
            );
        }
    }
}

