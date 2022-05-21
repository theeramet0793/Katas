using PubgMobile.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumEquipmentType;
using static PubgMobile.Enum.EnumMedicalType;

namespace PubgMobile
{
    public abstract class MedicalEquipment : Equipment
    {
        public MedicalType medicalType { get; set; }
        public int healHP { get; set; } = 0;
        public int healEnergy { get; set; } = 0;
        public MedicalEquipment()
        {
            equipmentType = EquipmentType.medicalEquipment;
        }
    }
}
