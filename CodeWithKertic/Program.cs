using System;

namespace CodeWithKertic
{
    public class EstablishUserDetails
    {
        public static void Main()
        {
            /* Ask the user what their name is */
            Console.WriteLine("Hello [User], What is your name ?");
            var name = Console.ReadLine();

            /* Respond to their input by saying “Hello, <name>” */
            Console.WriteLine("Hello " + name + "!!!");

            /* Ask them to solve a math question (simple is better here) */

            QuestionOne.Ask();
        }
    }
}
