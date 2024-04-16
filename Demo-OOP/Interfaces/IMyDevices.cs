namespace Demo_OOP.Interfaces
{
    public interface IMyDevices
    {
        int Id { get; set; }
        string Name { get; set; }
        OperatingSystem OperativeSystem { get; set; }
        double PriceEstimate { get; set; }
        int YearOfPurchase { get; set; }
    }
}