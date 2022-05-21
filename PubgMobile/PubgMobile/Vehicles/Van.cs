using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumVehicleType;

namespace PubgMobile.Vehicle
{
    public class Van : Vehicles
    {
        public Van()
        {
            vehicleType = VehicleType.van;
            speed = 80;
            strength = 140;
        }
    }
}
