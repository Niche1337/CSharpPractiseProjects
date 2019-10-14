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



        static string EndProg()
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Do you want to use the calculator Y/n");
            return Console.ReadLine();
        }

        static void Tax()
        {

            double preTaxValue;
            double newTaxValue = 0;
            Console.WriteLine("Enter your current salary. ");
            preTaxValue = double.Parse(Console.ReadLine());

            ///calculations are wrong buts its just for practise

            if (preTaxValue > 11850 && preTaxValue <= 46350)
            {
                newTaxValue += preTaxValue - 11850 * 0.20;
            }

            if (preTaxValue > 46351 && preTaxValue <= 150000)
            {
                newTaxValue += (preTaxValue - 46350 * 0.40);
            }

            if (preTaxValue > 150000)
            {
                newTaxValue += (preTaxValue - 150000 * 0.45);
            }

            Console.WriteLine($"Your after tax amount is {newTaxValue}.\nThank you for using this calculator.");

        }

        static void Main(string[] args)
        {

            while (EndProg().ToLower() != "n")
            {
                Tax();
            }



            
        }
    }
}
