using DesignPatterns.Factory;
using DesignPatterns.Singleton;

/* Singleton */
/*
var log = Log.Instance;
log.Save("a");
log.Save("b");

var a = Singleton.Instance;
var b = Singleton.Instance;

Console.WriteLine(a == b);
*/

///  Factory Pattern
SaleFactory storeSaleFactory = new StoreSaleFactory(10);
SaleFactory internetSaleFactory = new InternetSaleFactory(2);

ISale sale1 = storeSaleFactory.GetSale();
sale1.Sell(15);

ISale sale2 = internetSaleFactory.GetSale();
sale2.Sell(10);
sale2.Sell(250);
