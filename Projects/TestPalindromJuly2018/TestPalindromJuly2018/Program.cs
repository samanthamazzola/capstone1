using System;

namespace TestPalindromJuly2018
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
             input = kayak
             reverse = kayak
             for:
             start: 4
             end: 0
             step = -1 (and reverse)
             */
            Console.WriteLine("Check to see if your word is a palindrome!");
            Console.Write("Enter your word: ");
            string input = Console.ReadLine();
            //can put sting in ToLower or ToUpper


      
            string reverse = "";//empty string....exm: there is something there but no specific value
            //string reverse; //not initialized and won't run bc no value...... exm: there is nothing there at all

            //or can build a string and reverse and compare by each index individually

            for (int i = input.Length - 1; i >= 0; i--) //index
            {
                //build reverse string 
                reverse = reverse + input[i]; //concatonate //need to initialize the 'reverse' variable so 
            }

            if (input.ToLower() == reverse.ToLower())
            {
                Console.WriteLine("Your input is a palindrome!");
            }
            else
            {
                Console.WriteLine("Your input is not a palindrome :(");

            }
        }
    }
}
