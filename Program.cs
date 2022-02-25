using System;
using System.Collections.Generic;

namespace week6Assignment
{
    class Program
    {
        static void ProblemOne()
        {
            List<string> friends = new List<string>();

            Console.WriteLine("Enter a name :");
            string friend = Console.ReadLine();
            while (friend != " ")
            {
                friends.Add(friend);
            }
            foreach (var item in friends)
            {
                Console.WriteLine("You enterd: " + friend);
            }
        }

        static void ProblemTwo()
        {

        }
        static void Main(string[] args)
        {
            ProblemOne();
            ProblemTwo();
        }
    }
}
