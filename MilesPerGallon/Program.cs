using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            double milesDriven;
            double gasGallons;
            string inputM;
            string inputG;
            
                       
            Console.WriteLine("How many miles have you driven?");
            inputM = Console.ReadLine();
            milesDriven = double.Parse(inputM);

            Console.WriteLine("How many gallons of gas have you used?");
            inputG = Console.ReadLine();
            gasGallons = double.Parse(inputG);

            Console.WriteLine("Your miles per gallon is " + milesDriven / gasGallons + ".");
            

        }
    }
}
