using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.DAL.Entities
{
    public class Sector
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<FloorSectorConnection> Sector1Connections { get; set; }
        public ICollection<FloorSectorConnection> Sector2Connections { get; set; }
    }
}
