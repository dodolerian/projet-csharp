using System;
namespace traffic
{
    public class lightIntersection
    {
        public int spawnPos;
        public lightIntersection(int exitPos)
        {
            this.spawnPos = exitPos;
        }
        public int carIntersection(int exitPos, TrafficLightColor currentColor)
        {
            TrafficLightController controler = new TrafficLightController();
            while (currentColor != TrafficLightColor.Green)
            {
                currentColor = controler.NextTrafficLightColor(currentColor);
            }
            return exitPos;
        }
    } 
}