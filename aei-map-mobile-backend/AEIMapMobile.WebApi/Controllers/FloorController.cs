using AEIMapMobile.Services.Interfaces;
using AEIMapMobile.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AEIMapMobile.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FloorController : Controller
    {
        private readonly IFloorService floorService;

        public FloorController(IFloorService floorService)
        {
            this.floorService = floorService;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(FloorDto))]
        public async Task<IActionResult> GetFloorByIdAsync(int id)
        {
            var result = await floorService.GetFloorByIdAsync(id);
            return Ok(result);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<AreaDto>))]
        public async Task<IActionResult> GetFloorIdsAndNumbersAsync()
        {
            var result = await floorService.GetAllFloorIdsAndNumbersAsync();
            return Ok(result);
        }
    }
}
