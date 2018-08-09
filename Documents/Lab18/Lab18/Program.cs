using System;
using System.Linq;



namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = { 3, 5, 6, 4, 3, 3, 5, 5, 7, 8, 9, 15, 15, 2 }; // array of 14 numbers with a max value of 15
            int[] Array2 = new int[Array1.Max()]; // new array to find the max value in the arry of numbers which is 15. so length max is 15

            // Array.Sort(Array1); //calling the Array class; Sort method to sort values in incrementing order

            for (int i = 0; i < Array1.Length; i++) //i is the value in array1. start at 0 then take each value in the Array1 through loop
            {
                for (int j = 0; j < Array2.Length; j++) //j the values of the new array that is defined with the max value being 15
                {
                    if(Array1[i] == j+1)
                    {
                        Array2[j]++; // every time it loops through it checks the value of i and if j matches, add a count for j
                    }
                }    
            }

            for (int i = 0; i < Array2.Length; i++)
            {
                Console.WriteLine($"The value {i+1} occured {Array2[i]} times");
            }

        }
    }
}
