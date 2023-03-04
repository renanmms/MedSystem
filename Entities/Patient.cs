namespace MedSystem.Entities
{
    public class Patient
    {
        public Patient(string name, bool isMedicated)
        {
            Id = Guid.NewGuid();
            Name = name;
            IsMedicated = isMedicated;
            CreatedAt = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public bool IsMedicated { get; set; }
        public DateTime CreatedAt { get; private set; }
        public List<Medicament> Medicaments { get; private set; }
        private int medicamentQuantity;
        public int MedicamentsQuantity { 
            get { return medicamentQuantity; }
            set { medicamentQuantity = value; }
        }
    }
}
