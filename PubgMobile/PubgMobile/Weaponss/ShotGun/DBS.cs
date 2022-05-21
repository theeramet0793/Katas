using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumAmmoType;
using static PubgMobile.Enum.EnumWeapon;

namespace PubgMobile.Weapons.ShotGun
{
    public class DBS : ShotGun
    {
        public DBS()
        {
            name = WeaponName.DBS;
            ammoType = AmmoType.ammo12gauge;
            damage = 90;
            shootingRange = 10;
            steadiness = 3;
            recoil = 2;
        }
    }
}
