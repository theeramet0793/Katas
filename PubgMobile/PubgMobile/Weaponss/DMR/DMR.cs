using PubgMobile.Equipments.GunAccessory;
using PubgMobile.Weaponss;
using static PubgMobile.Enum.EnumWeapon;

namespace PubgMobile.Weapons.DMR
{
    public class DMR: Gun
    {
        public DMR()
        {
            weaponType = WeaponType.DMR;
        }

        public override bool AddMagazine(Magazine magazine)
        {
            AmmoCapacity += 5;
            return true;
        }

        public override bool AddMuzzle(Muzzle muzzle)
        {
            shootingRange += 150;
            return true;
        }

        public override bool AddScope(Scope scope)
        {
            zoom += 5;
            return true;
        }
    }
}
