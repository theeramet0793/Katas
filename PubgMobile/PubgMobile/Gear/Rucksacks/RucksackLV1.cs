using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubgMobile.Gears.Rucksacks
{
    public class RucksackLV1 : Rucksack
    {
        public RucksackLV1()
        {
            weightCapacity = 200;
            freeSpaceCapacity = weightCapacity;
        }
    }
}
