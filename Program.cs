using System;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {

                    Random r = new Random();
        int sum = 0;
        int count = 10;

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Press any key to roll the dice.");

            Console.ReadKey();

            var newNum = r.Next(1, 7);

            Console.WriteLine(newNum.ToString());



            sum += newNum;


        };

        int avg = (int)sum / count;
        
        Console.WriteLine("The average is: {0}", avg);
        Console.WriteLine("The total is " + sum);
        }
    }
}
