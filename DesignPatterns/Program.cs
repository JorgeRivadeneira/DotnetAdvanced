using DesignPatterns.Factory;
using DesignPatterns.Models;
using DesignPatterns.RepositoryPattern;
using DesignPatterns.Singleton;
using DesignPatterns.StrategyPattern;
using DesignPatterns.UnitOfWorkPattern;
using Microsoft.EntityFrameworkCore;

/* Singleton */
//var log = Log.Instance;
//log.Save("a");
//log.Save("b");

//var a = Singleton.Instance;
//var b = Singleton.Instance;

//Console.WriteLine(a == b);


///  Factory Pattern
//SaleFactory storeSaleFactory = new StoreSaleFactory(10);
//SaleFactory internetSaleFactory = new InternetSaleFactory(2);

//ISale sale1 = storeSaleFactory.GetSale();
//sale1.Sell(15);

//ISale sale2 = internetSaleFactory.GetSale();
//sale2.Sell(10);
//sale2.Sell(250);

//Repository Pattern
//PM> Scaffold - DbContext "Server=localhost;Database=DesignPatternsConsoleDB;Truested_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer - OutputDir Models - force
//using (var context = new DesignPatternsConsoleDbContext())
//{
//    var beerRepository = new BeerRepository(context);
//    var beer = new Beer();

//    beer.Name = "Corona";
//    beer.Style = "Pilsner";
//    beerRepository.Add(beer);
//    beerRepository.Save();

//    foreach(var b in beerRepository.Get())
//    {
//        Console.WriteLine(b.Name);
//    }
//}

//Repository Pattern 2
//using (var context = new DesignPatternsConsoleDbContext())
//{
//    var beerRepository = new Repository<Beer>(context);
//    var beer = new Beer() { Name = "Pilsener Callao", Style = "Negra" };
//    beerRepository.Add(beer);
//    beerRepository.Save();

//    foreach(var b in beerRepository.Get())
//    {
//        Console.WriteLine($"{b.Id} {b.Name}");
//    }

//    var brandRepository = new Repository<Brand>(context);
//    var brand = new Brand() { Name = "Pilsener" };
//    brandRepository.Add(brand);
//    brandRepository.Save();

//    foreach (var b in brandRepository.Get())
//    {
//        Console.WriteLine($"{b.BrandId} {b.Name}");
//    }
//}


//Unit of work pattern
//using(var context = new DesignPatternsConsoleDbContext())
//{
//    var unitOfWork = new UnitOfWork(context);
//    var beers = unitOfWork.Beers;
//    var beer = new Beer()
//    {
//        Name = "Fuller",
//        Style = "Porter"
//    };
//    beers.Add(beer);

//    var brands = unitOfWork.Brands;
//    var brand = new Brand()
//    {
//        Name = "Fuller",
//    };
//    beers.Add(beer);

//    unitOfWork.Save();

//}

//Strategy Patterm
var strategy = new Main();
