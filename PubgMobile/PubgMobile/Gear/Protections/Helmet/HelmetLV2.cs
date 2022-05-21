using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubgMobile.Gears.Protections.Helmet
{
    public class HelmetLV2 : Helmet
    {
        public HelmetLV2()
        {
            level = 2;
            armor = 150;
            damageReductionPercent = 40;
        }
    }
}
