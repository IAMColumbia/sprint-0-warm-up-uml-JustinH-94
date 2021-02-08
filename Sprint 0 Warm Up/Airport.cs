using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    class Airport
    {
        int MaxVehicles;
        List<AerialVehicle> aerialVehicles = new List<AerialVehicle>();

        public string AirportCode { get; set; }

        public Airport(string Code)
        {
            AirportCode = Code;
        }

        public Airport(string Code, int maxVehicles)
        {
            AirportCode = Code;
            MaxVehicles = maxVehicles;
        }

        public string AllTakeOff()
        {
            foreach(AerialVehicle a in aerialVehicles)
            {
                a.isFlying = true;
                a.isFlying = true;
                a.FlyUp();
                aerialVehicles.Remove(a);
                MaxVehicles--;
            }
            return $"All Aerial Vehicles are taking off.";
        }

        public string Land(AerialVehicle a)
        {
            a.FlyDown(a.CurrentAltitude);
            a.isFlying = false;
            aerialVehicles.Add(a);
            MaxVehicles++;
            return $"{a} is landing at the airport.";
        }

        public string Land(List<AerialVehicle> landing)
        {
            return $"{landing} is about to land at the airport.";
        }

        public string TakeOff(AerialVehicle a)
        {
            a.isFlying = true;
            a.FlyUp();
            aerialVehicles.Remove(a);
            MaxVehicles--;
            return $"{a} is taking off.";
        }
    }
}
