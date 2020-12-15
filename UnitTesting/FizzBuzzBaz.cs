using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
    public class FizzBuzzBaz
    {
        public static void ThisWontBeFun()
        {
            string fizzBuzzBazSucks = "";
            for (int i = 1; i <= 100; i++)
            {
                if (((i % 3 == 0) || i.ToString().Contains("3"))
                    && !((i % 5 == 0) || i.ToString().Contains("5"))
                    && !((i % 7 == 0) || i.ToString().Contains("7")))
                {
                    fizzBuzzBazSucks += "Fizz, ";
                }
                else if (((i % 5 == 0) || i.ToString().Contains("5"))
                    && !((i % 7 == 0) || i.ToString().Contains("7"))
                    && !((i % 3 == 0) || i.ToString().Contains("3")))
                {
                    fizzBuzzBazSucks += "Buzz, ";
                }
                else if (((i % 7 == 0) || i.ToString().Contains("7"))
                    && !((i % 3 == 0) || i.ToString().Contains("3"))
                    && !((i % 5 == 0) || i.ToString().Contains("5")))
                {
                    fizzBuzzBazSucks += "Baz, ";
                }
                else if (((i % 7 == 0) || i.ToString().Contains("7"))
                    && ((i % 3 == 0) || i.ToString().Contains("3")))

                {
                    fizzBuzzBazSucks += "FizzBaz, ";
                }
                else if (((i % 7 == 0) || i.ToString().Contains("7"))
                    && ((i % 5 == 0) || i.ToString().Contains("5")))
                {
                    fizzBuzzBazSucks += "BuzzBaz, ";
                }
                else if (((i % 3 == 0) || i.ToString().Contains("3"))
                    && ((i % 5 == 0) || i.ToString().Contains("5")))
                {
                    fizzBuzzBazSucks += "FizzBuzzBaz, ";
                }

                else
                {
                    fizzBuzzBazSucks += ($"{i.ToString()}, ");
                }
            }
            Console.WriteLine(fizzBuzzBazSucks);
        }
        public static string TestingSomething(int i)
        {
            string fizzBuzzBazSucks = "";
            
                if (((i % 3 == 0) || i.ToString().Contains("3"))
                    && !((i % 5 == 0) || i.ToString().Contains("5"))
                    && !((i % 7 == 0) || i.ToString().Contains("7")))
                {
                    fizzBuzzBazSucks += "Fizz";
                }
                else if (((i % 5 == 0) || i.ToString().Contains("5"))
                    && !((i % 7 == 0) || i.ToString().Contains("7"))
                    && !((i % 3 == 0) || i.ToString().Contains("3")))
                {
                    fizzBuzzBazSucks += "Buzz";
                }
                else if (((i % 7 == 0) || i.ToString().Contains("7"))
                    && !((i % 3 == 0) || i.ToString().Contains("3"))
                    && !((i % 5 == 0) || i.ToString().Contains("5")))
                {
                    fizzBuzzBazSucks += "Baz";
                }
                else if (((i % 7 == 0) || i.ToString().Contains("7"))
                    && ((i % 3 == 0) || i.ToString().Contains("3")))

                {
                    fizzBuzzBazSucks += "FizzBaz";
                }
                else if (((i % 7 == 0) || i.ToString().Contains("7"))
                    && ((i % 5 == 0) || i.ToString().Contains("5")))
                {
                    fizzBuzzBazSucks += "BuzzBaz";
                }
                else if (((i % 3 == 0) || i.ToString().Contains("3"))
                    && ((i % 5 == 0) || i.ToString().Contains("5")))
                {
                    fizzBuzzBazSucks += "FizzBuzz";
                }
                else if (((i % 3 == 0) || i.ToString().Contains("3"))
                    && ((i % 5 == 0) || i.ToString().Contains("5"))
                    && ((i % 7 == 0) || i.ToString().Contains("7")))
            {
                fizzBuzzBazSucks = "FizzBuzzBaz";
            }

                else
                {
                    fizzBuzzBazSucks += ($"{i.ToString()}");
                }
                return fizzBuzzBazSucks;

        }

    }
}
