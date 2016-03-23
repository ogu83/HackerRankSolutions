using System;
using System.Linq;

namespace BotSavesPrincess
{
    public class Main
    {
        public static void Exec()
        {
            int m = int.Parse(Console.ReadLine());
            var grid = new string[m];
            for (int i = 0; i < m; i++)
                grid[i] = Console.ReadLine();

            var botString = "p";
            var princessString = "m";

            int botY = grid.TakeWhile(car => !car.Contains(botString)).Count();
            int botX = grid[botY].IndexOf(botString);

            int princessY = grid.TakeWhile(car => !car.Contains(princessString)).Count();
            int princessX = grid[princessY].IndexOf(princessString);

            var diffY = botY - princessY;
            var diffX = botX - princessX;

            for (int i = 0; i < Math.Abs(diffY); i++)            
                Console.WriteLine(diffY > 0 ? "UP" : "DOWN");

            for (int i = 0; i < Math.Abs(diffX); i++)
                Console.WriteLine(diffX > 0 ? "LEFT" : "RIGHT");            
        }
    }
}