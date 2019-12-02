using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuardiasAPI_Jobs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GuardiasAPI_Jobs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly GuardiasAPIDbContext _context;
        public JobController(GuardiasAPIDbContext context)
        {
            _context = context;//Inyecto depedencia
        }
        [HttpGet("[action]")]//Forma de routeo
        public IActionResult ObtenerJobs()
        {
            var job = _context.Jobs.ToList();
            return Ok(job);
        }
    }
}