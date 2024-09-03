using LinQ;

var books = new BookRepository().GetBooks();
var be = books.Where(x => x.Price < 10).Take(2).ToList();

//Linq query operators
var cheaperBooks = from b in books 
                   where b.Price < 10 
                   orderby b.Title 
                   select b.Title;

//Linq extension methods
var cheapBooks = books
            .Where(x => x.Price < 10)
            .OrderBy(y => y.Price)
            .Select(x => x.Title)            
            .ToList();

//LinQ Extension Methods
var book1 = books.SingleOrDefault(b => b.Title == "ASP.NET MVC"); //FirstOrDefault is the same

var pageBooks = books.Skip(2).Take(3);

var count = books.Count();

var totalPrices = books.Sum(b => b.Price);

foreach (var page in pageBooks)
{
    Console.WriteLine(page.Title);
}

//foreach (var book in cheapBooks)
//    Console.WriteLine(string.Join("\n", book.Title + " " + book.Price));

//Ejemplo de joins
Console.WriteLine("\n========== JOINS EXAMPLE ===============\n");
var orders = OrderRepository.GetOrders();
var customers = OrderRepository.GetCustomers();

var q = from order in orders
        join customer in customers
        on order.CustomerId equals customer.Id
        where order.Total > 100
        orderby order.Total descending
        select new
        {
            Name = customer.Name, 
            Id = customer.Id, 
            Total = order.Total
        };


var lambdaQuery = orders
        .Join(
            customers,
            order => order.CustomerId,
            customer => customer.Id,
            (order, customer) => new
            {
                Name = customer.Name,
                Id = customer.Id,
                Total = order.Total
            })
        .Where(x => x.Total > 100);

foreach (var item in q)
{
    //Console.WriteLine(string.Join(" ", item.Name, item.Id, item.Total));
    Console.WriteLine($"El cliente: {item.Name}, con ID: {item.Id}, ha comprado el total de: {item.Total.ToString()}");
}

Console.WriteLine("\n");

var query = from customer in customers
            join order in orders on customer.Id equals order.CustomerId
            select new
            {
                CustomerName = customer.Name,
                ProductName = order.ProductName
            };

foreach (var item in query)
{
    Console.WriteLine($"Customer: {item.CustomerName}, Product: {item.ProductName}");
}