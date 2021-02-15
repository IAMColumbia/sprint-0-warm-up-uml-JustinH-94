using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    public class ToyPlane : Airplane
    {
        bool isWoundUp;

        public ToyPlane()
        {
            UnWind();
            MaxAltitude = 50;
            PlaneType = "OOPFlyingVehicle.ToyPlane";
        }

        public new string About()
        {
            if (Engine.isStarted)
            {
                return "Output AirplaneAbout:\n" +
                 $"This {PlaneType} has a max altitude of {MaxAltitude} ft.\n" +
                 $"It's current altitude is {CurrentAltitude} ft.\n" +
                 $"{PlaneType} engine is started\n";
            }
            return "Output AirplaneAbout:\n" +
                 $"This {PlaneType} has a max altitude of {MaxAltitude} ft.\n" +
                 $"It's current altitude is {CurrentAltitude} ft.\n" +
                 $"{PlaneType} engine is not started\n";
        }

        public string getWindUpString()
        {
            return "";
        }

        public override void StartEngine()
        {
            if (isWoundUp)
                Engine.Start();

        }

        public override string TakeOff()
        {
            if (Engine.isStarted)
                return $"{PlaneType} is flying";
            return $"{PlaneType} can't fly it's engine is not started.";
        }

        public void UnWind()
        {
            isWoundUp = false;
        }

        public void WindIP()
        {
            isWoundUp = true;
        }
    }
}
