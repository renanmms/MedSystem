using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientsController : ControllerBase
    {
        // GET: PatientsController
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        // GET: PatientsController/Details/5


        // GET: PatientsController/Create


        // POST: PatientsController/Create


        // GET: PatientsController/Edit/5


        // POST: PatientsController/Edit/5


        // GET: PatientsController/Delete/5


        // POST: PatientsController/Delete/5

    }
}
