using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace StudioCountingCharacters
{
    class Program
    {
        private static void Main()
        {
            //string myString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            //Console.WriteLine("Enter a string:");
            //string myString = Console.ReadLine();
            string myString = System.IO.File.ReadAllText(@"../../../TextFile1.txt");
            Console.WriteLine(myString);
            Dictionary<char, int> charCount = CountChars.GetCount(myString);


            foreach (char key in charCount.Keys)
            {
                Console.WriteLine($"{key}: {charCount[key]}");
            }
        }
    }
}
