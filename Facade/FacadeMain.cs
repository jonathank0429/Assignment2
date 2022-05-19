using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Facade
{
    class FacadeMain
    {
       public void Run()
        {
            // Write a facade to make it easier to save and load words

            /*List<char> one = new();
            List<char> two = new();
            List<char> three = new();
            List<char> four = new();
            List<char> five = new();*/

            List<string> saved_words = new List<string>();

            // Save Word
            Console.WriteLine("Enter input: ");
            string input = Console.ReadLine();
            if (input.Length!=5)
            {
                Console.WriteLine("Exiting program - Error - The string needs to be EXACTLY 5 characters long");
                Console.ReadKey(true);                
            }
            else
            {
                saved_words.Add(input);
            }

            // Load Word
            if (saved_words.Count() >0)
            {
                //char[] word = { one.Last(), two.Last(), three.Last(), four.Last(), five.Last() };
                Console.WriteLine(saved_words[0]);
            }            
        }
    }
}
