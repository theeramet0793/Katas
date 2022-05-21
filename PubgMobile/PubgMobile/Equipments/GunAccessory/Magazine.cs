using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumGunAccessory;

namespace PubgMobile.Equipments.GunAccessory
{
    public class Magazine: GunAccessory
    {
        int magazineCapacity = 30;
        public Magazine()
        {
            gunAccessoryType = GunAccessoryType.magazine;
            weight = 4;
        }
    }
}
