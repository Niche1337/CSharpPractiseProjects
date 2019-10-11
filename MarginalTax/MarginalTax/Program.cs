using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarginalTax
{
    class Program
    {

        //tasks
        //take value from user 
        //work out tax bracket
        //take away amounts at every interval 
        //sum up all the breakdowns to get final tax bracket value
        // <= 11850 = 0%
        // 11851 - 46350 = 20%
        // 46351 - 150000 = 40%
        // > 150000 = 45%

        static void EndProg()
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Press any key to close the application");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {



            EndProg();
        }
    }
}
