using static PubgMobile.Enum.EnumAmmoType;
using static PubgMobile.Enum.EnumWeapon;

namespace PubgMobile.Weapons.AR
{
    public class AKM : AR
    {
        public AKM()
        {
            name = WeaponName.AKM;
            ammoType = AmmoType.ammo7dot62mm;
            damage = 30;
            shootingRange = 150;
            steadiness = 10;
            recoil = 10;
        }


    }
}
