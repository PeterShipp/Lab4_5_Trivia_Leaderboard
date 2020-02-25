using System;
using System.Collections.Generic;

namespace Lab4_5_Trivia_Leaderboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello My World!");
            List<string> myScoreList = new List<string>();
            myScoreList.Add("4400");
            myScoreList.Add("8900");
            myScoreList.Add("1200");
            myScoreList.Add("3700");
            myScoreList.Add("7200");


            myScoreList.Sort();

            foreach (string m in myScoreList)
            {
                Console.WriteLine(m);
            }

            myScoreList.Reverse();

            foreach (string m in myScoreList)
            {
                Console.WriteLine(m);
            }

            myScoreList.Add("2400");

            myScoreList.Remove("4400");

        }
    }
}
