using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumWeapon;

namespace PubgMobile
{
    public abstract class Weapon
    {
        public WeaponType weaponType { get; protected set; }
        public WeaponName name { get; protected set; }
        public int damage { get; protected set; }
    }
}
