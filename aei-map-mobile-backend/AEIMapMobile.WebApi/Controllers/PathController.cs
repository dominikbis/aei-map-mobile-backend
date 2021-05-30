using AEIMapMobile.Services.Interfaces;
using AEIMapMobile.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aei_map_mobile_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PathController : Controller
    {
        private readonly IPathService pathService;

        public PathController(IPathService pathService)
        {
            this.pathService = pathService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<PathDto>))]
        public async Task<IActionResult> GetPathAsync([FromBody] PathRequestDto request)
        {
            var result = await pathService.GetPathAsync(request);
            return Ok(result);
        }
    }
}
