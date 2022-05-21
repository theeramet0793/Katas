using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumAmmoType;
using static PubgMobile.Enum.EnumEquipmentType;

namespace PubgMobile.Equipments.Ammunitions
{
    public abstract class Ammunition: Equipment
    {
        public AmmoType ammoType;

        protected Ammunition()
        {
            equipmentType = EquipmentType.ammunition;
        }
    }
}
