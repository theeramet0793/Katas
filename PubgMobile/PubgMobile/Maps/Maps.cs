using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumMapName;

namespace PubgMobile.Maps
{
    public abstract class Maps
    {
        public MapName mapName { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int[] PlayZoneCenterXY { get; set; } = new int[2];
        public int PlayZoneRadius { get; set; }
        public int characterCapacity { get; set; }
        public List<Character>? characterInMap { get; set; }
    }
}
