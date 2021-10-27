using System;
using System.IO;

namespace deadingfromfile
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirectory = @"C:\Users\opilane\samples\wishlist";
            string userfile = "wishlist";
            string fullfilepath = $@"{rootdirectory}\{userfile}.txt";

            string[] datafromfile = File.ReadAllLines(fullfilepath);

            foreach(string line in datafromfile)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();
            datafromfile[0] = "ligma";

            foreach (string line in datafromfile)
            {
                Console.WriteLine(line);
            }
            File.WriteAllLines(fullfilepath, datafromfile);


        }
    }
}
