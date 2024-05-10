using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    internal class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book(){Title = "ADO.NET Step by step", Price = 5},
                new Book(){Title = "ASP.NET MVC", Price = 8},
                new Book(){Title = "ASP.NET Web API", Price = 10},
                new Book(){Title = "C# Advanced Topics", Price = 12},
                new Book(){Title = "Entity Framework", Price = 14},
            };
        }
    }
}
