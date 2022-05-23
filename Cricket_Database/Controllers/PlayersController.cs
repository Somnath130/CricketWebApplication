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
    public class PlayersController : ControllerBase
    {
        private readonly CricketContext _cricketcontext;

        public PlayersController(CricketContext cricket_data)
        {
            _cricketcontext = cricket_data;
        }

        // GET: api/Players
        [HttpGet]
        public IActionResult Get()
        {
            var playerData = _cricketcontext.Players.ToList();
            return Ok(playerData);
        }
        // GET: api/Players/5
       /* [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Players
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Players/5
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
