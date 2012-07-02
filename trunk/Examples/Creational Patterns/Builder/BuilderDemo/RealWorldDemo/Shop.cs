using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealWorldDemo
{
    /// <summary>
    /// The 'Shop' class
    /// </summary>
    public class Shop
    {
        // Builder uses a complex series of steps
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }
}
