namespace traffic
{
    public class Yield : Intercection
    {
        public int priorityAxe {get; private set;}=0; //1 for axe North/South, 2 for axe Est/West
        public Yield(int priorityAxe)
        {
            this.priorityAxe=priorityAxe;
        }
        public bool CanCarGo(Car car)
        {
            if(carInIntercection[0].name =="" && carInIntercection[1].name == "")
            {
                LaunchTimer(car);
                return true;
            }
            if(carInIntercection[0].name !="" && carInIntercection[1].name != "")
            {
                LaunchTimer(car);
                return true;
            }
            if(priorityAxe==1){
                if(car.spawnPos%2==1)
                {
                    if(car.spawnPos==1&&car.exitPos==3||car.spawnPos==3&&car.exitPos==1)//car don't turne
                    {
                        LaunchTimer(car);
                        return true;
                    }
                    if(car.spawnPos==1&&car.exitPos==4||car.spawnPos==3&&car.exitPos==2)//car do rigth turn 
                    {
                        return true;
                    }
                    if(car.spawnPos==1&&car.exitPos==2 || car.spawnPos==3&&car.exitPos==4)//car do left turn 
                    {
                        for(int i=0; i<carInIntercection.Length;i++)
                        {
                            if(carInIntercection[i].spawnPos!=car.spawnPos&&carInIntercection[i].exitPos==car.spawnPos)
                            {
                                return false;
                            }
                            return true;
                        }
                    }
                }
                else // car isn't on the priority axe
                {
                    if(car.spawnPos%2==0 || car.spawnPos==car.exitPos+1||car.spawnPos==4&&car.exitPos==1){//car don't turn or turn left
                        if(carInIntercection[0].name==""&&carInIntercection[1].name=="") 
                        {
                            return true;
                        }
                        return false;
                    }
                   
                    if(car.exitPos==car.spawnPos-1) // car do right turn
                    {
                        for(int i=0; i<carInIntercection.Length;i++)
                        {
                            if(carInIntercection[i].exitPos==car.exitPos)
                            {
                                return false;
                            }
                            return true;
                        }
                    }

                    return false;
                }
               
            }
            else
            {
                if(car.spawnPos%2==0) //car is on the principal axe
                {
                    if(car.spawnPos==2&&car.exitPos==4||car.spawnPos==4&&car.exitPos==2)//don't turn 
                    {
                        LaunchTimer(car);
                        return true;
                    }
                    if(car.spawnPos==2&&car.exitPos==1||car.spawnPos==4&&car.exitPos==3)//car turn rigth
                    {
                        return true;
                    }
                    if(car.spawnPos==2&&car.exitPos==3 || car.spawnPos==4&&car.exitPos==1)//car do left turn 
                    {
                        for(int i=0; i<carInIntercection.Length;i++)
                        {
                            if(carInIntercection[i].spawnPos!=car.spawnPos&&carInIntercection[i].exitPos==car.spawnPos)
                            {
                                return false;
                            }
                            return false;
                        }   
                    }
                }
                else//car isn't on the priority axe 
                {
                    if(car.exitPos==car.spawnPos-1) //car do rigth turn
                    {
                        for(int i=0; i<carInIntercection.Length;i++)
                        {
                            if(carInIntercection[i].exitPos==car.exitPos)
                            {
                                return false;
                            }
                            return true;
                        }
                    }
                    if(car.spawnPos%2==1 || car.spawnPos==car.exitPos+1){//car don't turn or turn left
                        if(carInIntercection[0].name==""&&carInIntercection[1].name=="") 
                        {
                            return true;
                        }
                        return false;
                    }
                }
                
            }
            return false;
        }
    }
}