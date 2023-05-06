using MedSystem.Entities;

namespace MedSystem.Persistence.Repository
{
    public interface IMedicamentRepository
    {

        List<Medicament> GetAll();
        Medicament Get(Guid id);
        void Create(Medicament medicament);
        int AddPatient(Guid id);
        void EditMedicament(Medicament medicament);
        void DeleteMedicament(Guid id);
    }
}
