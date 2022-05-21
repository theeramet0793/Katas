using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumMedicalType;

namespace PubgMobile.Equipments.MedicalEquipments
{
    public class EnergyDrink : MedicalEquipment
    {
        public EnergyDrink()
        {
            medicalType = MedicalType.EnergyDrink;
            weight = 2;
            healEnergy = 30;
        }
    }
}
