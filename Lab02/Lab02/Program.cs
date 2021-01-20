using System;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool newroom = true; //initialize bool that will control while loop
            while (newroom == true) 
            {
                Console.WriteLine("Welcome to Jasmine's Room Detail Generator!");
                Console.Write("Enter Room Length: ");
                string inputL = Console.ReadLine();
                double length = double.Parse(inputL); //convert string length into a double, not int for decimal
                Console.Write("Enter Room Width: ");
                string inputW = Console.ReadLine();
                double width = double.Parse(inputW); //convert string width into a double, not int for decimal
                double area = width * length; //area of a rectangular room
                double perimeter = (width + length) * 2; //perimeter of a rectangular room
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.Write("Would you like to calculate volume? (y/n) ");
                string answer = Console.ReadLine();
                if (answer == "y") //volume calculation is optional per user entry
                {
                    Console.Write("Enter Ceiling Height: ");
                    string inputH = Console.ReadLine();
                    double height = double.Parse(inputH); //convert string length into a double, not int for decimal
                    double volume = area * height;
                    Console.WriteLine("Volume: " + volume);

                }
                Console.Write("Continue with a new room? (y/n) "); 
                answer = Console.ReadLine();
                if (answer == "n") //causes loop to exit via bool
                {
                    newroom = false;
                }
            }
            







        }
    }
}
