using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint_0_Warm_Up;
namespace UnitTestSprint1._0
{
    [TestClass]
    public class UnitTest1
    {
        Airplane ap;
        ToyPlane tp;
        Engine e;
        Helicopter h;
        Drone d;
        public void TestMethod1()
        {
            
        }

        [TestMethod]
        public void SprintAirPlaneAbout()
        {
            ap = new Airplane();
            string planeType = string.Empty;
            string airplaneAbout = string.Empty;
            string takeOff = string.Empty;
            int maxAlt = 41000;
            int currentAlt = 0;
            planeType = "OOPFlyingVehicle.Airplane";
            airplaneAbout =
                "Output AirplaneAbout:\n" + $"This {planeType} has a max altitude of {maxAlt} ft.\n" +
                 $"It's current altitude is {currentAlt} ft.\n" +
                 $"{planeType} engine is not started\n";
            takeOff = $"{planeType} can't fly it's engine is not started.";


            Assert.IsNotNull(ap);
            Assert.AreEqual(ap.MaxAltitude, maxAlt);
            Assert.AreEqual(ap.CurrentAltitude, currentAlt);
            Assert.AreEqual(ap.PlaneType, planeType);
            Assert.AreEqual(ap.About(), airplaneAbout);
            Assert.AreEqual(ap.TakeOff(), takeOff);
        }

        [TestMethod]
        public void SprintToyPlaneAbout()
        {
            tp = new ToyPlane();

            string planeType = "OOPFlyingVehicle.ToyPlane";
            string tpAbout = string.Empty;
            string takeOff = string.Empty;
            int maxAlt = 50;

            tpAbout = "Output AirplaneAbout:\n" +
                 $"This {planeType} has a max altitude of {maxAlt} ft.\n" +
                 $"It's current altitude is 0 ft.\n" +
                 $"{planeType} engine is not started\n";
            takeOff = $"{planeType} can't fly it's engine is not started.";

            Assert.IsNotNull(tp);
            Assert.AreEqual(tp.MaxAltitude, maxAlt);
            Assert.AreEqual(tp.PlaneType, planeType);
            Assert.AreEqual(tp.TakeOff(), takeOff);
            Assert.AreEqual(tp.About(), tpAbout);
        }

        [TestMethod]
        public void SprintEngineAbout()
        {
            e = new Engine();

            string engineAbout = string.Empty;
            bool isStarted = false;

            engineAbout = "Engine has not started.";

            Assert.IsNotNull(e);
            Assert.AreEqual(e.About(), engineAbout);
            Assert.AreEqual(e.isStarted, isStarted);
        }

        [TestMethod]
        public void HelicopterAbout()
        {
            h = new Helicopter();

            int maxAlt = 8000;

            Assert.IsNotNull(h);
            Assert.AreEqual(h.MaxAltitude, maxAlt);
        }

        [TestMethod]
        public void DroneAbout()
        {
            d = new Drone();

            int maxAlt = 500;

            Assert.IsNotNull(d);
            Assert.AreEqual(d.MaxAltitude, maxAlt);
        }
    }
}
