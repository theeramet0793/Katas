using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumGunAccessory;

namespace PubgMobile.Equipments.GunAccessory
{
    public class Scope : GunAccessory
    {
        int magnify = 4;
        public Scope()
        {
            gunAccessoryType = GunAccessoryType.scope;
            weight = 10;
        }
    }
}
