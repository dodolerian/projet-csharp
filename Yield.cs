namespace traffic
{
    public class Yield : Intercection
    {
        public int priorityAxe {get; private set;} // 1 for axe Noth South 2 for Est West
        public Yield(int carIn, int carOut, int priorityAxe):base(carIn, carOut)
        {
            this.priorityAxe=priorityAxe;
        }
        // public bool canCarGo()    WIP
        // {
        //     return 
        // }
    }
}