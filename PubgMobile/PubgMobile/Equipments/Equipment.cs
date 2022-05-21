using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumEquipmentType;

namespace PubgMobile
{
    public abstract class Equipment
    {
        public EquipmentType equipmentType { get; set; }
        public int weight { get; set; }
    }
}
