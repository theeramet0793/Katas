using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumAmmoType;
using static PubgMobile.Enum.EnumWeapon;

namespace PubgMobile.Weapons.AR
{
    public class M416: AR
    {
        public M416()
        {
            name = WeaponName.M416;
            ammoType = AmmoType.ammo5dot56mm;
            damage = 20;
            shootingRange = 100;
            steadiness = 5;
            recoil = 7;
        }
    }
}
