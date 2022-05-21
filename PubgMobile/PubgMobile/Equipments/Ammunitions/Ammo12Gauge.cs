using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumAmmoType;

namespace PubgMobile.Equipments.Ammunitions
{
    public class Ammo12Gauge : Ammunition
    {
        public Ammo12Gauge()
        {
            ammoType = AmmoType.ammo12gauge;
            weight = 4;
        }
    }
}
