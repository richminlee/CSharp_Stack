using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        // public static int[] RandomArray()
        // {
        //     int[] randy = new int[10];
        //     Random rand = new Random();
        //     for(int val = 0; val < 10; val++)
        //     {
        //         randy[val]=rand.Next(5,25);
        //     }
        //     return randy;
        // }
        // public static void MinMax(int[] numbers)
        // {
        //     int max = numbers[0];
        //     int min = numbers[0];
        //     int sum = 0;
        //     for (int i = 0; i<numbers.Length; i++)
        //     {
        //         if (numbers[i]>max)
        //         {
        //             max=numbers[i];
        //         }
        //         if (numbers[i]<min)
        //         {
        //             min=numbers[i];
        //         }
        //         sum+=numbers[i];
        //     }
        //     Console.WriteLine(max);
        //     Console.WriteLine(min);
        //     Console.WriteLine(sum);
        // }
        // public static string TossCoin()
        // {
        //     Console.WriteLine ("Tossing a Coin");
        //     int randy = new int ();
        //     string coin = new string ("");
        //     Random rand = new Random();
        //     for(int val = 0; val < 1; val++)
        //     {
        //         randy=rand.Next(0,2);
        //         if (randy == 0)
        //         {
        //             coin = "Heads";
        //             Console.WriteLine(coin);
        //         }
        //         if (randy == 1)
        //         {
        //             coin = "Tails";
        //             Console.WriteLine(coin);
        //         }
        //     }
        //     return coin;
        // }
        // public static double TossMultipleCoins(int num)
        // {
        //     Console.WriteLine ("Tossing a Coin");
        //     int randy = new int ();
        //     double coin = new double ();
        //     Random rand = new Random();
        //     for(int val = 0; val < num; val++)
        //     {
        //         randy=rand.Next(0,2);
        //         if (randy == 0)
        //         {
        //             coin += 0;
        //             Console.WriteLine("tails");
        //         }
        //         if (randy == 1)
        //         {
        //             coin += 1;
        //             Console.WriteLine("heads");
        //         }
        //     }
        //     coin = coin/num;
        //     return coin;
        // }
        public static List<string> Names(List<string> nam)
        {
            List<string> name = new List<string>();
            List<string> naamee = new List<string>();
            string randy = new string ("");
            Random rand = new Random();
            int place = nam.Count;
            for(int val = 0; val <place; val++)
            {
                randy = (nam[rand.Next(0,(nam.Count))]);
                name.Add(randy);
                nam.Remove(randy);
                Console.WriteLine(name[val]);
                if (randy.Length>5)
                {
                    naamee.Add(randy);
                }
            }
                return naamee;
        }
        static void Main(string[] args)
        {
            // int[] numbers = RandomArray();
            // MinMax(numbers);
            // Console.WriteLine(TossCoin());
            // Console.WriteLine(TossMultipleCoins(10));
            List<string> namee = new List<string>();
            namee.Add("Todd");
            namee.Add("Tiffany");
            namee.Add("Chalie");
            namee.Add("Geneva");
            namee.Add("Sydney");
            Names(namee);

        }
    }
}
