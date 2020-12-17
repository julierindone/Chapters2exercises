using System;

namespace _2._5._2_area_of_rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            int width;
            string inputL;
            string inputW;

            Console.WriteLine("Enter the rectangle's length: ");
            inputL = Console.ReadLine();
            length = int.Parse(inputL);
            Console.WriteLine("Enter the rectangle's width: ");
            inputW = Console.ReadLine();
            width = int.Parse(inputW);
            Console.WriteLine("The area of your rectangle is " + (length * width) + ".");
        }

    }
}
