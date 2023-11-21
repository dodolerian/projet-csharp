using traffic;
namespace program
{
    class Program
  {
    static void Main(string[] args)
    {
      Car myCar1 = Car.Spawn();
      Car myCar2 = Car.Spawn();
      Car myCar3 = Car.Spawn();
      Car myCar4 = Car.Spawn();
      Car myCar5 = new Car(myCar1);

      Console.WriteLine($"My car spawnPos : {myCar1.spawnPos} and exitPos : {myCar1.exitPos}");
      Console.WriteLine($"My car spawnPos : {myCar2.spawnPos} and exitPos : {myCar2.exitPos}");
      Console.WriteLine($"My car spawnPos : {myCar3.spawnPos} and exitPos : {myCar3.exitPos}");
      Console.WriteLine($"My car spawnPos : {myCar4.spawnPos} and exitPos : {myCar4.exitPos}");
      Console.WriteLine($"My car5 spawnPos : {myCar5.spawnPos} and exitPos : {myCar5.exitPos}");
    }
  }
}