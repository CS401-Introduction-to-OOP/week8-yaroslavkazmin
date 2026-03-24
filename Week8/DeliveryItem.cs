namespace Week8;
using System;

public abstract class DeliveryItem
{
    public string TrackingNumber { get; }
    protected double Weight { get; }
    public double Cost { get; }
    public DeliveryItem(string trackingNumber, double weight)
    {
        TrackingNumber = trackingNumber;
        Weight = weight;
    }

    public abstract double CalculateCost();

    public virtual void PrintInfo()
    {
        Console.WriteLine(TrackingNumber);
        Console.WriteLine(Weight);
        Console.WriteLine(Cost);
    }
}