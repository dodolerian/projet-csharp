namespace traffic
{
    public class Traffic
    {
        public static void Simulation()
        {
            Car car1 = Car.Spawn("peugeot 206");
            Car car2 = Car.Spawn("renault clio I");
            Car car3 = Car.Spawn("toyota verso s");
            Circle circle1 = new Circle();
            Yield yield1 = new Yield(1);
            TrafficLightController controler = new TrafficLightController();
            lightIntersection mycar1 = new lightIntersection(car1.spawnPos);
            lightIntersection mycar2 = new lightIntersection(car2.spawnPos);
            lightIntersection mycar3 = new lightIntersection(car3.spawnPos);
            
            if(circle1.CanCarGo(car1))
            {
                Console.WriteLine($"{car1.name} has enter in circle 1");
            }
            circle1.update();
            if(circle1.CanCarGo(car2))
            {
                Console.WriteLine($"{car2.name} has enter in circle 1");
            }
            if(circle1.CanCarGo(car3))
            {
                Console.WriteLine($"{car3.name} has enter in circle 1");
            }
            // int result1 = mycar1.carIntersection(car1.exitPos,TrafficLightColor.Orange);
            // Console.WriteLine($"{car1.name} has passed the taffix light");
            // int result2 = mycar2.carIntersection(car2.exitPos,TrafficLightColor.Red);
            // Console.WriteLine($"{car2.name} has passed the taffix light");
            // int result3 = mycar3.carIntersection(car3.exitPos,TrafficLightColor.Green);
            // Console.WriteLine($"{car3.name} has passed the taffix light");

        }
    }
}