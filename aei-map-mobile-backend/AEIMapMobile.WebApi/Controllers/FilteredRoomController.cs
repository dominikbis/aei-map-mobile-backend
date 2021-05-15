using AEIMapMobile.Services.Interfaces;
using AEIMapMobile.Services.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace aei_map_mobile_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilteredRoomController : Controller
    {
        private readonly IFilteredRoomService filteredRoomService;
        public FilteredRoomController(IFilteredRoomService filteredRoomService)
        {
            this.filteredRoomService = filteredRoomService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<AreaDto>))]
        public async Task<IActionResult> GetFilteredRoomsAsync(int[] filterIds)
        {
            var result = await filteredRoomService.GetFilteredRoomsAsync(filterIds);
            return Ok(result);
        }
    }
}
