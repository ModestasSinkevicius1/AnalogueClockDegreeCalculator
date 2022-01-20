using System;

namespace AnalogueClockDegreeCalculator
{
    class Program
    {       
        static void Main(string[] args)
        {
            string startHour = "0";
            string endHour = "0";
            
            string startMin = "0";
            string endMin = "0";

            Console.WriteLine("Type start of hour");
            startHour = Console.ReadLine();

            Console.WriteLine("Type end of hour");
            endHour = Console.ReadLine();

            Console.WriteLine("Type start of min");
            startMin = Console.ReadLine();

            Console.WriteLine("Type end of min");
            endMin = Console.ReadLine();

            ClockAnalogueDegreeSolver cads = new ClockAnalogueDegreeSolver(Convert.ToInt32(startHour),
                Convert.ToInt32(endHour), Convert.ToInt32(startMin), Convert.ToInt32(endMin));

            Console.WriteLine($"Hour between {startHour} and {endHour} is {cads.CalculateHourAngle()}°");
            
            Console.WriteLine($"Min between {startMin} and {endMin} is {cads.CalculateMinAngle()}°");
        }
    }
}
