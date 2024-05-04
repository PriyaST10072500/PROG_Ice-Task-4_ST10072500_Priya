using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_Ice_Task_4_ST10072500_Priya
{

    // Event Arguement Class MotionDetected
    public class MotionDetectedEventArgs : EventArgs
    {
        public int SensorId { get; set; }
        public DateTime Timestamp { get; set; }
    }


    // Motion Sensor Class
    public class MotionSensor
    {
        private readonly int _sensorId;

        public MotionSensor(int sensorId)
        {
            _sensorId = sensorId;
        }


        public void DetectMotion(EventHub eventHub)
        {
            Console.WriteLine($"Motion detected by sensor {_sensorId}");
            eventHub.TriggerMotionDetected(_sensorId);
        }
    }
}


// References 
// https://www.bytehide.com/blog/how-to-implement-events-in-csharp
// https://www.geeksforgeeks.org/c-sharp-delegates/
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions

