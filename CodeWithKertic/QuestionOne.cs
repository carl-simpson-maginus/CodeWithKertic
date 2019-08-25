using System;

namespace CodeWithKertic
{
    public static class QuestionOne
    {
        public static void Ask()
        {
            string userInput;
            string stringVal;
            int intVal;

            Console.WriteLine("what is 2 + 2? ?");

            Console.Write("Enter integer value: ");
            userInput = Console.ReadLine();
            intVal = Convert.ToInt32(userInput);
            stringVal = userInput;
            Console.WriteLine("You entered {0}", intVal);

            /* Tell them if they got it right */
            if (stringVal == "4")
            {
                CorrectAnswer.Achieved();
            }
            else
            {
                Test.Summat();
                IncorrectAnswer.TryAgain();
            }
            

        }

    }

}
 