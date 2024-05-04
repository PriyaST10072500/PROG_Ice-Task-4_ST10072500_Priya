using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_Ice_Task_4_ST10072500_Priya
{

    // Event Delegates
    public delegate void MotionDetectedEventHandler(object sender, MotionDetectedEventArgs e);
    public delegate void DoorOpenedEventHandler(object sender, DoorOpenedEventArgs e);
    public delegate void TemperatureChangedEventHandler(object sender, TemperatureChangedEventArgs e);


    // Event Hub
    public class EventHub
    {
        // Events
        public event MotionDetectedEventHandler MotionDetected;
        public event DoorOpenedEventHandler DoorOpened;
        public event TemperatureChangedEventHandler TemperatureChanged;


        // Event Trigger Methods
        public void TriggerMotionDetected(int sensorId)
        {
            MotionDetected?.Invoke(this, new MotionDetectedEventArgs { SensorId = sensorId, Timestamp = DateTime.Now });
        }

        public void TriggerDoorOpened(int doorId)
        {
            DoorOpened?.Invoke(this, new DoorOpenedEventArgs { DoorId = doorId, Timestamp = DateTime.Now });
        }

        public void TriggerTemperatureChanged(int thermostatId, double newTemperature)
        {
            TemperatureChanged?.Invoke(this, new TemperatureChangedEventArgs { ThermostatId = thermostatId, Timestamp = DateTime.Now, NewTemperature = newTemperature });
        }
    }
}


// References 
// https://www.bytehide.com/blog/how-to-implement-events-in-csharp
// https://www.geeksforgeeks.org/c-sharp-delegates/
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions

