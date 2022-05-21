using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubgMobile.Gears.Protections.BulletProofs
{
    public class BulletProofLV2: BulletProof
    {
        public BulletProofLV2()
        {
            level = 2;
            armor = 220;
            damageReductionPercent = 40;
        }
    }
}
