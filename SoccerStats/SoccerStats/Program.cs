using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SoccerStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            //var files = directory.GetFiles("*.txt");
            var fileName = Path.Combine(directory.FullName, "SoccerGameResults.csv");
            var fileContents = ReadSoccerResults(fileName);
            //var fileContents = ReadFile(fileName);
            //string [] fileLines = fileContents.Split(new char[] {'\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            //foreach(var line in fileLines)
            //{
            //    Console.WriteLine(line);

            //}

            //var fileName = Path.Combine(directory.FullName, "data.txt");
            //var file = new FileInfo(fileName);
            //if (file.Exists)
            //{
            //    using (var reader = new StreamReader(file.FullName))
            //    {
            //        Console.SetIn(reader);
            //        Console.WriteLine(Console.ReadLine());
            //    }



            Console.ReadKey();

        }



        //foreach(var file in files)
        //{ 
        //    Console.WriteLine(file.Name);
        //}

        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }

        }


        public static List<string[]> ReadSoccerResults(string fileName)
        {
            var soccerResults = new List<string[]>();
            using (var reader = new StreamReader(fileName))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    soccerResults.Add(values);
                }
                return soccerResults;
            }
        }
    }
}
