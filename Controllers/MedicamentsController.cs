using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MedSystem.Persistence.Repository;
using MedSystem.Models;
using MedSystem.Entities;
using AutoMapper;

namespace MedSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicamentsController : ControllerBase
    {
        private readonly IMedicamentRepository _repository;
        private readonly IMapper _mapper;

        public MedicamentsController(IMedicamentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var medicament = _repository.Get(id);
            
            if(medicament == null)
            {
                return NotFound();
            }

            return Ok(medicament);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var medicaments = _repository.GetAll();
            return Ok(medicaments);
        }

        [HttpPost]
        public IActionResult Post(AddMedicamentInputModel model)
        {
            var medicament = _mapper.Map<Medicament>(model);
            _repository.Create(medicament);
            return CreatedAtAction("Post", new { medicament.Id, medicament.Name });
        }

        [HttpPost("{id}/medicate")]
        public IActionResult Post(Guid id){
            _repository.AddPatient(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(EditMedicamentInputModel model)
        {
            var medicament = _mapper.Map<Medicament>(model);
            _repository.EditMedicament(medicament);
            return NoContent();
        }

        [HttpDelete("{id}/delete")]
        public IActionResult Delete(Guid id){
            _repository.DeleteMedicament(id);
            
            return NoContent();
        }

    }
}
