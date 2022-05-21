using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumVehicleType;

namespace PubgMobile.Vehicle
{
    public class Pickup : Vehicles
    {
        public Pickup()
        {
            vehicleType = VehicleType.pickup;
            speed = 160;
            strength = 180;
        }
    }
}
