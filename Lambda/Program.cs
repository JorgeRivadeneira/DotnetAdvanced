
//Example 1:
//Func<int, int> square = number => number * number;
//Console.WriteLine(square);

//() => ... si no se necesitan argumentos
//x => x.... //un solo argumento
// (x, y, z) => ... //varios argumentos

//Example 2:
//const int factor = 5;
//Func<int, int> multiplier = n => n * factor;
//Console.WriteLine(multiplier(10));

//Example 3:
using Lambda;

var books = new BookRepository().GetBooks();

var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
Console.WriteLine(cheapBooks);

var cheapBooks2 = books.FindAll(x => x.Price < 10);
foreach (var book in cheapBooks2)
{
    Console.WriteLine(book.Title);
}


static bool IsCheaperThan10Dollars(Book book)
{
    return book.Price < 10;
}

