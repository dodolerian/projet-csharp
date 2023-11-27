namespace traffic
{
    public class Intercection
    {
        public Car[] carInIntercection {get; set;} = {new Car(0,0,""),new Car(0,0,"")};
        public Intercection ()
        {
        }
         public void CarLeave(string carName)
        {
            for(int i=0;i<carInIntercection.Length;i++)
            {
                if(carInIntercection[i].name==carName)
                {
                    carInIntercection[i].name="";
                    carInIntercection[i].exitPos=0;
                    carInIntercection[i].spawnPos=0;
                    Console.WriteLine($"{carName} has exit the intercection");
                }
            }
        }
        protected void CarEnter(Car car)
        {

            for(int i=0;i<carInIntercection.Length;i++)
            {
                if(carInIntercection[i].name=="")
                {
                    carInIntercection[i].name=car.name;
                    carInIntercection[i].exitPos=car.exitPos;
                    carInIntercection[i].spawnPos=car.spawnPos;
                    Console.WriteLine($"{car.name} has enter the intercection");
                }
            }
        }
        public void update()
        {
            
        }
    }
}
