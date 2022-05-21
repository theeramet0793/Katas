using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubgMobile.Gears.Protections.BulletProofs
{
    public class BulletProofLV1 : BulletProof
    {
        public BulletProofLV1()
        {
            level = 1;
            armor = 200;
            damageReductionPercent = 30;
        }
    }
}
