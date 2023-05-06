using AutoMapper;
using MedSystem.Entities;
using MedSystem.Models;

namespace MedSystem.Profiles
{
    public class MedicamentProfile : Profile
    {
        public MedicamentProfile()
        {
            CreateMap<EditMedicamentInputModel, Medicament>();
            CreateMap<AddMedicamentInputModel, Medicament>();
        }
    }
}