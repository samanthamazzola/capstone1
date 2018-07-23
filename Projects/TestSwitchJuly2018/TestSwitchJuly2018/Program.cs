using System;

namespace TestSwitchJuly2018
    {
        class MainClass
        {
            public static void Main(string[] args)
            {
                //build a program for a small shop. program will have a menu and it will ask the user for input for selection
                //think of this like a vending machine and selection options
                //input using switch statement

                //show the menu
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Welcome to GC Shop!");
                Console.WriteLine("Please select an option: ");
                Console.WriteLine("1: Coke ");
                Console.WriteLine("2: Snickers ");
                Console.WriteLine("3: Twix ");
                Console.WriteLine("4: Sour Patch Kids ");

                //user input based off the menu in a select statement; variable is selection 
                //user inputs a number like on a vending machine 
                int selection = int.Parse(Console.ReadLine());
                //switch statement OR you could use a number of if statements or else ifs BUT use switch
                switch (selection)
                {
                    //keyword in swith statement is case
                    case 1: //if (selection == 1)
                    //Second level of selection (can do if statement nested, else if nested, or switch nested)
                    Console.WriteLine("Make a selection: ");
                    Console.WriteLine("1. Coke Original ");
                    Console.WriteLine("2. Cherry Coke ");
                    int flavorSelection = int.Parse(Console.ReadLine());

                    if (flavorSelection == 1)
                    {
                        Console.WriteLine("Enjoy your Coke Original.");
                    }
                    else if (flavorSelection == 2)
                    {
                        Console.WriteLine("Enjoy your Cherry Coke!");
                    }
                    else{
                        Console.WriteLine("Sorry wrong selection!");
                    }
                    //don't need curly braces; cases can have multiple statements in one case
                    break; //this is needed after every if this evaluates then it will stop running 
                    case 2:
                        Console.WriteLine("You're not yourself when you're hungry. Enjoy your Snickers!");
                        break;
                    case 3:
                        Console.WriteLine("Can't go wrong with a Twix!!");
                        break;
                    case 4:
                        Console.WriteLine("First they're sour, then they're sweet. Enjoy your Sour Patch Kids.");
                        break;
                    default:
                        Console.WriteLine("Sorry! Please choose a valid option.");
                        break;
                }
            }
        }
    }

/*
  //keyword in swith statement is case
                    case 1: //if (selection == 1)
                        Console.WriteLine("Coke is good! Here you go.");
                        //don't need curly braces; cases can have multiple statements in one case
                        break; //this is needed after every if this evaluates then it will stop running 
                    case 2:
                        Console.WriteLine("Coke is good! Here you go.");
                        break;
                    case 3:
                        Console.WriteLine("You're not yourself when you're hungry. Enjoy!");
                        break;
                    case 4:
                        Console.WriteLine("First they're sour, then they're sweet.");
                        break;
                    default:
                        Console.WriteLine("Sorry! Please choose a valid option.");
                        break;
                        // classic Console.Beep();
                        //star wars beep
                        /*Console.Beep(300, 500);
                        Thread.Sleep(50);
                        Console.Beep(300, 500);
                        Thread.Sleep(50);
                        Console.Beep(300, 500);
                        Thread.Sleep(50);
                        Console.Beep(250, 500);
                        Thread.Sleep(50);
                        Console.Beep(350, 250);
                        Console.Beep(300, 500);
                        Thread.Sleep(50);
                        Console.Beep(250, 500);
                        Thread.Sleep(50);
                        Console.Beep(350, 250);
                        Console.Beep(300, 500);
                        Thread.Sleep(50);*/
