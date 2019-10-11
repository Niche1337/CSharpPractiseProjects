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
            Console.WriteLine(numbers);
            Console.WriteLine(numbersGreaterThanTen);

            List<Bird> birds = new List<Bird>
            {
                new Bird {Name= "Cardinal", Color = "Red", Sightings = 3 },
                new Bird {Name = "Dove", Color = "White", Sightings = 2 }
            };

            birds.Add(new Bird { Name = "Robin", Color = "Red", Sightings = 5});
            var canary = new Bird { Name = "Canary", Color = "Yellow", Sightings = 0 };
            birds.Add(canary);

            foreach (Bird bird in birds)
            {
                Console.WriteLine(bird.Name);
            }

            //Annoymous Linq
            var mysteryBird = new { Name = "MysteryBird", Color = "White", Sightings = 3 };
            var matchingBirds = from b in birds where mysteryBird.Color == b.Color select new { BirdName = b.Name, BirdColor = b.Color };




        }
    }
}
