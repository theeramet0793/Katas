using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumGearType;
using static PubgMobile.Enum.EnumProtectionType;

namespace PubgMobile.Gears.Protections.BulletProofs
{
    public abstract class BulletProof : Protection
    {
        public BulletProof()
        {
            gearType = GearType.protection;
            protectionType = ProtectionType.bulletProof;
        }
    }
}
