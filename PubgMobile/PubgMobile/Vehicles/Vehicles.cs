using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubgMobile.Enum.EnumVehicleType;

namespace PubgMobile.Vehicle
{
    public abstract class Vehicles
    {
        public VehicleType vehicleType { get; set; }
        public int speed { get; set; }
        public int strength { get; set; }
    }
}
