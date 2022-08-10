using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MedSystem.Persistence.Repository;
using MedSystem.Models;
using MedSystem.Entities;

namespace MedSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicamentsController : ControllerBase
    {
        private readonly IMedicamentRepository _repository;

        public MedicamentsController(IMedicamentRepository repository)
        {
            _repository = repository;
        }
        // GET: MedicamentsController
        [HttpGet("Details/{id}")]
        public IActionResult Get(Guid id)
        {
            var medicament = _repository.Get(id);
            
            if(medicament == null)
            {
                return NotFound();
            }

            return Ok(medicament);
        }

        // GET: MedicamentsController/Details/5
        [HttpGet("Details")]
        public IActionResult GetAll()
        {
            var medicaments = _repository.GetAll();
            return Ok(medicaments);
        }

        // GET: MedicamentsController/Create
        

        // POST: MedicamentsController/Create
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Request Body Example:
        /// "name": "Tylenol",
        /// "dose": "10 mg",
        /// "description": "Medicament for headches or fewer symptoms"
        /// </remarks>
        /// <param name="model"> Medicament data </param>
        /// <returns> Created Object </returns>
        [HttpPost]
        public IActionResult Post(AddMedicamentInputModel model)
        {
            var medicament = new Medicament(model.Name, model.Dose, model.Description);
            _repository.Create(medicament);
            return CreatedAtAction("Post", medicament.Id);
        }

        // GET: MedicamentsController/Edit/5
        

        // POST: MedicamentsController/Edit/5
        

        // GET: MedicamentsController/Delete/5
        

        // POST: MedicamentsController/Delete/5
        
    }
}
