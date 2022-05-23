using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cricket_Database.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cricket_Database.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StadiumController : ControllerBase
    {
        private readonly CricketContext _cricketcontext;

        public StadiumController(CricketContext cricket_data)
        {
            _cricketcontext = cricket_data;
        }

        // GET: api/Stadium
        [HttpGet]
        public IActionResult Get()
        {
            var stadiumData = _cricketcontext.Stadium.ToList();
            return Ok(stadiumData);
        }

        /*
        // GET: api/Stadium/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Stadium
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Stadium/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
