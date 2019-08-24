using System;
namespace CodeWithKertic
{
    public class RandomNumber
    {
        public static void GenerateNumber()
        {
            string Response;
            int count = 0; 

            Random randm = new Random();
            int rand_month = randm.Next(1, 13);
            int rand_dice = randm.Next(1, 7);
            int rand_card_value = randm.Next(52);

            Console.WriteLine("Choose Between 1-6");
            Response = Console.ReadLine();

            if (Response == rand_dice.ToString())
            {
                Console.WriteLine("fuck me ");
            }
            else
            {
                Console.WriteLine("Try Agian");
            }

        }
    }
}
