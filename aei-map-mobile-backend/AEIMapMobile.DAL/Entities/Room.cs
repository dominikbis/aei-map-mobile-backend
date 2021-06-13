﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.DAL.Entities
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Number { get; set; }

        public string Name { get; set; }

        [Required, DefaultValue(false)]
        public int FloorId { get; set; }
        public Floor Floor { get; set; }

        public int? ExitPointId { get; set; }
        public PathPoint ExitPoint { get; set; }

        public ICollection<RoomPoint> Points { get; set; }
        public ICollection<FilterValue> FilterValues { get; set; }
    }
}
