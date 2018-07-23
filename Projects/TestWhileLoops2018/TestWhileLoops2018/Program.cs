using System;

namespace TestWhileLoops2018
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //using while loops to do validation
            Console.WriteLine("Write a whole integer from 1 - 100");
            int userInput = int.Parse(Console.ReadLine());

            //write a while loop to chekc if a number is from 1 - 100

            /*OR can do it this way!
             * while (!(userInput >= 1 && userInput <= 100))
             * {
             * CWL
             * }*/

            while (userInput < 0 || userInput > 100) //while the number is out of range, ask the user for a new number
            {
                Console.WriteLine("Sorry you're out of range. Try a new number!");
                userInput = int.Parse(Console.ReadLine());
            }
        }
    }
}


/*
 //BOTH EXECUTE THE SAME THING.based off user input(y/n) in either DO WHILE or WHILE
                              
            //WHILE 
            //ask a validation question 
            string userResponse = "y"; //already saying that user choice is equal to y
            while (userResponse.ToLower() == "y") 
            {
                //body of code
                //want to run the code at least once then at the end ask a question to run again
                Console.WriteLine("Hi C# class!");
                //want this code to repeat how ever many times the user wants; use WHILE loop
                //input
                Console.WriteLine("Do you want to continue? Choose (y/n)"); //need user validation
                userResponse = Console.ReadLine();
                //run code as long as the user says y; break when n
            } 
            while (userResponse.ToLower() == "n")
            {
                Console.WriteLine("Sorry to see you go!");
                break; //stops loop from continuing 
            }  

 */


/*
//DO WHILE 
//ask a validation question 
string userResponse; //have to define variable outside of the loop. if you want variables to be shown outside of the "car" they need to be defined outside of that code
            do
            {
                //body of code
                //want to run the code at least once then at the end ask a question to run again
                Console.WriteLine("Hi C# class!");
                //want this code to repeat how ever many times the user wants; use WHILE loop
                //input
                Console.WriteLine("Do you want to continue? Choose (y/n)"); //need user validation
                userResponse = Console.ReadLine();
                //run code as long as the user says y; break when n
            } 
            while (userResponse.ToLower()=="y");
            while (userResponse.ToLower() == "n")
            {
                Console.WriteLine("Sorry to see you go!");
                break;
            }
*/