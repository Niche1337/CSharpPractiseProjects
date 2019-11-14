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


        public static List<GameResult> ReadSoccerResults(string fileName)
        {
            var soccerResults = new List<GameResult>();
            using (var reader = new StreamReader(fileName))
            {
                string line = "";
                reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    var gameResult = new GameResult(); 
                    string[] values = line.Split(',');
                    DateTime gameDate;
                    if (DateTime.TryParse(values[0], out gameDate))
                    {
                        gameResult.GameDate = gameDate;
                    }
                    gameResult.TeamName = values[1];
                    HomeOrAway homeOrAway;
                    if (Enum.TryParse(values[2], out homeOrAway))
                    {
                        gameResult.HomeOrAway = homeOrAway;
                    }
                    int parseInt;
                    if (int.TryParse(values[3], out parseInt))
                    {
                        gameResult.Goals = parseInt;
                    }
                    if (int.TryParse(values[4], out parseInt))
                    {
                        gameResult.GoalAttempts = parseInt;
                    }
                    if (int.TryParse(values[5], out parseInt))
                    {
                        gameResult.ShotsOnGoal = parseInt;
                    }
                    if (int.TryParse(values[6], out parseInt))
                    {
                        gameResult.ShotsOffGoal = parseInt;
                    }
                    double parseDouble;
                    if (double.TryParse(values[7], out parseDouble))
                    {
                        gameResult.PossesionPercent = parseDouble;
                    }
                    
                    soccerResults.Add(gameResult);
                }
         
            }
            return soccerResults;
        }
    }
}
