using System;

namespace TestMethodsJuly2018
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //write a method that reads and returns an integer! The method will take the prompt as input.. and read as below
            //int x = ReadInteger("Please enter a number");
            //and int y = ReadInteger("Please enter another integer");
            //take a string return as int in a new method


            //ints are x and y
            Console.WriteLine("Please enter a number: ");
            int x = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Please enter another number: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine(Sum(x, y));

            Console.WriteLine("Bye Bye!");
        }

        //new method that refers back to the main method
        //outside the main
        //class accessibility|returntype|methodname|params
        //calls back to the main
        static int Sum(int number1, int number2)
        {
            //ints are number1 and number2
            int result = number1 + number2;

            return result;
        }
    }
}
