using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumGunAccessory;

namespace PubgMobile.Equipments.GunAccessory
{
    public class Grip : GunAccessory
    {
        public int reduceRecoil = 3;
        public int reduceSteadiness = 5;
        public Grip()
        {
            gunAccessoryType = GunAccessoryType.grip;
            weight = 3;
        }
    }
}
