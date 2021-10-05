using System;

namespace Room
{
    internal class Program

    {
        private static void Main(string[] args)
        {
            {
                rooms();
                Console.ReadLine();
            }
        }

        private static void rooms()

        {
            double length;
            double width;

            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");
            Console.WriteLine(" ");

            Console.WriteLine("Enter the length of the room: ");
            length = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine("Enter the width of the room: ");
            width = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            double area = length * width;
            double perimeter = 2 * (length + width);
            double carpet = area / 5;
            double paint = perimeter / 5;

            Console.WriteLine("Area: " + area + "\nPerimeter: " + perimeter + "\nCarpet Tiles: " + carpet + "\nPaint:  " + paint);

            string input2;

            Console.WriteLine(" ");
            Console.WriteLine("Do you want to know the volume for this room? Enter: yes or no: ");
            input2 = Console.ReadLine();
            if (input2 == "no")
            {
                Console.WriteLine(" ");
                Console.WriteLine("Do you want to want to measure another room? Yes or No: ");
                string answer1 = Console.ReadLine();
                if (answer1 == "yes") { rooms(); }
                else
                { Console.WriteLine("Thanks for stoping by!"); };
            }
            else if (input2 == "yes")
            {
                double height;
                Console.WriteLine(" ");
                Console.WriteLine("Enter the height of the room: ");
                height = double.Parse(Console.ReadLine());

                double volume = length * width * height;
                Console.WriteLine(" ");
                Console.WriteLine("Volume: " + volume);

                Console.WriteLine(" ");
                Console.WriteLine("Do you want to want to measure another room? Yes or No: ");
                string answer3 = Console.ReadLine();
                if (answer3 == "yes") { rooms(); }
                else
                { Console.WriteLine("Thanks for stoping by!"); };
            }
        }
    }
}