using System;
namespace traffic
{
    public class TrafficLightController
    {
        public string? currentColor{get;set;}
        public TrafficLightColor NextTrafficLightColor(TrafficLightColor currentColor)
        {
            switch (currentColor)
            {
                case TrafficLightColor.Green:
                    Thread.Sleep(1000);
                    return TrafficLightColor.Orange;
                case TrafficLightColor.Orange:
                    Thread.Sleep(1000);
                    return TrafficLightColor.Red;
                case TrafficLightColor.Red:
                    Thread.Sleep(1000);
                    return TrafficLightColor.Green;
                case TrafficLightColor.None:
                default:
                    return TrafficLightColor.None;
            }
        }
    }
}
