namespace traffic
{
    public class Circle
    {   
        public Car[] carInIntercection {get; set;} = {new Car(0,0,""),new Car(0,0,"")};
        
        private int entryCounter;
        public Circle()
        {
        }
        public void carLeave(string carName)
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
        private void carEnter(int index, Car car)
        {
            carInIntercection[index].name=car.name;
            carInIntercection[index].exitPos=car.exitPos;
            carInIntercection[index].spawnPos=car.spawnPos;
        }
        public bool canCarGo(Car car)
        {
            if(carInIntercection[0].name =="" && carInIntercection[1].name == "")
            {
                carEnter(0,car);
                return true;
            }
            if(carInIntercection[0].name==""||carInIntercection[1].name=="")
            {
                if(carInIntercection[0].name!="")
                {
                    if(carInIntercection[0].exitPos<car.spawnPos||carInIntercection[0].exitPos==1&& car.spawnPos==4)
                    {
                        carEnter(1,car);
                        return true;
                    }
                }
                else
                {
                    if(carInIntercection[1].exitPos>car.spawnPos||carInIntercection[1].exitPos==4&& car.spawnPos==1)
                    {
                        carEnter(0,car);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}