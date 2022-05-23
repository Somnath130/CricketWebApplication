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
    public class CountryController : ControllerBase
    {
        private readonly CricketContext _cricketcontext;

        public CountryController(CricketContext cricket_data)
        {
            _cricketcontext = cricket_data;
        }

        // GET: api/Country
        [HttpGet]
        public IActionResult Get()
        {
            var countryData = _cricketcontext.Country.ToList();
            return Ok(countryData);
        }
        /*
        // GET: api/Country/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Country
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Country/5
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
