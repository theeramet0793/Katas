using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumGearType;

namespace PubgMobile.Gears
{
    public abstract class Gear
    {
        public GearType gearType { get; set; }
        public int level { get; set; }
    }
}
