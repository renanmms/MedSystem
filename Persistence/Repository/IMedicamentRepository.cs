using MedSystem.Entities;

namespace MedSystem.Persistence.Repository
{
    public interface IMedicamentRepository
    {

        List<Medicament> GetAll();
        Medicament Get(Guid id);
        void Create(Medicament medicament);
        int NumberOfPatients(Guid id);
    }
}
