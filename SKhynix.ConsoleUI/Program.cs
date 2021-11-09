using System;
using System.IO;

namespace SKhynix.ConsoleUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var pattern = "dotnet";

            Array.ForEach(args, directoryPath =>
            {
                if (Directory.Exists(directoryPath))
                {
                    var files = Directory.GetFiles(directoryPath);

                    Array.ForEach(files, file =>
                    {
                        Console.WriteLine($"{file} - {GetEntryCount(File.ReadAllText(file), pattern)}");
                    });
                }
            });
        }

        public static int GetEntryCount(string text, string entry)
        {
            return text.Split(entry).Length - 1;
        }
    }
}