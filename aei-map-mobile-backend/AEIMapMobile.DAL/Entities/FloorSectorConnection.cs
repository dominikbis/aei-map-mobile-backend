using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.DAL.Entities
{
    public class FloorSectorConnection
    {
        [Required]
        public int FloorId { get; set; }
        public Floor Floor { get; set; }

        [Required]
        public int Sector1Id { get; set; }
        public Sector Sector1 { get; set; }

        [Required]
        public int Sector2Id { get; set; }
        public Sector Sector2 { get; set; }
    }
}
