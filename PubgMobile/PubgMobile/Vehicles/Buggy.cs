using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumVehicleType;

namespace PubgMobile.Vehicle
{
    public class Buggy: Vehicles
    {
        public Buggy()
        {
            vehicleType = VehicleType.buggy;
            speed = 100;
            strength = 150;
        }
    }
}
