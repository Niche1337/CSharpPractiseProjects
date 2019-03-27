using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 8, 16, 32, 64 };
            IEnumerable<int> numbersGreaterThanTen = from number in numbers where number > 10 select number;
            Console.Write(numbers);
            Console.Write(numbersGreaterThanTen);
            Console.ReadKey();
        }
    }
}
