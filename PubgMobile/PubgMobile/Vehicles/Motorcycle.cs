using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumVehicleType;

namespace PubgMobile.Vehicle
{
    public class Motorcycle : Vehicles
    {
        public Motorcycle()
        {
            vehicleType = VehicleType.motorcycle;
            speed = 140;
            strength = 50;
        }
    }
}
