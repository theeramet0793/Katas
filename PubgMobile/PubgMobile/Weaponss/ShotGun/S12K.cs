using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumAmmoType;
using static PubgMobile.Enum.EnumWeapon;

namespace PubgMobile.Weapons.ShotGun
{
    public class S12K : ShotGun
    {
        public S12K()
        {
            name = WeaponName.S12K;
            ammoType = AmmoType.ammo12gauge;
            damage = 70;
            shootingRange = 8;
            steadiness = 3;
            recoil = 2;
        }
    }
}
