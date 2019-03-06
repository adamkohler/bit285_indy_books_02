using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndyBooks.Models
{
    public class BookStuff
    {
        public decimal TotalValue(Book books)
        {
            decimal x = 0.00M;
            x += books.Price;
            return x;
        }
    }
}
