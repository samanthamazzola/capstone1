using System;

namespace TestSelectionStatementsJuly2018
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //input for driving example with 3 conditions; else if statment
            Console.WriteLine("Please enter your age: ");
            int ageInput = int.Parse(Console.ReadLine());

            //processing two conditions
            if (ageInput >= 18)
            {
                Console.WriteLine("You can drive a car. ");
            }
            //build condition based off of if false in a nested if statement (which also must have an else)
            else if (ageInput >= 16)
            {
                Console.WriteLine("Yes, but must have someone with a valid driver's license beside you. ");
            }
            else
            {
                Console.WriteLine("Sorry you're underage. ");
            }
        }
    }
}


/*buying alcohol if statement with two conditions
 //input
            Console.WriteLine("Please enter your age: ");
            int ageInput = int.Parse(Console.ReadLine());

            //processing two conditions
            if (ageInput >= 21)
            {
                Console.WriteLine("You can buy alcohol! ");
            }
            else
            {
                Console.WriteLine("Sorry you're underage. ");
            }*/

/*
 * //input for driving example with 3 conditions; nested if statement
            Console.WriteLine("Please enter your age: ");
            int ageInput = int.Parse(Console.ReadLine());

            //processing two conditions
            if (ageInput >= 18)
            {
                Console.WriteLine("You can drive a car. ");
            }
            else
            {
                //build condition based off of if false in a nested if statement (which also must have an else)
                if (ageInput >= 16)
                {
                    Console.WriteLine("Yes, but must have someone with a valid driver's license beside you. ");
                }
                else
                {
                    Console.WriteLine("Sorry you're underage. ");
                }*/