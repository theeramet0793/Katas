using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumAmmoType;
using static PubgMobile.Enum.EnumWeapon;

namespace PubgMobile.Weapons.SR
{
    public class M24 : SR
    {
        public M24()
        {
            name = WeaponName.M24;
            ammoType = AmmoType.ammo7dot62mm;
            damage = 90;
            shootingRange = 330;
            steadiness = 3;
            recoil = 2;
        }
    }
}
