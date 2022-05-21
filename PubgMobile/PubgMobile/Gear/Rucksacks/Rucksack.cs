using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumGearType;

namespace PubgMobile.Gears.Rucksacks
{
    public class Rucksack: Gear
    {
        public int weightCapacity ;
        public int freeSpaceCapacity ;
        public List<Equipment> equipmentList  = new List<Equipment>();
        public Rucksack()
        {
            gearType = GearType.rucksack;
        }

        

    }
}
