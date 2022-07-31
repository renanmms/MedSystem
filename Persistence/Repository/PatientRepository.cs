﻿using MedSystem.Entities;

namespace MedSystem.Persistence.Repository
{
    public class PatientRepository : IPatientRepository
    {
        private readonly MedSystemDbContext _context;
        public PatientRepository(MedSystemDbContext context)
        {
            _context = context;
        }
        public void Create(Patient patient)
        {
            _context.Patients.Add(patient);
        }

        public List<Patient> GetAll()
        {
            var patients = _context.Patients.ToList();
            return patients;
        }

        public Patient GetById(Guid id)
        {
            var patient = _context.Patients.SingleOrDefault(p => p.Id == id);
            return patient;
        }

        public void IsMedicated(Guid id)
        {
            var patient = _context.Patients.SingleOrDefault(p => p.Id == id);
            patient.IsMedicated = true;
        }

        public int MedicamentsQuantity(Guid id)
        {
            var patient = _context.Patients.SingleOrDefault(p => p.Id == id);
            var medicamentsQuantity = patient.Medicaments.Count();
            return medicamentsQuantity;
        }
    }
}
