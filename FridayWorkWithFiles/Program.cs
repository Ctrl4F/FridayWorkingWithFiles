using System;
using System.IO;

namespace FridayWorkWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What file do you want do move?");
            string userinput = Console.ReadLine();
            MoveFileFruit(userinput);
            Console.WriteLine("What file do you want to move to the vegetable folder?");
            string userinput2 = Console.ReadLine();
            MoveFileVegetables(userinput2);
            FileDeleteCheese();
            FileDeleteToiletPaper();
        }
        public static void MoveFileFruit(string name)
        {
            string sourcedirectories = @"C:\Users\opilane\samples\WorkingWithFiles-Task";
            string destinationpath = @"C:\Users\opilane\samples\WorkingWithFiles-Task\fruit";
            string filename = $"{name}.txt";
            if (File.Exists(Path.Combine(sourcedirectories, filename)))
            {
                File.Move(Path.Combine(sourcedirectories, filename), Path.Combine(destinationpath, filename));
                Console.WriteLine("File moved");
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
        public static void MoveFileVegetables(string name)
        {
            string sourcedirectories = @"C:\Users\opilane\samples\WorkingWithFiles-Task";
            string destinationpath = @"C:\Users\opilane\samples\WorkingWithFiles-Task\vegetables";
            string filename = $"{name}.txt";
            if(File.Exists(Path.Combine(sourcedirectories, filename)))
            {
                File.Move(Path.Combine(sourcedirectories, filename), Path.Combine(destinationpath, filename));
                Console.WriteLine("File moved");
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
        public static void FileDeleteCheese()
        {
            string rootpath = @"C:\Users\opilane\samples\WorkingWithFiles-Task\vegetables";
            string filename = "Cheese.txt";
            if (File.Exists(Path.Combine(rootpath, filename)))
            {
                File.Delete(Path.Combine(rootpath, filename));
                Console.WriteLine("Cheese has been deleted.");
            }
            else
            {
                Console.WriteLine("Cheese has not been found.");
            }
        }
        public static void FileDeleteToiletPaper()
        {
            string rootpath = @"C:\Users\opilane\samples\WorkingWithFiles-Task\fruit";
            string filename = "toilet.txt";
            if (File.Exists(Path.Combine(rootpath, filename)))
            {
                File.Delete(Path.Combine(rootpath, filename));
                Console.WriteLine("Toiletpaper has been deleted.");
            }
            else
            {
                Console.WriteLine("Toiletpaper has not been found.");
            }
        }
    }
}
