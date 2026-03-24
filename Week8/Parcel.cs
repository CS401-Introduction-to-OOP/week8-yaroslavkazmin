namespace Week8;

public class Parcel : DeliveryItem
{
    public Parcel(string trackingNumber, double weight) : base(trackingNumber, weight)
    {}
    public string Diamentions = "30x20x15";

    public override double CalculateCost()
    {
        double Cost = 50 + Weight * 25;
        return Cost;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine(Diamentions);
    }
}