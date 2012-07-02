using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealWorldDemo
{
    /// <summary>
    /// The 'VehicelBuilder' abstract class
    /// </summary>
    public abstract class VehicleBuilder
    {
        protected Vehicle vehicle;

        // Get vehicle instance
        public Vehicle Vehicle
        {
            get
            {
                return vehicle;
            }
        }

        // Abstract build methods
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
