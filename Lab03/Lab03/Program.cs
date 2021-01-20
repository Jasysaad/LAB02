using System;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter a number from 1-100: ");
            double number = double.Parse(Console.ReadLine()); //converts string to double for math operators
            double remainder = number % 2;
            
            if (number>1 && number<100) //verifies number is within range
                {
                if (remainder == 0) //checks remainder is 0 indicating even
                {
                    if (2 < number && number > 25) //checks if number falls within 1-25
                    {
                        Console.Write(name +", your number is even and less than 25");
                    }
                    else
                    {
                        Console.Write(name + ", your number is " + number + " and even");

                    }
                }
                else //if number is odd
                {
                    Console.WriteLine(name +", your number is "+ number + " and odd");
                }

            }
        }
            
    }
}
