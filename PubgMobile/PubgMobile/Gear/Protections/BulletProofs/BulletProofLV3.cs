using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubgMobile.Gears.Protections.BulletProofs
{
    public class BulletProofLV3 : BulletProof
    {
        public BulletProofLV3()
        {
            level = 3;
            armor = 250;
            damageReductionPercent = 55;
        }
    }
}
