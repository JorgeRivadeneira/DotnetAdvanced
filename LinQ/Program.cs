using LinQ;

var books = new BookRepository().GetBooks();

//Linq query operators
var cheaperBooks = from b in books 
                   where b.Price < 10 
                   orderby b.Title 
                   select b.Title;

var cheapBooks = books
            .Where(x => x.Price < 10)
            .OrderBy(y => y.Price)
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