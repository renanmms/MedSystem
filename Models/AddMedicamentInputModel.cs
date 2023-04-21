namespace MedSystem.Models
{
    public class AddMedicamentInputModel
    {
        public string Name { get; set; }
        public string Dose { get; set; }
        public string Description { get; set; }
        public int NumberOfPatients { get; set; } = 1;
        public Guid PatientId { get; set; }
    }
}
