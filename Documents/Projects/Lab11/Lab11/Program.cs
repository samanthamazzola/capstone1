using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates a list
            List<Movie> Vault = new List<Movie>(10);

            //creates an object Movie
            Movie temp = new Movie();
            temp.Category = "horror";
            temp.Title = "IT";
            Vault.Add(temp);

            temp = new Movie();
            temp.Category = "horror";
            temp.Title = "Friday the 13th";
            Vault.Add(temp);

            temp = new Movie();
            temp.Category = "animated";
            temp.Title = "Finding Nemo";
            Vault.Add(temp);

            temp = new Movie();
            temp.Category = "animated";
            temp.Title = "Toy Story";
            Vault.Add(temp);

            temp = new Movie();
            temp.Category = "animated";
            temp.Title = "UP";
            Vault.Add(temp);

            temp = new Movie();
            temp.Category = "horror";
            temp.Title = "Halloween";
            Vault.Add(temp);

            temp = new Movie();
            temp.Category = "drama";
            temp.Title = "The Help";
            Vault.Add(temp);

            temp = new Movie();
            temp.Category = "drama";
            temp.Title = "Titanic";
            Vault.Add(temp);

            temp = new Movie();
            temp.Category = "drama";
            temp.Title = "Fight Club";
            Vault.Add(temp);

            temp = new Movie();
            temp.Category = "scifi";
            temp.Title = "Hackers";
            Vault.Add(temp);

            temp = new Movie();
            temp.Category = "scifi";
            temp.Title = "Minority Report";
            Vault.Add(temp);

            Console.WriteLine("Welcome to the GC Movie vault!");
            Console.Write("Please enter one of the following categories: Horror, Drama, Animated, Scifi: ");
            string userChoice = Console.ReadLine().ToLower();

            foreach (Movie m in Vault)
            {
                if(userChoice == m.Category.ToLower())
                {
                    Console.WriteLine(m.Title);
                }
            }
                
                      
        }
    }
}
