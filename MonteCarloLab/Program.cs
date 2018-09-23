using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloLab
{
    // create struct that takes an x and y coordinate
    // x and y coordinates should be doubles
    
    struct Coordinate
    {
        public double x;
        public double y;

        public Coordinate(Random Rnd)
        {
            this.x = Rnd.NextDouble();
            this.y = Rnd.NextDouble();
        }


    }

    class Program
    {

        public static double Hypotenuse(Coordinate point)
        {
            double hypot = Math.Sqrt((Math.Pow(point.x, 2) + Math.Pow(point.y, 2)));
            return hypot;
        }
        // build main method which takes one int parameter from the command line and creates arr
        // of that length containing random coords
        static void Main(string[] args)
        {
            int coords = 0;
            Random Rnd = new Random();


            do
            {
                double points = 0.0;
                //allows user to input number of points wanted to use
                Console.WriteLine("Please enter the amount of points you would like to check:");
                coords = int.Parse(Console.ReadLine());
                


               ;


            //creates and gives user random value
            Coordinate[] coordinates = new Coordinate[coords];
                for (int i = 0; i < coordinates.Length; i++)
                {
                    coordinates[i] = new Coordinate(Rnd);
                }
                //puts random value into equation
                for (int i = 0; i < coordinates.Length; i++)
                {
                    if (Hypotenuse(coordinates[i]) <= 1)
                    {
                        points++;
                    }
                }
               
                double overlap = points / coordinates.Length;
                overlap *= 4;
                Console.WriteLine($"{overlap}");
                Console.WriteLine(Math.PI);
                Console.WriteLine($"The difference is: {Math.Abs(overlap - Math.PI)}");
                Console.ReadLine();

            } while (coords != 0);

           
        }


    }
}
