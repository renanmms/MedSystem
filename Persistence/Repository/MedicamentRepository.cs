using MedSystem.Entities;

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

        public int NumberOfPatients(Guid id)
        {
            var numberOfPatients = _context.Medicaments.ToList().Count();
            return numberOfPatients;
        }
    }
}
