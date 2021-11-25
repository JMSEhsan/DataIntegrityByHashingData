/*Data Integrity by Hashing Data
Programing in C# - Exam Ref. 70-483 by Rob Miles, Microsoft, 2019
*/

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
     
        static void showHash(object source)
        {  
            Console.WriteLine("Hash for {0} is: {1:x}", source, source.GetHashCode());
        }

        static void Main (String[] args)
        {
            showCheksum("Hello world");
            showCheksum("world Hello");
            showCheksum("Hemmm world");

            showHash("Hello world");
            showHash("world Hello");
            showHash("Hemmm world");

            Console.ReadKey();
        }
   }
