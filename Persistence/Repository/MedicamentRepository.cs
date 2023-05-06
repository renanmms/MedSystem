using MedSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace MedSystem.Persistence.Repository
{
    public class MedicamentRepository : IMedicamentRepository
    {
        private readonly MedSystemDbContext _context;

        public MedicamentRepository(MedSystemDbContext context)
        {
            _context = context;
        }

        public void Create(Medicament medicament)
        {
            _context.Medicaments.Add(medicament);
            _context.SaveChanges();
        }

        public Medicament Get(Guid id)
        {
            var medicament = _context.Medicaments.SingleOrDefault(m => m.Id == id);
            return medicament;
        }

        public List<Medicament> GetAll()
        {
            var medicaments = _context.Medicaments.ToList();
            return medicaments;
        }

        public int AddPatient(Guid id)
        {
            var medicament = _context.Medicaments.SingleOrDefault(m => m.Id == id);
            medicament.AddNumberOfPatient();

            _context.Entry(medicament).State = EntityState.Modified;
            _context.SaveChanges();
            return medicament.NumberOfPatients;
        }

        public void EditMedicament(Medicament medicament)
        {          
            _context.Entry(medicament).State = EntityState.Modified;
            _context.SaveChanges();

        }

        public void DeleteMedicament(Guid id)
        {
            var medicament = _context.Medicaments.SingleOrDefault(m => m.Id == id);
            _context.Entry(medicament).State = EntityState.Deleted;
            _context.SaveChanges();
        }
    }
}
