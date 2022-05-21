using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubgMobile.Gears.Rucksacks
{
    public class RucksackLV2 : Rucksack
    {
        public RucksackLV2()
        {
            weightCapacity = 300;
            freeSpaceCapacity = weightCapacity;
        }
    }
}
