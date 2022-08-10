using MedSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace MedSystem.Persistence
{
    public class MedSystemDbContext : DbContext
    {

        public MedSystemDbContext(DbContextOptions<MedSystemDbContext> options) : base(options)
        {
            
        }

        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Patient> Patients { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Patient>()
                .HasMany(p => p.Medicaments)
                .WithOne(m => m.Patient)
                .HasForeignKey(m => m.PatientId)
                .HasPrincipalKey(p => p.Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
