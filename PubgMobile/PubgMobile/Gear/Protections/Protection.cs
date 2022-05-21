using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumGearType;
using static PubgMobile.Enum.EnumProtectionType;

namespace PubgMobile.Gears.Protections
{
    public abstract class Protection: Gear
    {
        public ProtectionType   protectionType { get; set; }
        public int armor { get; set; }
        public int damageReductionPercent { get; set; }
    }
}
