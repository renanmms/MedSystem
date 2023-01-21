namespace MedSystem.Models
{
    public class EditMedicamentInputModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Dose { get; set; }
        public string Description { get; set; }
        public Guid PatientId { get; set; }
    }
}
