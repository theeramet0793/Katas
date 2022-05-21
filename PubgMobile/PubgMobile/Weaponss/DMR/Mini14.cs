using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumAmmoType;
using static PubgMobile.Enum.EnumWeapon;

namespace PubgMobile.Weapons.DMR
{
    public class Mini14 : DMR
    {
        public Mini14()
        {
            name = WeaponName.Mini14;
            ammoType = AmmoType.ammo5dot56mm;
            damage = 50;
            shootingRange = 300;
            steadiness = 6;
            recoil = 6;
        }
    }
}
