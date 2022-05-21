using PubgMobile.Equipments.GunAccessory;
using PubgMobile.Weaponss;
using static PubgMobile.Enum.EnumWeapon;

namespace PubgMobile.Weapons.ShotGun
{
    public abstract class ShotGun: Gun
    {
        public ShotGun()
        {
            weaponType = WeaponType.Shotgun;
        }

        public override bool AddMagazine(Magazine magazine)
        {
            AmmoCapacity += 7;
            return true;
         }
    }
}
