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
            // TrafficLightController controler = new TrafficLightController();
            // lightIntersection mycar1 = new lightIntersection(car1.spawnPos);
            // lightIntersection mycar2 = new lightIntersection(car2.spawnPos);
            // lightIntersection mycar3 = new lightIntersection(car3.spawnPos);
            
            if(!circle1.CanCarGo(car1))
            {
                Console.WriteLine("car is waiting to enter");
            }
            if(car1.isInIntercection){
                 if(!circle1.CanCarGo(car1))
                {
                    Console.WriteLine($"{car1.name} is waiting to enter");
                }
            }
            if(!circle1.CanCarGo(car2))
            {
                Console.WriteLine($"{car2.name} is waiting to enter");
            }
            if(car1.isInIntercection){
                if(!circle1.CanCarGo(car1))
                {
                    Console.WriteLine($"{car1.name}is waiting to enter");
                }

            }
            if(car2.isInIntercection){
                if(!circle1.CanCarGo(car2))
                {
                    Console.WriteLine($"{car2.name}is waiting to enter");
                }
            }
            circle1.CarLeave(car1.name);
            if(!circle1.CanCarGo(car3))
            {
                Console.WriteLine($"{car3.name} waiting to enter");
            }
            while(car1.ispassed && car2.ispassed && car3.ispassed){
                if(car1.isInIntercection){
                    if(!circle1.CanCarGo(car1))
                    {
                        Console.WriteLine($"{car1.name}is waiting to enter");
                    }
                }else{
                    circle1.CarLeave(car1.name);
                }
                if(car2.isInIntercection){
                    if(!circle1.CanCarGo(car2))
                    {
                        Console.WriteLine($"{car2.name}is waiting to enter");
                    }
                }else{
                    circle1.CarLeave(car2.name);
                }
                if(car3.isInIntercection){
                    if(!circle1.CanCarGo(car3))
                    {
                        Console.WriteLine($"{car3.name}is waiting to enter");
                    }
                }else{
                    circle1.CarLeave(car3.name);
                }
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