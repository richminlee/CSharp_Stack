using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] array1 = new int[] {0,1,2,3,4,5,6,7,8,9};
            // string[] array2 = new string[] {"Tim","Martin","Nikki","Sara"};
            // bool[] array3 = new bool[10];
            //     for (int i = 0; i <10; i++)
            //     {
            //         if (i % 2 ==0)
            //         {
            //             array3[i]=true;
            //         }
            //     }
            // Console.WriteLine(array1);
            // Console.WriteLine(array2);
            // Console.WriteLine(array3[1]);

            // List<string> IceCream = new List<string>();
            // IceCream.Add("Chocolate");
            // IceCream.Add("Vanila");
            // IceCream.Add("Strawberry");
            // IceCream.Add("Rocky Road");
            // IceCream.Add("Mocha");
            // Console.WriteLine(IceCream.Count);
            // Console.WriteLine(IceCream[2]);
            // IceCream.Remove("Strawberry");
            // Console.WriteLine(IceCream.Count);

            Dictionary<string,string> name = new Dictionary<string,string>();
            name.Add("Tim","Chocolate");
            name.Add("Martin","Vanilla");
            name.Add("Nikki","Rocky Road");
            name.Add("Sara","Mocha");
            foreach (KeyValuePair<string,string> info in name)
            {
            Console.WriteLine(info.Key + " - " + info.Value);
            }
        }
    }
}
