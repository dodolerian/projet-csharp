// TrafficLightController.cs

using traffic;

public class TrafficLightController
{
    public TrafficLightColor NextTrafficLightColor(TrafficLightColor currentColor)
    {
        switch (currentColor)
        {
            case TrafficLightColor.Green:
                return TrafficLightColor.Orange;
            case TrafficLightColor.Orange:
                return TrafficLightColor.Red;
            case TrafficLightColor.Red:
                return TrafficLightColor.Green;
            case TrafficLightColor.None:
            default:
                return TrafficLightColor.None;
        }
    }
}
