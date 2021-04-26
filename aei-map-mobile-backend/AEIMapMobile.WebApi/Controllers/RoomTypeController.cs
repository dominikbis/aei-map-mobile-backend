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
    public class RoomTypeController : ControllerBase
    {
        private readonly IRoomTypeService roomTypeService;

        public RoomTypeController(IRoomTypeService roomTypeService)
        {
            this.roomTypeService = roomTypeService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<RoomTypeDto>))]
        public async Task<IActionResult> GetAllRoomTypesAsync()
        {
            var result = await roomTypeService.GetAllRoomTypesAsync();
            return Ok(result);
        }
    }
}
