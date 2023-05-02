using MedSystem.Entities;
using MedSystem.Models;
using MedSystem.Persistence.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientRepository _repository;

        public PatientsController(IPatientRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var patients = _repository.GetAll();
            
            if(patients == null)
            {
                return NotFound();
            }

            return Ok(patients);
        }

        [HttpGet("{id}/details")]
        public IActionResult GetById(Guid id) {
            var patient = _repository.GetById(id);

            if(patient == null)
            {
                return NotFound($"The patient with the Id: {id} was not found");
            }
            return Ok(patient);
        }

        [HttpPost("create")]
        public IActionResult Post(AddPatientInputModel model)
        {
            var patient = new Patient(model.Name, model.IsMedicated);
            _repository.Create(patient);
            return CreatedAtAction("Post", new { patient.Id, patient.Name, patient.CreatedAt});
        }

        [HttpPut("{id}/medicate")]
        public IActionResult Put(Guid id){
            _repository.IsMedicated(id);
            return NoContent();
        }

    }
}
