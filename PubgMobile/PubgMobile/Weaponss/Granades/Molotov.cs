using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumWeapon;

namespace PubgMobile.Weapons.Granades
{
    public class Molotov : Granade
    {
        public Molotov()
        {
                name = WeaponName.MoloTovCocktail;
                damage = 20;
                throwRange = 20;
                radiusDamage = 3;          
        }
    }
}
