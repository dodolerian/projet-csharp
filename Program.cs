using System;
using traffic;

namespace TestCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar1 = Car.Spawn();
            TrafficLightController controler = new TrafficLightController();
            lightIntersection myCar1A = new lightIntersection(myCar1.spawnPos);
            

            Console.WriteLine($"My car spawnPos : {myCar1.spawnPos} and exitPos : {myCar1.exitPos}");  
            Console.WriteLine(controler.NextTrafficLightColor(TrafficLightColor.Orange));
 
            int result = myCar1A.carIntersection(myCar1.exitPos, TrafficLightColor.Orange);
            Console.WriteLine($"CarIntersection result: {result}");
        }
    }
}