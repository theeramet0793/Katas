using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumGearType;
using static PubgMobile.Enum.EnumProtectionType;

namespace PubgMobile.Gears.Protections.Helmet
{
    public abstract class Helmet : Protection
    {
        public Helmet()
        {
            gearType = GearType.protection ;
            protectionType = ProtectionType.helmet ;
        }
    }
}
