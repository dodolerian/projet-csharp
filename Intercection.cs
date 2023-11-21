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
                }
            }
        }
        protected void CarEnter(int index, Car car)
        {
            carInIntercection[index].name=car.name;
            carInIntercection[index].exitPos=car.exitPos;
            carInIntercection[index].spawnPos=car.spawnPos;
        }
    }
}
