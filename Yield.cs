namespace traffic
{
    public class Yield : Intercection
    {
        public int priorityAxe; // 1 for axe Noth South 2 for Est West
        public Yield(int carIn, int carOut, int priorityAxe):base(carIn, carOut)
        {
            this.priorityAxe=priorityAxe;
        }
    }
}