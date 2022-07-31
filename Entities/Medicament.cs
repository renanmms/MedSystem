namespace MedSystem.Entities
{
    public class Medicament
    {
        public Medicament(string name, string dose, string description)
        {
            Id = Guid.NewGuid();
            Name = name;
            Dose = dose;
            Description = description;

            CreatedAt = DateTime.Now;
            NumberOfPatients = 0;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Dose { get; private set; }
        public string Description { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public int NumberOfPatients { get; private set; }
        public Guid PatientId { get; private set; }
        public Patient Patient { get; private set; }
    }
}