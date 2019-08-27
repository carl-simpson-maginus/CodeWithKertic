using System;
namespace CodeWithKertic
{
    public class RandomNumber
    {
        public static void GenerateNumber()
        {
            string Response;

            Random randm = new Random();
            int rand_dice = randm.Next(1, 7);

            Console.WriteLine("Choose Between 1-6");
            Response = Console.ReadLine();

            if (Response == rand_dice.ToString())
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Try Again");
            }

        }
    }
}
