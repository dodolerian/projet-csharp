using traffic;
namespace program
{
  class Program
  {
    static void Main(string[] str){
      Yield Yeild1 = new Yield(0);
      Car myCar1 = Car.Spawn("car1");
      Car myCar2 = Car.Spawn("car2");
      Console.WriteLine(myCar1.spawnPos);
      Console.WriteLine(myCar1.exitPos);
      Console.WriteLine(myCar2.spawnPos);
      Console.WriteLine(myCar2.exitPos);


      Console.WriteLine(Yeild1.CanCarGo(myCar1));
      Console.WriteLine(Yeild1.CanCarGo(myCar2));

    }
  }
}