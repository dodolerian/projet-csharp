namespace traffic
{
    public class Circle : Intercection
    {   
        public Car[] carInIntercection {get; set;}
        
        private int entryCounter;
        public Circle(int carIn, int carOut): base(carIn, carOut)
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
        public bool canCarGo(Car car)
        {
            if(carInIntercection[0].name =="" && carInIntercection[1].name == "")
            {
                carInIntercection[0].name=car.name;
                return true;
            }
            if(carInIntercection[0].name==""||carInIntercection[1].name=="")
            {
                if(carInIntercection[0].name!="")
                {
                    if(carInIntercection[0].exitPos>car.spawnPos||carInIntercection[0].exitPos==4&& car.spawnPos==1)
                    {
                        carInIntercection[1]=car;
                        return true;
                    }
                }
                else
                {
                    if(carInIntercection[1].exitPos>car.spawnPos||carInIntercection[1].exitPos==4&& car.spawnPos==1)
                    {
                        carInIntercection[0]=car;
                        return true;
                    }
                }
            }
            return false;
        }
    }
}