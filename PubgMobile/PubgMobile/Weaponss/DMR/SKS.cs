using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumAmmoType;
using static PubgMobile.Enum.EnumWeapon;

namespace PubgMobile.Weapons.DMR
{
    public class SKS : DMR
    {
        public SKS()
        {
            name = WeaponName.SKS;
            ammoType = AmmoType.ammo7dot62mm;
            damage = 50;
            shootingRange = 350;
            steadiness = 6;
            recoil = 15;
        }
    }
}
