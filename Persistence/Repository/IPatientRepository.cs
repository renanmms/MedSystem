using MedSystem.Entities;

namespace MedSystem.Persistence.Repository
{
    public interface IPatientRepository
    {
        List<Patient> GetAll();
        void Create(Patient patient);
        Patient GetById(Guid id);
        void IsMedicated(Guid id);
        int MedicamentsQuantity(Guid id);
    }
}
