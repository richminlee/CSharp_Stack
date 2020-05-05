using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        // public static void PrintNumbers()
        // {
        //     for (int i = 1; i<=255; i++)
        //     {
        //     Console.WriteLine(i);
        //     }
        // }
        // public static void PrintOdds()
        // {
        //     for (int i = 1; i<=255; i++)
        //     {
        //         if (i%2 !=0)
        //         {
        //             Console.WriteLine(i);
        //         }
        //     }
        // }
        // public static void PrintSum()
        // {
        //     int sum = 0;
        //     for (int i = 0; i<=255; i++)
        //     {
        //         sum += i;
        //         Console.WriteLine($"New Number: {i} Sum: {sum}");
        //     }
        // }
        // public static void LoopArray(int[] numbers)
        // {
        //     for (int i = 0; i < numbers.Length; i++)
        //     {
        //         Console.WriteLine(numbers[i]);
        //     }
        // }
        // public static int FindMax(int[] numbers)
        // {
        //     int max = numbers[0];
        //     for (int i = 0; i < numbers.Length; i++)
        //     {
        //         if(numbers[i]>max)
        //         {
        //             max = numbers[i];
        //         }
        //     }
        //     return max;
        // }

        // public static void GetAverage(int[] numbers)
        // {
        //     int sum = 0;
        //     for (int i = 0; i < numbers.Length; i++)
        //     {
        //         sum += numbers[i];
        //     }
        //     sum = sum / numbers.Length;
        //     Console.WriteLine(sum);
        // }
        // public static int[] OddArray(int[] numbers)
        // {
        //     List<int> OddNumbers = new List<int>();
        //     int[] OddNumber = new int [(numbers.Length/2)+1];
        //     for (int i = 0; i <=numbers.Length; i++)
        //     {
        //         if (i%2 != 0)
        //         {
        //             OddNumbers.Add(i);
        //         }
        //     }
        //     for (int j = 0; j< OddNumbers.Count; j++)
        //     {
        //         OddNumber[j]= OddNumbers[j];
        //     }
        //     return OddNumber;
        // }
        // public static int GreaterThanY(int[] numbers, int y)
        // {
        //     int sum = 0;
        //     for (int i = 0; i<numbers.Length; i++)
        //     {
        //         if (numbers[i]>y)
        //         {
        //             sum+=1;
        //         }
        //     }
        //     return sum;
        // }
        // public static void SquareArrayValues(int[] numbers)
        // {
        //     for (int i =0; i<numbers.Length; i++)
        //     {
        //         numbers[i]=numbers[i]*numbers[i];
        //         Console.WriteLine(numbers[i]);
        //     }
        // }
        // public static void EliminateNegatives(int[] numbers)
        // {
        //     for (int i = 0; i<numbers.Length;i++)
        //     {
        //         if (numbers[i]< 0)
        //         {
        //             numbers[i]=0;
        //         }
        //         Console.WriteLine(numbers[i]);
        //     }
        // }
        // public static void MinMaxAverage(int[] numbers)
        // {
        //     int max = numbers[0];
        //     int min = numbers[0];
        //     int ave = 0;
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
        //         ave += numbers[i];
        //     }
        //     ave = ave/numbers.Length;
        //     Console.WriteLine(max);
        //     Console.WriteLine(min);
        //     Console.WriteLine(ave);
        // }
        // public static void ShiftValues(int[] numbers)
        // {
        //     for (int i = 1; i<numbers.Length; i++)
        //     {
        //         numbers[0]=numbers[i];
        //         Console.WriteLine(numbers[i]);
        //     }
        //     numbers[numbers.Length-1] = 0;
        //     Console.WriteLine(numbers[numbers.Length-1]);
        // }
        public static object[] NumToString(int[] numbers)
        {
            object[] number = new object[numbers.Length];
            for(int i=0; i<numbers.Length; i++)
            {
                number[i]=(numbers[i]);
            }
            for(int j=0; j<number.Length;j++)
            {
                if ((int)number[j]<0)
                {
                    number[j]="Dojo";
                }
            }
            for(int k=0; k<number.Length;k++)
            {
                if(number[k] is int)
                {
                    Console.WriteLine(number[k]);
                }
                if(number[k] is string)
                {
                    Console.WriteLine(number[k]);
                }
            }
            return number;
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
        }
        static void Main(string[] args)
        {
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            // LoopArray(new int[] {1,2,3,4,5,6});
            // Console.WriteLine(FindMax(new int[] {1,-2,3,0,5,777}));
            // GetAverage(new int[] {1,2,3,4,5,6});
            // Console.WriteLine(OddArray(new int[255]));
            // Console.WriteLine(GreaterThanY(new int[]{1,3,5,7},3));
            // SquareArrayValues(new int[]{1,5,10,-10});
            // EliminateNegatives(new int[] {1,5,10,-2});
            // MinMaxAverage(new int[] {1,5,10,-2});
            // ShiftValues(new int [] {1,5,10,7,-2});
            Console.WriteLine(NumToString(new int[]{-1,-3,2}));
        }
    }
}
