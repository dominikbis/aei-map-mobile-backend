using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.DAL.Entities
{
    public class Floor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Number { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}
