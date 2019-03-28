using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo
{
    public class TestMonteCarlo
    {
        static void Main(string[] args)
        {
            //Retrieves an int from the console. Ask for the int
            //Build a main method that takes one int parameter from te command line and creates an array of that length containing randomly initialized coordinates
            Console.WriteLine("Enter an integer number: ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            Coordinate[] coordinates = new Coordinate[arrayLength];
            //Iterate over the array, incrementing a counter for each coordinate which overlaps the unit circle.
            Random random = new Random();

            int counter = 0;

            for (int i = 0; i < arrayLength; i++)
            {
                coordinates[i] = new Coordinate(random);
                if(coordinates[i].Hypotenuse() <= 1 )
                {
                    counter++;
                }
            }
            //Using the Length parameter of the array, divide the number of coordinates overlapping the unit circle by the number of the array elements. Multiply the value by 4.
            double avg = (counter / (double)coordinates.Length) * 4;

            //Print the value from step #4 along with the absolute value of the difference between your estimates of pi and Math.PI
            Console.WriteLine($"Total # of points overlapping the circle - {counter}");

            //absolute value of the difference between your estimate of pi and Math.PI
            Console.WriteLine($"generated pi = {avg}, real pi = {Math.PI}, difference = {Math.Abs(Math.PI - avg)}");
            Console.ReadKey();
        }
    }
}
