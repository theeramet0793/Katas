using PubgMobile.Equipments.GunAccessory;
using PubgMobile.Gears.Protections.BulletProofs;
using PubgMobile.Gears.Protections.Helmet;
using PubgMobile.Gears.Rucksacks;
using static PubgMobile.EnumSex;
using PubgMobile.Gears.Protections;
using static PubgMobile.Enum.EnumProtectionType;
using PubgMobile.Weaponss;
using static PubgMobile.Enum.EnumGunAccessory;
using PubgMobile.Vehicle;

namespace PubgMobile
{
    public class Character
    {
        public string name { get; set; } = string.Empty;
        public int HP { get;protected set; } = 100;
        public int positionX { get; set; } = 0;
        public int positionY { get; set; } = 0;
        public int positionZ { get; set; } = 0;
        public int movingSpeed { get; set; } = 0;
        public int energy { get;protected set; } = 0;
        public int damageReductionOnHead { get; set; } = 0;
        public int damageReductionOnBody { get; set; } = 0;
        public int armorOnHead { get; set; } = 0;
        public int armorOnBody { get; set; } = 0;
        public Gun? myGun { get; set; } = null;
        public Sex sex { get; set; }
        public Rucksack? myRucksack { get; set; } = null;
        public Helmet? myHelmet { get; set; } = null;
        public BulletProof? mybulletProof { get; set; } = null;

        public void wasAttack( Weapon weapon)
        {
            HP -= weapon.damage;
            if (HP <= 0) 
            {
                HP = 0;
                Dead(); 
            }
        }
        public void Shoot()
        {

        }
        public void Walk()
        {
            positionY += (1 + (int)(energy * 0.02));
        }
        public void Run()
        {
            positionY += 2 + (int)(energy * 0.02);
        }
        public void Jump()
        {
            positionZ += 2;
        }
        public void Sitdown()
        {
            positionZ -= 1;
        }
        public void Drive(Vehicles vehicles)
        {
            movingSpeed = vehicles.speed;
        }
        public bool GetOff( )
        {
            if( movingSpeed > 0)
            {
                movingSpeed = 0;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Crouchdown()
        {
            positionZ -= 2 ;
        }
        public void Wear( Protection protection )
        {
            if ( protection.protectionType == ProtectionType.helmet )
            {
                armorOnHead = protection.armor;
                damageReductionOnHead = protection.damageReductionPercent;
            }
            else if (protection.protectionType == ProtectionType.bulletProof)
            {
                armorOnBody = protection.armor;
                damageReductionOnBody = protection.damageReductionPercent;
            }
            else
            {
                throw new Exception("Invalid wearing protections type");
            }
        }
        public void Wear( Rucksack rucksack)
        {
            myRucksack = rucksack;
        }
        public bool Pick( Equipment equipment)
        {
            if( myRucksack != null)
            {
                if( myRucksack.freeSpaceCapacity >= equipment.weight)
                {
                    myRucksack.equipmentList.Add(equipment);
                    myRucksack.freeSpaceCapacity -= equipment.weight;
                    return true;
                }
            }
            return false;
        }
        public bool Pick( Gun gun)
        {
            myGun = gun;
            return true;
        }
        public bool Use( MedicalEquipment medicalEquipment)
        {
            if( myRucksack != null) 
            if ( myRucksack.equipmentList.Contains(medicalEquipment) )
            {
                HP += medicalEquipment.healHP;
                energy += medicalEquipment.healEnergy;
                if (HP > 100) HP = 100;
                if (energy > 100) energy = 100;
                return true;
            }
            return false ;
        }
        public bool InstallGunAccessory( GunAccessory gunAccessory)
        {
            bool InstallSuccess = false;
            if( myRucksack != null )
            if( myRucksack.equipmentList.Contains(gunAccessory) )
            if(myGun != null)
                    {
                        switch (gunAccessory.gunAccessoryType)
                        {
                            case GunAccessoryType.muzzle:
                                InstallSuccess = myGun.AddMuzzle((Muzzle)gunAccessory);
                                break;
                            case GunAccessoryType.magazine:
                                InstallSuccess = myGun.AddMagazine((Magazine)gunAccessory);
                                break;
                            case GunAccessoryType.scope:
                                InstallSuccess = myGun.AddScope((Scope)gunAccessory);
                                break;
                            case GunAccessoryType.grip:
                                InstallSuccess = myGun.AddGrip((Grip)gunAccessory);
                                break;
                        }

                        if (InstallSuccess)
                        {
                            myRucksack.equipmentList.Remove(gunAccessory);
                        }
                    }
            
            return false;
        }
        public string Dead()
        {
            return "Dead";
        }
    }
}
