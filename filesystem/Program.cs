using System;
using System.IO;

namespace filesystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string roothdirectory = @"C:\Users\opilane\samples";

            Console.WriteLine("enter directory name");
            string userfolder = Console.ReadLine();

            string newdirectoryfullpath = @$"{roothdirectory}\{userfolder}";
            bool directoryexists = Directory.Exists(newdirectoryfullpath);

            if (directoryexists)
            {
                Console.WriteLine($"{userfolder} exist.");
                Console.WriteLine("would you like to create a folder? y/n");
                char userinput = Convert.ToChar(Console.ReadLine().ToLower());


                if(userinput == 'y')
                {
                    Console.WriteLine("enter file name:");
                    string userfile = Console.ReadLine() + ".txt";
                    string userfilefullpath = $@"{newdirectoryfullpath}\{userfile}";
                    File.Create(userfilefullpath);
                }
                else
                {
                    Console.WriteLine("take care!");
                }

            }else
            {
                Directory.CreateDirectory(newdirectoryfullpath);
                Console.WriteLine($"directory {userfolder} has been created");
            }

           

        }
    }
}
