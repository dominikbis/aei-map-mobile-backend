using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.DAL.Entities
{
    public class RoomPoint
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int X { get; set; }

        [Required]
        public int Y { get; set; }

        [Required]
        public int Order { get; set; }


        [Required, DefaultValue(false)]
        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}
