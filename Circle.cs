namespace traffic
{
    public class Circle :Intercection
    {   
       
        public Circle()
        {
        }
        public bool CanCarGo(Car car)
        {
            if(carInIntercection[0].name =="" && carInIntercection[1].name == "")
            {
                CarEnter(car);
                return true;
            }
            if(carInIntercection[0].name==""||carInIntercection[1].name=="")
            {
                if(carInIntercection[0].name!="")
                {
                    if(carInIntercection[0].exitPos<car.spawnPos||carInIntercection[0].exitPos==1&& car.spawnPos==4)
                    {
                        CarEnter(car);
                        return true;
                    }
                }
                else
                {
                    if(carInIntercection[1].exitPos>car.spawnPos||carInIntercection[1].exitPos==4&& car.spawnPos==1)
                    {
                        CarEnter(car);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}