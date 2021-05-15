using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.DAL.Entities
{
    public class Room : Area
    {
        public string Name { get; set; }
        public List<RoomType> Types { get; set; }
        public List<Point> Points { get; set; }
    }
}
