using PubgMobile;
using PubgMobile.Equipments.Ammunitions;
using PubgMobile.Equipments.GunAccessory;
using PubgMobile.Equipments.MedicalEquipments;
using PubgMobile.Gears.Protections.BulletProofs;
using PubgMobile.Gears.Protections.Helmet;
using PubgMobile.Gears.Rucksacks;
using PubgMobile.Vehicle;
using PubgMobile.Weapons.AR;
using PubgMobile.Weapons.DMR;
using PubgMobile.Weapons.Granades;
using Xunit;

namespace PubgMobileXunitTest
{
    public class CharacterXunitTest
    {

        // walk
        [Fact, Trait("walk", "")]
        public void Walk_when_energy_is_0_positionY_increse_1_unit()
        {
            Character character = new Character();
            var beforeWalk = character.positionY;

            character.Walk();
            var afterWalk = character.positionY;

            Assert.Equal(beforeWalk+1,afterWalk);
        }

        [Fact, Trait("walk", "")]
        public void Walk_when_energy_is_100_positionY_increse_3_unit()
        {
            Character character = new Character();
            PainKiller painKiller = new PainKiller();
            RucksackLV1 rucksackLV1 = new RucksackLV1();
            character.Wear(rucksackLV1);
            character.Pick(painKiller);
            character.Pick(painKiller);
            character.Use(painKiller);
            character.Use(painKiller);
            var beforeWalk = character.positionY;

            character.Walk();
            var afterWalk = character.positionY;

            Assert.Equal(beforeWalk + 3, afterWalk);
        }

        // wasAttack
        [Fact, Trait("WasAttack", "")]
        public void WasAttack_by_AKM_HP_decrease_30()
        {
            Character character = new Character();
            AKM akm = new AKM();

            character.wasAttack(akm);
            var currentHP = character.HP;

            Assert.Equal(70, currentHP);
        }

        [Fact, Trait("WasAttack", "")]
        public void WasAttack_by_M416_HP_decrease_20()
        {
            Character character = new Character();
            M416 m416 = new M416();

            character.wasAttack(m416);
            var currentHP = character.HP;

            Assert.Equal(80, currentHP);
        }

        [Fact, Trait("WasAttack", "")]
        public void WasAttack_by_Mini14_HP_decrease_50()
        {
            Character character = new Character();
            Mini14 mini14 = new Mini14();

            character.wasAttack(mini14);
            var currentHP = character.HP;

            Assert.Equal(50, currentHP);
        }

        [Fact, Trait("WasAttack", "")]
        public void WasAttack_by_flagGranade_HP_decrease_200()
        {
            Character character = new Character();
            FlagGranade flagGranade = new FlagGranade();

            character.wasAttack(flagGranade);
            var currentHP = character.HP;

            Assert.Equal(0, currentHP);
        }

        // Drive
        [Fact, Trait("Drive", "")]
        public void Drive_motorcycle_movingSpeed_increase_140()
        {
            Character character = new Character();
            Motorcycle motocycle = new Motorcycle();

            character.Drive(motocycle);
            var movingSpeed = character.movingSpeed;

            Assert.Equal(140, movingSpeed);
        }

        // getOff
        [Fact, Trait("GetOff", "")]
        public void GetOff_movingSpeed_decrease_to_0()
        {
            Character character = new Character();
            Motorcycle motocycle = new Motorcycle();

            character.Drive(motocycle);
            character.GetOff();

            var movingSpeed = character.movingSpeed;

            Assert.Equal(0, movingSpeed);
        }

        // Wear protection
        [Fact, Trait("Wear", "protection")]
        public void Wear_BulletProofLV1_armorOnBody_increased_200()
        {
            Character character = new Character();
            BulletProofLV1 bulletProofLV1 = new BulletProofLV1();

            character.Wear(bulletProofLV1);
            var armorOnbody = character.armorOnBody;

            Assert.Equal(200,armorOnbody);

        }

        [Fact, Trait("Wear", "protection")]
        public void Wear_BulletProofLV1_dmgReductionOnBody_increased_30()
        {
            Character character = new Character();
            BulletProofLV1 bulletProofLV1 = new BulletProofLV1();

            character.Wear(bulletProofLV1);
            var dmgReductionOnbody = character.damageReductionOnBody;

            Assert.Equal(30, dmgReductionOnbody);

        }

        [Fact, Trait("Wear", "protection")]
        public void Wear_HelmetLV3_armorOnHead_increased_230()
        {
            Character character = new Character();
            HelmetLV3 helmetLV3 = new HelmetLV3();

            character.Wear(helmetLV3);
            var armorOnHead = character.armorOnHead;

            Assert.Equal(230, armorOnHead);

        }

