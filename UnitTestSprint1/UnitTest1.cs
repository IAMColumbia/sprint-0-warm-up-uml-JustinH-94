using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint_0_Warm_Up;
namespace UnitTestSprint1
{
    [TestClass]
    public class UnitTest1
    {
        AerialVehicle av;
        public void TestMethod1()
        {
            av = new AerialVehicle();
        }

        [TestMethod]
        public void SprintAerialVehicleAbout()
        {
            string avAbout = string.Empty;
            string defaultPlaneType = "OOPFlyingVehicle.Airplane";
            int defaultCurrentAlt = 0;
            int defaultMaxAlt = 41000;
            avAbout = av.About();

            Assert.AreEqual("Output AirplaneAbout:\n" +
                 $"This {defaultPlaneType} has a max altitude of {defaultMaxAlt} ft.\n" +
                 $"It's current altitude is {defaultCurrentAlt} ft.\n" +
                 $"{defaultPlaneType} engine is started\n", avAbout);
        }
    }
}
