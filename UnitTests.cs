using PROG_Ice_Task_4_ST10072500_Priya;

namespace Smart_Home_Event_Handling_System_UnitTests
{
    [TestClass]
    public class UnitTests
        {
        private EventHub eventHub;


        //Test Method for SetUp
        [TestMethod]
        public void Setup()
        {
            eventHub = new EventHub();
        }


        //Test Method for Thermostat
        [TestMethod]
        public void TestMethod2()
        {
            int thermostatId = 1;
            double initialTemperature = 20.0;
            double newTemperature = 25.0;

            var eventHub = new EventHub();

            var thermostat = new Thermostat(thermostatId, initialTemperature);

            eventHub.TemperatureChanged += (sender, args) =>
            {
                Assert.AreEqual(thermostatId, args.ThermostatId);
                Assert.AreEqual(newTemperature, args.NewTemperature);
            };
            
            thermostat.UpdateTemperature(eventHub, newTemperature);
        }
        
    }
}
