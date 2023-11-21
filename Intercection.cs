namespace traffic
{
    public class Intercection
    {
        public int carIn {get; private set;} 
        public int carOut {get; private set;}  // 1 North, 2 Est, 3 South, 4 West
    
        public bool isCarIn {get; set;} = false;
        public Intercection (int carIn, int carOut)
        {
            this.carIn=carIn;
            this.carOut=carOut;
        }
    }
}
