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
    public class FilterController : Controller
    {
        private readonly IFilterService filterService;

        public FilterController(IFilterService filterService)
        {
            this.filterService = filterService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<FilterDto>))]
        public async Task<IActionResult> GetAllFiltersAsync()
        {
            var result = await filterService.GetAllFiltersAsync();
            return Ok(result);
        }
    }
}
