using System;

public class BotClean
{
    static String DOWN = "DOWN";
    static String LEFT = "LEFT";
    static String RIGHT = "RIGHT";
    static String CLEAN = "CLEAN";

    static String DIRTY_CELL = "d";
    static String ROBOT = "b";
    static String CLEAN_CELL = "-";

    static void next_move(int posx, int posy, String[] board)
    {
        if (haveToClean(board)) move(CLEAN);
        foreach (var line in board)
        {
            if (robotLine(line) && lineIsDirty(line))
            {
                cleanTheLine(line);
            }
            else if (robotLine(line) && lineIsClean(line))
            {
                move(DOWN);
            }
        }
    }

    static bool haveToClean(String[] board)
    {
        bool robotIsHere = false;
        foreach (var line in board)
        {
            robotIsHere = robotLine(line);
        }
        return !robotIsHere;
    }

    static bool lineIsClean(String line)
    {
        return !lineIsDirty(line);
    }
    static bool lineIsDirty(String line)
    {
        return line.Contains(DIRTY_CELL);
    }

    static bool robotLine(String line)
    {
        return line.Contains(ROBOT);
    }

    static void cleanTheLine(String line)
    {
        String flatView = line.Replace(CLEAN_CELL, "");

        if (flatView.StartsWith(DIRTY_CELL))
        {
            move(LEFT);
        }
        else
        {
            move(RIGHT);
        }
    }

    static void move(String direction)
    {
        Console.WriteLine(direction);
    }

    public static void exec(String[] args)
    {
        String temp = Console.ReadLine();
        String[] position = temp.Split(' ');
        int[] pos = new int[2];
        String[] board = new String[5];
        for (int i = 0; i < 5; i++)
        {
            board[i] = Console.ReadLine();
        }
        for (int i = 0; i < 2; i++) pos[i] = Convert.ToInt32(position[i]);
        next_move(pos[0], pos[1], board);
    }
}
