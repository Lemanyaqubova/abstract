using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
   abstract class Vehicle
    {
        public float DriveTime { get; set; }
        public float DrivePath { get; set; }

        public abstract float AverageSpeed();

    }
    interface IEngine
    {
        public float HorsePower { get; set; }
        public float TankSize { get; set; }
        public float CurrentOil { get; set; }
        public float FuelType { get; set; }
        public abstract float RemainOilAmount();
    } 
    interface IWheel
    {
        public float WheelThickness { get; set; }
    }
    interface ITransmission
    {
        public float TransmissionKind { get; set; }
    }

}
