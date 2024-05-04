namespace PROG_Ice_Task_4_ST10072500_Priya
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable event hub
            var eventHub = new EventHub();


            // Declared Variables 
            var motionSensor = new MotionSensor(1);
            var doorSensor = new DoorSensor(1);
            var thermostat = new Thermostat(1, 20.0);


            // Event handling setup
            eventHub.MotionDetected += (sender, args) =>
            {
                Console.WriteLine($"Motion detected at sensor {args.SensorId} at {args.Timestamp}");
                
            };

            eventHub.DoorOpened += (sender, args) =>
            {
                Console.WriteLine($"Door {args.DoorId} opened at {args.Timestamp}");
                
            };

            eventHub.TemperatureChanged += (sender, args) =>
            {
                Console.WriteLine($"Temperature changed for thermostat {args.ThermostatId} at {args.Timestamp}. New temperature: {args.NewTemperature}");
                
            };

            
            motionSensor.DetectMotion(eventHub);
            doorSensor.DetectDoorOpen(eventHub);
            thermostat.UpdateTemperature(eventHub, 22.5);

            
            Console.ReadLine();
        }
    }
    
}


// References 
// https://www.bytehide.com/blog/how-to-implement-events-in-csharp
// https://www.geeksforgeeks.org/c-sharp-delegates/
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions

