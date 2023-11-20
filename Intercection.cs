namespace traffic
{
    public class Intercection
    {
        public int carIn; 
        public int carOut; // 1 North, 2 Est, 3 South, 4 West
    
        public bool isCarIn=false;
        public Intercection (int carIn, int carOut)
        {
            this.carIn=carIn;
            this.carOut=carOut;
        }
    }
}
