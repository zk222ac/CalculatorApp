using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Book java = new Book("Java" , 2019);
            Book java = new Book
            {
                Title = "Java",
                Year = 2019
            };

            Book csharp = new Book("C#" , 2014);
        }
    }
}
