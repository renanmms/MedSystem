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
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var medicament = _repository.Get(id);
            return Ok(medicament);
        }

        // GET: MedicamentsController/Details/5
        

        // GET: MedicamentsController/Create
        

        // POST: MedicamentsController/Create
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model">
        /// </param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(AddMedicamentInputModel model)
        {
            var medicament = new Medicament(model.Name, model.Dose, model.Description);
            _repository.Create(medicament);
            return CreatedAtAction("Post", new {Id = medicament.Id});
        }

        // GET: MedicamentsController/Edit/5
        

        // POST: MedicamentsController/Edit/5
        

        // GET: MedicamentsController/Delete/5
        

        // POST: MedicamentsController/Delete/5
        
    }
}
