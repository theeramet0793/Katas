using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumMedicalType;

namespace PubgMobile.Equipments.MedicalEquipments
{
    public class MedKit : MedicalEquipment
    {
        public MedKit()
        {
            medicalType = MedicalType.MedKit;
            weight = 5;
            healHP = 100;
        }
    }
}
