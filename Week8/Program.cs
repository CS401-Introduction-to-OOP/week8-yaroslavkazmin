namespace Week8;
class Program
{
    static void Main()
    {
        var Letter1 = new Letter("1", 0.01);
        var Letter2 = new Letter("2", 0.02);
        var Parcel1 = new Parcel("3", 10);
        var Parcel2 = new Parcel("4", 20);
        
        Console.WriteLine(Letter1);
        Console.WriteLine(Parcel1);
        CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
        myCargo.AddItem(Letter1);
        myCargo.AddItem(Letter2);
        myCargo.AddItem(Parcel1);
        myCargo.AddItem(Parcel2);
        Console.WriteLine(myCargo.GetTotalCost());
    }
}