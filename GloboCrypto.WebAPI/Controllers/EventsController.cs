using GloboCrypto.WebAPI.Services.Events;
using GloboCrypto.WebAPI.Services.Models;
using Microsoft.AspNetCore.Mvc;

namespace GloboCrypto.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        public readonly IEventService EventService;

        public EventsController(IEventService eventService)
        {
            EventService = eventService;
        }

        [HttpGet("dump")]
        public async Task<IEnumerable<EventLogEntry>> DumpLogs()
        {
            return await EventService.GetAllEvents();
        }
    }
}
