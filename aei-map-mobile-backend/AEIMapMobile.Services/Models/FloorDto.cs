﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.Services.Models
{
    public class FloorDto : AreaDto
    {
        public List<RoomDto> Rooms { get; set; }
        public List<PointDto> Path { get; set; }
    }
}
