using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumVehicleType;

namespace PubgMobile.Vehicle
{
    public class Darcia : Vehicles
    {
        public Darcia()
        {
            vehicleType = VehicleType.darcia;
            speed = 120;
            strength = 190;
        }
    }
}
