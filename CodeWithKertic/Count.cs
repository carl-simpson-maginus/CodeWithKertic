using System;
namespace CodeWithKertic
{
    public class Test
    {

        int count = 0;

        public static void Summat()
        {
            Test test1 = new Test();

            test1.doMethod();

        }

        public void doMethod()
        {

            count++;
            Console.WriteLine("attempts = " + count);
        }
    }
}
