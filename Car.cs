namespace traffic
{
  public class Car
  {
    public string name = "";
    public int spawnPos;
    public int exitPos;
    public bool isInIntercection =false;
    public static Car Spawn(string name)
    {
      var random=new Random();
     
      List<int>notsame=new List<int>()
      {
        1,2,3,4
      };
      
      int spawnPos = notsame[random.Next(0,notsame.Count)];
      notsame.Remove(spawnPos);
      int exitPos = notsame[random.Next(0,notsame.Count)];
      notsame.Remove(exitPos);

      Console.WriteLine($"{name} car has spawn with enter pos {spawnPos} and exit pos {exitPos}");
      return new Car(spawnPos, exitPos, name);
    }
    public Car(int spawnPos, int exitPos, string name)
    {
      this.spawnPos = spawnPos;
      this.exitPos = exitPos;
      this.name= name;
      
    }
    public Car(Car myCarCopie){
      this.spawnPos = myCarCopie.spawnPos;
      this.exitPos = myCarCopie.exitPos;
    }

  }
}


