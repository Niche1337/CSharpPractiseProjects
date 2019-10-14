using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Given a string containing only the characters x and y, find whether there are the same number of xs and ys.

//balanced("xxxyyy") => true
//balanced("yyyxxx") => true
//balanced("xxxyyyy") => false
//balanced("yyxyxxyxxyyyyxxxyxyx") => true
//balanced("xyxxxxyyyxyxxyxxyy") => false
//balanced("") => true
//balanced("x") => false

//Given a string containing only lowercase letters, 
//    find whether every letter that appears in the string appears the same number of times.Don't forget to handle the empty string ("") correctly!

//balanced_bonus("xxxyyyzzz") => true
//balanced_bonus("abccbaabccba") => true
//balanced_bonus("xxxyyyzzzz") => false
//balanced_bonus("abcdefghijklmnopqrstuvwxyz") => true
//balanced_bonus("pqq") => false
//balanced_bonus("fdedfdeffeddefeeeefddf") => false
//balanced_bonus("www") => true
//balanced_bonus("x") => true
//balanced_bonus("") => true

//Note that balanced_bonus behaves differently than balanced for a few inputs, e.g. "x".

namespace PerfectlyBalanced
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
