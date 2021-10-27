using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mywishes = new List<string>();
            mywishes.Add("hello gay");
            mywishes.Add("hello man");
            mywishes.Add("hello yes");

            int listlenght = mywishes.Count;

            Console.WriteLine($"list lenght: {listlenght}");
            //Console.WriteLine(mywishes[0]);
            //Console.WriteLine(mywishes[1]);
            //Console.WriteLine(mywishes[2]);


            foreach (string wish in mywishes)
            {
                Console.WriteLine($"you wish for: {wish}");
            }
        }
    }
}
