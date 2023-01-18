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
        // GET: PatientsController
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

        // GET: PatientsController/Details/5
        [HttpGet("Details/{id}")]
        public IActionResult GetById(Guid id) {
            var patient = _repository.GetById(id);

            if(patient == null)
            {
                return NotFound($"The patient with the Id: {id} was not found");
            }
            return Ok(patient);
        }

        // GET: PatientsController/Create

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// "name": "Renan",
        /// "isMedicated": false
        /// </remarks>
        /// <param name="model"></param>
        /// <returns>Patient Created</returns>
        // POST: PatientsController/Create
        [HttpPost("Create")]
        public IActionResult Post(AddPatientInputModel model)
        {
            var patient = new Patient(model.Name, model.IsMedicated);
            _repository.Create(patient);
            return CreatedAtAction("Post", new { patient.Id, patient.Name, patient.CreatedAt});
        }

        // GET: PatientsController/Edit/5


        // POST: PatientsController/Edit/5


        // GET: PatientsController/Delete/5


        // POST: PatientsController/Delete/5

    }
}
