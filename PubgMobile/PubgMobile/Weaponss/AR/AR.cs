using PubgMobile.Equipments.GunAccessory;
using PubgMobile.Weaponss;
using static PubgMobile.Enum.EnumWeapon;

namespace PubgMobile.Weapons.AR
{
    public abstract class AR : Gun
    {
        public AR()
        {
            weaponType = WeaponType.AR;
        }

        public override bool AddGrip(Grip grip)
        {
            recoil -= grip.reduceRecoil;
            steadiness -= grip.reduceSteadiness;
            return true;
        }

        public override bool AddMagazine(Magazine magazine)
        {
            AmmoCapacity += 15;
            return true;
        }

        public override bool AddMuzzle(Muzzle muzzle)
        {
            shootingRange += 100;
            return true;
        }

        public override bool AddScope(Scope scope)
        {
            zoom += 3;
            return true;
        }
    }
}
