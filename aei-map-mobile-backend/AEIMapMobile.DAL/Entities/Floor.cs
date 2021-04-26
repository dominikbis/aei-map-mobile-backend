using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.DAL.Entities
{
    public class Floor
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
