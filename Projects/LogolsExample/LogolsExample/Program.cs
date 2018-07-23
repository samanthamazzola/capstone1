using System;

namespace Capstone1PigLatin
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //string vowels = "aeiou";
            string myWord;
            string answer;

            // do while loop because you want it to run at least once then check the condition 
            do
            {
                // prompt
                Console.WriteLine("Welcome to the Pig Latin Translator!");
                Console.WriteLine("Enter a line to be translated: ");
                myWord = Console.ReadLine();
                Translate(myWord);


                // validation
                Console.WriteLine("Do you want to try another word? Choose (y/n)");
                answer = Console.ReadLine();
            } while (answer == "y");
        }
        // converts my string input into separate charachters/array; checks all index of my input/myWord for vowels
        // two conditions depending on my 0 index 
        // new method that will call to the main method and loop through depending on choice 

        public static void Translate(string myWord)
        {
            string newWord;
            if ((myWord.IndexOfAny("aeiou".ToCharArray()) == 0))
            {
                newWord = myWord + "way";
                Console.WriteLine(newWord.ToLower());
            }
            // does not have a vowel in the 0 index place value 
            else if ((myWord.IndexOfAny("aeiou".ToCharArray()) != 0))
            {
                newWord = myWord + "ay";
                Console.WriteLine(newWord.ToLower());
            }
        }
    }
}



