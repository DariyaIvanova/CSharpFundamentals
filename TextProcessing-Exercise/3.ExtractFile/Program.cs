﻿namespace _3.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();

            string fileName = string.Empty;
            string fileExtension = string.Empty;

            int lastSeparatorIndex = filePath.LastIndexOf('\\');
            int extensionIndex = filePath.LastIndexOf('.');

            if (lastSeparatorIndex != -1 && extensionIndex != -1 && extensionIndex > lastSeparatorIndex)
            {
                fileName = filePath.Substring(lastSeparatorIndex + 1, extensionIndex - lastSeparatorIndex - 1);
                fileExtension = filePath.Substring(extensionIndex + 1);
            }

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");

            //Console.WriteLine($"File name: {Path.GetFileNameWithoutExtension(filePath)}");
            //Console.WriteLine($"File name: {Path.GetExtension(filePath).Replace(".", string.Empty)}");

        }
    }
}
