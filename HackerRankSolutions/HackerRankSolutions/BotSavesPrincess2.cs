using System;
using System.Linq;
namespace BotSavesPrincess
{
    class Solution
    {
        static void nextMove(int n, int r, int c, String[] grid)
        {
            var botString = "p";
            var princessString = "m";
            int botY = grid.TakeWhile(car => !car.Contains(botString)).Count();
            int botX = grid[botY].IndexOf(botString);
            int princessY = grid.TakeWhile(car => !car.Contains(princessString)).Count();
            int princessX = grid[princessY].IndexOf(princessString);
            var diffY = botY - princessY;
            var diffX = botX - princessX;
            if (diffY != 0)
                Console.WriteLine(diffY < 0 ? "UP" : "DOWN");
            else if (diffX != 0)
                Console.WriteLine(diffX < 0 ? "LEFT" : "RIGHT");
        }
        static void Exec(String[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());
            String pos;
            pos = Console.ReadLine();
            String[] position = pos.Split(' ');
            int[] int_pos = new int[2];
            int_pos[0] = Convert.ToInt32(position[0]);
            int_pos[1] = Convert.ToInt32(position[1]);
            String[] grid = new String[n];
            for (int i = 0; i < n; i++)
            {
                grid[i] = Console.ReadLine();
            }
            nextMove(n, int_pos[0], int_pos[1], grid);
        }
    }
}
