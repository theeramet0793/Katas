using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumWeapon;

namespace PubgMobile.Weapons
{
    public class Granade: Weapon
    {
        public int throwRange;
        public int radiusDamage { get; set; }
        public Granade()
        {
            weaponType = WeaponType.Granade;
        }
    }
}
