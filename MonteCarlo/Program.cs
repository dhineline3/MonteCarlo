using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo
{

    public struct Coordinate
    {
        private double x, y;

        public double X { get => x; set => x = value; }

        public double Y { get => x; set => x = value; }

        //sets random values to coordinates
        public Coordinate(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Coordinate(Random random)
        {
            this.x = random.NextDouble();
            this.y = random.NextDouble();
        }

        //calculates the hypotenuse from the coordinates
        public double Hypotenuse()
        {
            return Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2));
        }

    }
}
