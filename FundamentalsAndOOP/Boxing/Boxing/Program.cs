using System;
using System.Collections.Generic;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> box = new List<object>();
            box.Add(7);
            box.Add(28);
            box.Add(-1);
            box.Add(true);
            box.Add("chair");
            foreach (object info in box)
            {
                Console.WriteLine(info);
            }
            int sum =0;
            foreach (object info in box)
            {
                if (info is int)
                {
                sum += (int)info;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
