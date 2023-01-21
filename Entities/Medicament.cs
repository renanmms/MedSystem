namespace MedSystem.Entities
{
    public class Medicament
    {
        public Medicament(string name, string dose, string description, Guid patientId)
        {
            Id = Guid.NewGuid();
            Name = name;
            Dose = dose;
            Description = description;
            PatientId = patientId;

            CreatedAt = DateTime.Now;
            NumberOfPatients = 0;
        }

        public Guid Id { get; private set; }
        public string Name { get; set; }
        public string Dose { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; private set; }
        public int NumberOfPatients { get; private set; }
        public Guid PatientId { get; set; }
        public Patient Patient { get; private set; }
    }
}