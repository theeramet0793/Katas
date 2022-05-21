using PubgMobile.Equipments.GunAccessory;
using static PubgMobile.Enum.EnumAmmoType;

namespace PubgMobile.Weaponss
{
    public abstract class Gun: Weapon
    {
        public AmmoType ammoType;
        public int recoil;
        public int steadiness;
        public int zoom = 0;
        public int shootingRange;
        public int AmmoCapacity = 10;

        public virtual bool AddMagazine(Magazine magazine)
        {
            return false;
        }
        public virtual bool AddGrip(Grip grip)
        {
            return false;
        }
        public virtual bool AddMuzzle(Muzzle muzzle)
        {
            return false ;
        }
        public virtual bool AddScope(Scope scope)
        {
            return false;
        }

    }
}
