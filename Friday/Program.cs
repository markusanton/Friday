using System;
using System.IO;

namespace Friday
{
    class Program
    {
        static void Main(string[] args)
        {
            string samplePath = @"C:\Users\opilane\samples";
            string directoriesTxt = @"C:\Users\opilane\Friday\sampleDirectories.txt";
            string filesTxt = @"C:\Users\opilane\Friday\sampleFiles.txt";

            DirectoryWriter(directoriesTxt, samplePath);
            FileWriter(filesTxt, samplePath);
            Console.WriteLine("Written!!");

        }
        public static void DirectoryWriter(string fileName, string filePath)
        {
            string[] getNested = Directory.GetDirectories(filePath, "*", SearchOption.AllDirectories);
            File.WriteAllLines(fileName, getNested);
        }
        public static void FileWriter(string fileName, string filePath)
        {
            string[] allFiles = Directory.GetFiles(filePath, "*", SearchOption.AllDirectories);
            File.WriteAllLines(fileName, allFiles);
        }
    }
}
