using System;

namespace TestStringsJuly2018
{
    class MainClass
    {
        public static void Main(string[] args)
        {
          
            string str = "Hello";
                
            string str3 = "Please do not cross the street from this point!";

            Console.WriteLine(str3.IndexOf("not")); //prints 10
            Console.WriteLine(str3.IndexOf("Hello")); //prints -1 bc it doesn't exist
            Console.WriteLine(str.Contains("Hello")); //false
            Console.WriteLine(str3.Substring(3, 5)); // prints 'ase d'
            Console.WriteLine(str3.Substring(0, 6)); // prints 'Please'
            Console.WriteLine(str3.Substring(6)); // prints ' do not cross the street at this point'
            Console.WriteLine(str3.Replace("do not", "don't")); // will change all of the 'do not' to 'don't'... only a temp change

            //like the above replace but this version will permanently change it
            str3 = str3.Replace("do not", "don't");
            Console.WriteLine(str3);
            //str[0] = 'p'; and can't be done because strings are immutable and you'll run out of memory 




            /*
             FOR loops and Strings work well together 
             string str = "hello";
            for (int i = 0; i <= (str.Length-1); i++) 
            {
                Console.WriteLine(str[i]);
            }*/






            /*string str = "Hello";

            Console.WriteLine(str[0]); //will only print the first value in the index from str which is H*/



            /*string str2 = new string('*', 10); //prints 10 times

            Console.WriteLine(str2);

            for (int i = 1; i <= 10; i++) //loops into a triangle 
            {
                string s = new string('*', i); //prints as many places as i value??
                Console.WriteLine(s);
            }*/
        }
    }
}