        [Fact, Trait("Wear", "protection")]
        public void Wear_HelmetLV3_dmgReductionOnHead_increased_55()
        {
            Character character = new Character();
            HelmetLV3 helmetLV3 = new HelmetLV3();

            character.Wear(helmetLV3);
            var dmgReductionOnHead = character.damageReductionOnHead;

            Assert.Equal(55, dmgReductionOnHead);

        }

        // Wear rucsack
        [Fact,Trait("Wear","Rucksack")]
        public void Wear_rucksack_weightCapacity_increase_200()
        {
            Character character = new Character();
            RucksackLV1 rucksackLV1 = new RucksackLV1();

            character.Wear(rucksackLV1);
            var weightCapacity = character.myRucksack.weightCapacity;

            Assert.Equal(200, weightCapacity);
        }

        // Pick equipment
        [Fact, Trait("Pick", "Equipment")]
        public void Pick_equipment_weightCapacity_decrease()
        {
            Character character = new Character();
            RucksackLV1 rucksackLV1 = new RucksackLV1();
            MedKit medKit = new MedKit();
            Ammo12Gauge ammo12Gauge = new Ammo12Gauge();

            character.Wear(rucksackLV1);
            character.Pick(medKit);
            character.Pick(ammo12Gauge);
           var weightCapacity = character.myRucksack.freeSpaceCapacity;

            Assert.Equal(191, weightCapacity);
        }

        // Pick equipment
        [Fact, Trait("Pick", "Equipment")]
        public void Pick_equipment_while_rucksack_full_return_false()
        {
            Character character = new Character();
            RucksackLV1 rucksackLV1 = new RucksackLV1();
            MedKit medKit = new MedKit();

            character.Wear(rucksackLV1);
            character.myRucksack.freeSpaceCapacity = 0;
            var result = character.Pick(medKit);

            Assert.False(result);
        }

        // Pick AKM
        [Fact, Trait("Pick", "Gun")]
        public void Pick_AKM()
        {
            var character = new Character();
            var rucksackLV1 = new RucksackLV1();
            var akm = new AKM();

            character.Wear(rucksackLV1);
            character.Pick(akm);
            var currentGun = character.myGun;

            Assert.Equal(akm, currentGun);
        }

        // Use Medical equipment
        [Fact, Trait("Use", "")]
        public void Use_MedKit_HP_increase_100()
        {
            var character = new Character();
            var rucksackLV1 = new RucksackLV1();
            var medkit = new MedKit();

            character.Wear(rucksackLV1);
            character.Pick(medkit);
            character.wasAttack(new AKM());
            character.Use(medkit);

            var currentHP = character.HP;

            Assert.Equal(100, currentHP);
        }

        [Fact, Trait("Use", "")]
        public void Use_PainKiller_energy_increase_50()
        {
            var character = new Character();
            var rucksackLV1 = new RucksackLV1();
            var painkiller = new PainKiller();

            character.Wear(rucksackLV1);
            character.Pick(painkiller);
            character.wasAttack(new AKM());
            character.Use(painkiller);

            var currentEnergy = character.energy;

            Assert.Equal(50, currentEnergy);
        }

        [Fact, Trait("Use", "")]
        public void Use_PainKiller_but_dont_have_in_rucksack()
        {
            var character = new Character();
            var rucksackLV1 = new RucksackLV1();
            var painkiller = new PainKiller();

            character.Wear(rucksackLV1);
            //character.Pick(painkiller);
            character.wasAttack(new AKM());
            var result = character.Use(painkiller);

            Assert.False(result);
        }

        // Install Gun accessory
        [Fact, Trait("InstallGunAccessory", "")]
        public void Install_Grip_On_M416_reduce_recoil_()
        {
            var character = new Character();
            var rucksackLV1 = new RucksackLV1();
            var grip = new Grip();
            var m416 = new M416();

            character.Wear(rucksackLV1);
            character.Pick(grip);
            character.Pick(m416);
            character.InstallGunAccessory(grip);

            var currentRecoil = character.myGun.recoil;

            Assert.Equal(4, currentRecoil);
        }

        // wasAttack until dead
        [Fact, Trait("Dead", "")]
        public void wasAttack_until_dead()
        {
            var character = new Character();

            character.wasAttack(new FlagGranade() );
            var result = character.Dead();

            Assert.Equal("Dead", result);
        }
    }
}