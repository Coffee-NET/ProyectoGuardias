using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuardiasAPI.Jobs.Models.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GuardiasAPI_Jobs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly JobDbContext _context;

        public JobsController(JobDbContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Job>> ConsultarJobs()
        {
            return _context.Jobs;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Job> ConsultarJob(int id)
        {
            var job = _context.Jobs.Find(id);

            if (job == null)
            {
                return NotFound();
            }

            return job;
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Job> AltaJob(Job job)
        {
            _context.Jobs.Add(job);
            _context.SaveChanges();

            return CreatedAtAction("ConsultarJob", new Job { Id = job.Id }, job);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void ModificarJob(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void BajaJob(int id)
        {
        }
    }
}