using Microsoft.AspNetCore.Mvc;

namespace UnlimitedSpaceService.PlanetSection.Controllers
{
    [Route("api/planet")]
    [ApiController]
    public class PlanetController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<string> GetPlanetById(string id)
        {
            return $"planet-test-response planetId: {id}";
        }
    }
}
