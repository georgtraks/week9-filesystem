using System;
using System.IO;

namespace filecreate
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirectory = @"C:\Users\opilane\samples\wishlist";
            string userfile = "wishlist";
            string fullfilepath = $@"{rootdirectory}\{userfile}.txt";

            bool directoryexists = Directory.Exists(rootdirectory);
            bool fileexists = File.Exists(fullfilepath);

            if(directoryexists && fileexists)
            {
                Console.WriteLine($"{userfile} already exists in{rootdirectory}.");
            }
            else if (!directoryexists)
            {
                Console.WriteLine($"{rootdirectory} does not exists.");
                Directory.CreateDirectory(rootdirectory);
                Console.WriteLine($"{rootdirectory} has been created.");
                File.Create(fullfilepath);
                Console.WriteLine($"{userfile}.txt has been created in {rootdirectory}.");
            }
            else
            {
                File.Create(fullfilepath);
                Console.WriteLine($"{userfile}.txt has been created in {rootdirectory}.");

            }
            


        }
    }
}
