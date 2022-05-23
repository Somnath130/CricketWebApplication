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
    public class MatchesController : ControllerBase
    {
        private readonly CricketContext _cricketcontext;

        public MatchesController(CricketContext cricket_data)
        {
            _cricketcontext = cricket_data;
        }
        // GET: api/Matches
        [HttpGet]
        public IActionResult Get()
        {
            var matchesData = _cricketcontext.Matches.ToList();
            return Ok(matchesData);
        }

        /*
        // GET: api/Matches/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Matches
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Matches/5
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
