using System;
using System.IO;
using System.Text;

class Program
{
    public static class ReadableFormat
    {
        // Array for all suffix  
        static readonly string[] suffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB" };
        public static string HumanReadableBytes(Int64 bytes)
        {
            int counter;
            decimal number = (decimal)bytes;
            for (counter = 0; Math.Round(number / 1024) >= 1; counter++)
            {
                number = number / 1024;

            }
            return string.Format("{0:n1}{1}", number, suffixes[counter]);
        }
    }
    static void Main(string[] args)
    {

        string fileName = @"D:\DemoCode\DemoImage.jpg";
         FileInfo file = new FileInfo(fileName);

        if (file.Exists)
        {
            string size = ReadableFormat.HumanReadableBytes(file.Length);
            Console.WriteLine(size);
        }
        else
        {
            Console.WriteLine("File not found");
        }
        Console.ReadKey();
    }
}