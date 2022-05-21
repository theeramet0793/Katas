using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumEquipmentType;
using static PubgMobile.Enum.EnumGunAccessory;

namespace PubgMobile.Equipments.GunAccessory
{
    public abstract class GunAccessory : Equipment
    {
        protected GunAccessory()
        {
            equipmentType = EquipmentType.gunAccesory;
        }

        public GunAccessoryType gunAccessoryType;
    }
}
