using System;
/*
Project:    Lab 2 Calculate Batting Average
Date:        to/da/y
Author:     You the big new programmer
Notes:      This program reads in a baseball player's name,
            number of hits and number of at bats.
            The player's batting average is calculated and displayed
*/
namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string strPlayerName;
            Double dblHits,dblAtBats;
            Double dblBattingAverage;

            Console.WriteLine("This program calculates a baseball player's batter average");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Enter player's name: ");
            strPlayerName = Console.ReadLine();                 //  or we could use the Utils class strPlayerName = Utils.GetInput("Enter player's name");

            //  prompt for hits and at bats
            Console.Write("Enter the player's # of hits: ");
            dblHits = Convert.ToInt32(Console.ReadLine());        //  or we could use the Utils class hHits = Utils.GetNumber("Enter the player's # of hits: ");
            Console.Write("Enter the player's # of at bats: ");
            dblAtBats = Convert.ToInt32(Console.ReadLine()); // or we could use the Utils class hHits = Utils.GetNumber("Enter the player's # of at bats: ");
            dblBattingAverage = dblHits / dblAtBats;
            Console.WriteLine($"{strPlayerName}'s batting average is {dblBattingAverage}");
        }

    }
}
