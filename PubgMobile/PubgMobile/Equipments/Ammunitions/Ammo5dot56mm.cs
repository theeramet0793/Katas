using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumAmmoType;

namespace PubgMobile.Equipments.Ammunitions
{
    public class Ammo5dot56mm : Ammunition
    {
        public Ammo5dot56mm()
        {
            ammoType = AmmoType.ammo5dot56mm;
            weight = 1;
        }
    }
}
