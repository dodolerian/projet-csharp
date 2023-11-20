namespace traffic
{
  public class Car
  {
    public int spawnPos;
    public int exitPos;
    public static Car Spawn()
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

      return new Car(spawnPos, exitPos);
    }
    public Car(int spawnPos, int exitPos)
    {
      this.spawnPos = spawnPos;
      this.exitPos = exitPos;
    }
    public Car(Car myCarCopie){
      this.spawnPos = myCarCopie.spawnPos;
      this.exitPos = myCarCopie.exitPos;
    }

  }
}


