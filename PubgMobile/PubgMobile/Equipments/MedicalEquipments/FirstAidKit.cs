using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumMedicalType;

namespace PubgMobile.Equipments.MedicalEquipments
{
    public class FirstAidKit : MedicalEquipment
    {
        public FirstAidKit()
        {
            medicalType = MedicalType.FirstAidKit;
            weight = 4;
            healHP = 70;
        }
    }
}
