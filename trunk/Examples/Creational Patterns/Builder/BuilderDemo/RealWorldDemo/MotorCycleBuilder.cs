using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealWorldDemo
{
    /// <summary>
    /// The 'MotorCycleBuilder' class
    /// </summary>
    public class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder()
        {
            vehicle = new Vehicle("MotoCycle");
        }

        public override void BuildFrame()
        {
            vehicle["frame"] = "MotoCycle Frame";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "500 cc";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "2";
        }

        public override void BuildDoors()
        {
            vehicle["doors"] = "0";
        }
    }
}
