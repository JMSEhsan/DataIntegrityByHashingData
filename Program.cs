//Data Integrity by Hashing Data


// See https://aka.ms/new-console-template for more information

using System;

   class Program
    {
        static int calculateChecksum(string source)
        {
            int total = 0;
            foreach (char ch in source)
               total = total + (int)ch;
            return total;
        }

        static void showCheksum(string source)
        {
            Console.WriteLine("Cheksum for {0} is {1}", source, calculateChecksum(source));
        }

        static void Main (String[] args)
        {
            showCheksum("Hello world");
            showCheksum("world Hello");
            showCheksum("Hemmm world");

            Console.ReadKey();
        }

        static void showHash(object source)
        {
            Console.WriteLine("Hash for {0} is: {1, x}", source, source.GetHashCode());
        }
   }
