using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumGunAccessory;

namespace PubgMobile.Equipments.GunAccessory
{
    public class Muzzle : GunAccessory
    {
        int reduceRecoil = 10;
        public Muzzle()
        {
            gunAccessoryType = GunAccessoryType.muzzle;
            weight = 3;
        }
    }
}
