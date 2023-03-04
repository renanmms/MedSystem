using MedSystem.Entities;
using MedSystem.Models;

namespace MedSystem.Persistence.Repository
{
    public interface IMedicamentRepository
    {

        List<Medicament> GetAll();
        Medicament Get(Guid id);
        void Create(Medicament medicament);
        int NumberOfPatients(Guid id);
        Medicament EditMedicament(EditMedicamentInputModel model);
        void DeleteMedicament(Guid id);
    }
}
