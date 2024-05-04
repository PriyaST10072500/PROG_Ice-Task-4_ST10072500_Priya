using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_Ice_Task_4_ST10072500_Priya
{

    // Event Arguement Class TemperatureChanged
    public class TemperatureChangedEventArgs : EventArgs
    {
        public int ThermostatId { get; set; }
        public DateTime Timestamp { get; set; }
        public double NewTemperature { get; set; }
    }


    // Thermostat Class
    public class Thermostat
    {
        private readonly int _thermostatId;
        private double _currentTemperature;

        public Thermostat(int thermostatId, double initialTemperature)
        {
            _thermostatId = thermostatId;
            _currentTemperature = initialTemperature;
        }

        public void UpdateTemperature(EventHub eventHub, double newTemperature)
        {
            Console.WriteLine($"Temperature changed for thermostat {_thermostatId}: {_currentTemperature} -> {newTemperature}");
            _currentTemperature = newTemperature;
            eventHub.TriggerTemperatureChanged(_thermostatId, newTemperature);
        }
    }

}


// References 
// https://www.bytehide.com/blog/how-to-implement-events-in-csharp
// https://www.geeksforgeeks.org/c-sharp-delegates/
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions

