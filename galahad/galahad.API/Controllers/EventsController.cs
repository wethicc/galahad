using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using galahad.API.Services;
using galahad.Models;
using Microsoft.AspNetCore.Mvc;

namespace galahad.API.Controllers
{
    [Route("api/events")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly EventService _eventService;

        public EventsController(EventService eventService)
        {
            _eventService = eventService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/events/5
        [HttpGet("{id}")]
        public ActionResult<Event> Get(string id)
        {
            return _eventService.Get(id);
        }

        [HttpGet]
        public ActionResult<Event[]> GetForUser([FromBody]int userId)
        {
            return new ActionResult<Event[]>(new Event[] { });
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
