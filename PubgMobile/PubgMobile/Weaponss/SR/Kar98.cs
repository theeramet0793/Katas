using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumAmmoType;
using static PubgMobile.Enum.EnumWeapon;

namespace PubgMobile.Weapons.SR
{
    public class Kar98 : SR
    {
        public Kar98()
        {
            name = WeaponName.Kar98;
            ammoType = AmmoType.ammo7dot62mm;
            damage = 110;
            shootingRange = 350;
            steadiness = 5;
            recoil = 3;
        }
    }
}
