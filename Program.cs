/*
Program - week6Assignment
Programer - Toby Cantello
Date Created - 2/25/2022
Last Date Updated - 3/4/2022
*/


using System;
using System.Collections.Generic;

namespace week6Assignment
{
    class Program
    {
        static void ProblemOne()
        {
            string input = "";

            List<string> Friends = new List<string>();

            Console.WriteLine("Week 6 Problem 1");
            Console.WriteLine();
            Console.WriteLine();

            do
            {
                Console.WriteLine("Enter a name. To finish hit the ENTER button with no name entered.");
                input = Console.ReadLine();
                
                if (input != "")
                {
                    Friends.Add(input);
                }
                 
                
            } while (input != "");

            if (Friends.Count == 1)
            {
                Console.WriteLine(Friends[0] + " likes your post");
            }
            else if (Friends.Count == 2)
            {
                Console.WriteLine(Friends[0] + " and " + Friends[1] + "likes your post");
            }
            else
            {
                Console.WriteLine(Friends[0] + " , " + Friends[1] + " and " + (Friends.Count - 2) +" others like your post.");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        static void ProblemTwo()
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();

            Console.WriteLine("Week 6 Problem 2");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter a sentence.");
            string userInput = Console.ReadLine();
            string userInputLower = userInput.ToLower();

            foreach (char letter in userInputLower)
            {
                if (letters.ContainsKey(letter))
                {
                    letters[letter] += 1;
                }
                else
                {
                    letters.Add(letter, 1);
                }
            }
            
            foreach(KeyValuePair<char, int> kvp in letters)
            {
                Console.WriteLine(kvp.Key + " | " + kvp.Value);
            }
        }
        static void Main(string[] args)
        {
            ProblemOne();
            ProblemTwo();
        }
    }
}
