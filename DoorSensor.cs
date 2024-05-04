using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_Ice_Task_4_ST10072500_Priya
{

    // Event Arguement Class DoorOpened
    public class DoorOpenedEventArgs : EventArgs
    {
        public int DoorId { get; set; }
        public DateTime Timestamp { get; set; }
    }


    // Door Sensor Class
    public class DoorSensor
    {
        private readonly int _doorId;

        public DoorSensor(int doorId)
        {
            _doorId = doorId;
        }


        public void DetectDoorOpen(EventHub eventHub)
        {
            Console.WriteLine($"Door {_doorId} opened");
            eventHub.TriggerDoorOpened(_doorId);
        }
    }
}


// References 
// https://www.bytehide.com/blog/how-to-implement-events-in-csharp
// https://www.geeksforgeeks.org/c-sharp-delegates/
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions

