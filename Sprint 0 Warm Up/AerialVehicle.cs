using System;

namespace Sprint_0_Warm_Up
{
    public abstract class AerialVehicle
    {
        public int CurrentAltitude { get; set; }
        public bool isFlying { get; set; }
        public int MaxAltitude { get; set; }
        public string PlaneType { get; set; }
        public Engine Engine { get; set; }

        public AerialVehicle()
        {
            Engine = new Engine();
            CurrentAltitude = 0;
            isFlying = false;
        }

        public virtual string About()
        {
            if (Engine.isStarted)
            {
                return "Output AirplaneAbout:\n" +
                 $"This {PlaneType} has a max altitude of {MaxAltitude} ft.\n" +
                 $"It's current altitude is {CurrentAltitude} ft.\n" +
                 $"{PlaneType} engine is started\n";
            }
            return "Output AirplaneAbout:\n" +
                 $"This OOPFlyingVehicle.Airplane has a max altitude of {MaxAltitude} ft.\n" +
                 $"It's current altitude is {CurrentAltitude} ft.\n" +
                 $"{PlaneType} engine is not started\n";
        }



        public virtual void StartEngine()
        {
            Engine.Start();
        }

        public void StopEngine()
        {
            Engine.Stop();
        }

        public void FlyDown()
        {
            if (CurrentAltitude >= 1000)
                CurrentAltitude -= 1000;
        }

        public void FlyDown(int howMuch)
        {
            if (howMuch > CurrentAltitude)
                return;
            else
                CurrentAltitude -= howMuch;
        }

        internal void FlyUp()
        {
            if(CurrentAltitude <= MaxAltitude-1000)
                CurrentAltitude += 1000;
        }

        internal void FlyUp(int HowMuch)
        {
            if (HowMuch > MaxAltitude)
                CurrentAltitude = MaxAltitude;
            else
                CurrentAltitude = HowMuch;
        }        

        public void getEngineStartedString()
        {

        }
        
        public virtual string TakeOff()
        {
            if (Engine.isStarted)
                return $"{PlaneType} is flying";
            return $"{PlaneType} can't fly it's engine is not started.";
        }
    }
}