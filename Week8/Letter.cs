namespace Week8;

public class Letter : DeliveryItem
{
    public Letter(string trackingNumber, double weight) : base(trackingNumber, weight)
    {}

    public override double CalculateCost()
    {
        double Cost = 15 + Weight * 10;
        return Cost;
    }
}