using System;

namespace CodeWithKertic
{
    public static class IncorrectAnswer
    {
        public static void TryAgain()
        {
            string userInput;
            
            Console.WriteLine("Incorrect");
            /* Ask them if they would like to try again */
            Console.WriteLine("Try Again  ?");
            Console.WriteLine("Enter Y or N");

            userInput = Console.ReadLine().ToUpper();

            /* If they want to try again, repeat the above steps */
            if (userInput == "Y")
            {
                QuestionOne.Ask();
            }
            else
            {
                GameOver.GoodBye();
            }
        }
    }
}
 