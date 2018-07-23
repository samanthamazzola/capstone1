using System;

namespace TestForLoopsJuly2018
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //NESTED LOOPS
            for (int i = 1; i <= 10; i++) //rows
            {
                for (int j = 1; j <= 10; j++) //columns
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
        }
    }
}

/*
 //FOR LOOP printing even values 2 ways
//user input print even numbers between 
            Console.WriteLine("Please write a whole number from 1-100: ");
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                /* OR 
                 for (int i = 2; i <= 100; i +=2)
                 {
                    Console.WriteLine(i);
                 }
   */

    //FOR LOOP printing
/*
            //print numbers from 1 to 15; ascending
            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine(i);
            }
            //print numbers between 30 and 20 descending
            for (int i = 30; i >= 20; i --)
            {
                Console.WriteLine(i);
            }
            //input from the user
            Console.WriteLine("Please write how many times you want the computer to say Hello!");
            int input = int.Parse(Console.ReadLine());
            //start: input, end: 1; step: -- 
            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine("Hello!");
            }
            //start: 1; end: input; step: ++ 
            for (int i = input; i >= 1; i--)
            {
                Console.WriteLine("Hello!");
            }
            */
