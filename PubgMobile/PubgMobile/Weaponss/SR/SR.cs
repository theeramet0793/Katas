using PubgMobile.Equipments.GunAccessory;
using PubgMobile.Weaponss;
using static PubgMobile.Enum.EnumWeapon;

namespace PubgMobile.Weapons.SR
{
    public abstract class SR: Gun
    {
        public SR()
        {
            weaponType = WeaponType.SR;
        }

        public override bool AddMagazine(Magazine magazine)
        {
            AmmoCapacity += 10;
            return true;
         }

        public override bool AddMuzzle(Muzzle muzzle)
        {
            shootingRange += 200;
            return true;
        }

        public override bool AddScope(Scope scope)
        {
            zoom += 8;
            return true;
        }
    }
}
