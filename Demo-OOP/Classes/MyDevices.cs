using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_OOP.Interfaces;

namespace Demo_OOP.Classes;

public class MyDevices : IMyDevices
{
    [Required]
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public OperatingSystem OperativeSystem { get; set; } = null!;
    public Brand Brand { get; set; }
    public string Model { get; set; } = null!;
    public DeviceType DeviceType { get; set; }
    public int YearOfPurchase { get; set; }
    public int MyProperty { get; set; }
    public double PriceEstimate { get; set; }
}

public enum OperativeSystem
{
    Windows,
    Android,
    MacOS,
    IOS,
    Linux
}

public enum Brand
{
    Sony,
    Iphone,
    Macbook,
    Lenovo,
    IBM,
    LG,
    Samsung,
    Huawei,
    Innova,
}

public enum DeviceType
{
    Computer,
    Phone,
    TV,
    Keyboard,
    Headphones,
}
