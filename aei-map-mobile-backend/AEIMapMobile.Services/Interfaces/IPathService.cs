using AEIMapMobile.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.Services.Interfaces
{
    public interface IPathService
    {
        public Task<PathDto> GetPathAsync(PathRequestDto model);
    }
}
