﻿using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer, oddEven;
            string more, name;

            Console.WriteLine("Hello, what is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + ", Please give me a number between 1 and 100");

            bool realNumber = Int32.TryParse(Console.ReadLine(), out integer);
            while (realNumber == false || integer > 99 || integer < 2)
            {
                Console.WriteLine("Okay... Here's the problem, " + name + ". I need a NUMBER, between 1 and 100...");
                Console.WriteLine("I'll give you another chance. Give me a number between 1 and 100.");
                realNumber = Int32.TryParse(Console.ReadLine(), out integer);
                if (realNumber == true && integer > 1 && integer < 100)
                {
                    continue;
                }
            }

            oddEven = integer % 2;


            if (oddEven == 1 && integer > 60)
            {
                Console.WriteLine(integer + "... that's Odd and over 60, " + name);
            }
            else if (oddEven == 1)
            {
                Console.WriteLine(integer + "... that's Odd");
            }
            else if (oddEven == 0 && integer < 26)
            {
                Console.WriteLine("That is even and less than 25, " + name);
            }
            else if (oddEven == 0 && integer > 25 && integer < 61)
            {
                Console.WriteLine("That's even, " + name);
            }
            else if (oddEven == 0 && integer > 60)
            {
                Console.WriteLine(integer + "... that's Even and over 60, " + name);
            }
            else
            {
                Console.WriteLine("I'm Confused");
            }

            Console.WriteLine("Would you like to continue, " + name + "? y/n");
            more = Console.ReadLine().ToUpper();

            while (more == "Y" || more == "YES")
            {


                Console.WriteLine("Please give me a number between 1 and 100");
                realNumber = Int32.TryParse(Console.ReadLine(), out integer);
                while (realNumber == false || integer > 99 || integer < 2)
                {
                    Console.WriteLine("Okay... Here's the problem, " + name + ". I need a NUMBER, between 1 and 100...");
                    Console.WriteLine("I'll give you another chance. Give me a number between 1 and 100.");
                    realNumber = Int32.TryParse(Console.ReadLine(), out integer);
                    if (realNumber == true && integer > 1 && integer < 100)
                    {
                        continue;
                    }
                }
                oddEven = integer % 2;

                if (oddEven == 1 && integer > 60)
                {
                    Console.WriteLine(integer + "... that's Odd and over 60, " + name);
                }
                else if (oddEven == 1)
                {
                    Console.WriteLine(integer + "... that's Odd");
                }
                else if (oddEven == 0 && integer < 26)
                {
                    Console.WriteLine("That is even and less than 25, " + name);
                }
                else if (oddEven == 0 && integer > 25 && integer < 61)
                {
                    Console.WriteLine("That's even, " + name);
                }
                else if (oddEven == 0 && integer > 60)
                {
                    Console.WriteLine(integer + "... that's Even and over 60, " + name);
                }
                else
                {
                    Console.WriteLine("I'm Confused");
                }

                Console.WriteLine("Would you like to continue? y/n");
                more = Console.ReadLine().ToUpper();
                if (more == "N" || more == "NO")
                {
                    break;
                }

            }
            if (more != "Y" && more != "YES" && more != "N" && more != "NO")
            {
                Console.WriteLine("Seriously, " + name + "!!! How am I supposed to understand that? I give up!!!");
            }

            Console.WriteLine("Goodbye");
        }

    }
}
