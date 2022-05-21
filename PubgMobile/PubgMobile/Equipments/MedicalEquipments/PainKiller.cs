using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumMedicalType;

namespace PubgMobile.Equipments.MedicalEquipments
{
    public class PainKiller: MedicalEquipment
    {
        public PainKiller()
        {
            medicalType = MedicalType.PainKiller;
            weight = 3;
            healEnergy = 50;
        }
    }
}
