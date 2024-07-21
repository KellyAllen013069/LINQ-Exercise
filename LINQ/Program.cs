using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            //going old school
            var gameNames = new List<string>()
            {
                "Pac-Man",
                "Donkey Kong",
                "Galaga",
                "Centipede",
                "Star Wars",
                "Dig Dug"
            };

            var orderedGameNames = gameNames.OrderBy(game => game.Length).ToList();

            foreach (var game in orderedGameNames)
            {
                Console.WriteLine(game);
            }
            
        }
    }
}
