﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.Services.Models
{
    public class FilteredRoomsRequestDto
    {
        public int FloorId { get; set; }
        public IEnumerable<int> FilterIds { get; set; }
    }
}