using System.Threading.Tasks;
using Betinvest.SDK;
using BIExample.Controllers.Requests;
using Microsoft.AspNetCore.Mvc;

namespace BIExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        private readonly BetinvestFeedClient _client;

        public ApiController(BetinvestClientSingleton client)
        {
            _client = client.Instance;

        }


        [Route("sportlist")]
        [HttpPost]
        public async Task<IActionResult> Sports()
        {
            await _client.GetSport();
            return Ok();
        }


        [Route("categorylist")]
        [HttpPost]
        public async Task<IActionResult> Category()
        {
            await _client.GetCategory();
            return Ok();
        }

        [Route("tournamentlist")]
        [HttpPost]
        public async Task<IActionResult> Tournament()
        {
            await _client.GetTournaments();
            return Ok();
        }


        [Route("eventlist")]
        [HttpPost]
        public async Task<IActionResult> Events([FromBody]EventRequest request)
        {
            await _client.GetEvents(request.SportId, request.CategoryId, request.TournamentId, request.StartDate, request.EndDate);
            return Ok();
        }


        [Route("expiredeventlist")]
        [HttpPost]
        public async Task<IActionResult> ExpiredEventList()
        {
            await _client.GetExpiredEventList();
            return Ok();
        }

        [Route("eventinfo")]
        [HttpPost]
        public async Task<IActionResult> EventInfo([FromBody]EventIdRequest request)
        {
            await _client.GetEventsInfo(request.EventId);
            return Ok();
        }


        [Route("eventreset")]
        [HttpPost]
        public async Task<IActionResult> EventReset([FromBody]EventIdRequest request)
        {
            await _client.GetEventReset(request.EventId);
            return Ok();
        }

        [Route("eventsettle")]
        [HttpPost]
        public async Task<IActionResult> EventSettle([FromBody]EventIdRequest request)
        {
            await _client.GetEventSettle(request.EventId);
            return Ok();
        }
    }
}
