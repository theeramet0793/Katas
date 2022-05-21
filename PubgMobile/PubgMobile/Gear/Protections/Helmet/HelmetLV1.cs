using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubgMobile.Gears.Protections.Helmet
{
    public class HelmetLV1: Helmet
    {
        public HelmetLV1()
        {
            level = 1;
            armor = 80;
            damageReductionPercent = 30 ;
        }
    }
}
