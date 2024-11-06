using Liskov_Principle;

SaleWithTaxes sale = new LocalSale(100, "Hector", 0.16m);
sale.CalculateTaxes();
sale.Generate();

AbstractSale foreignSale = new ForeignSale(200, "Pepe");
foreignSale.Generate();