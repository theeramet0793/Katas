using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumAmmoType;

namespace PubgMobile.Equipments.Ammunitions
{
    public class Ammo7dot62mm : Ammunition
    {
        public Ammo7dot62mm()
        {
            ammoType = AmmoType.ammo7dot62mm;
            weight = 2;
        }
    }
}
