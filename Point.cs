#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Classes
{
    class Point
    {
        private int x, y;
        private static int objectCount = 0;

        public Point()
        {
            this.x = -1;
            this.y = -2;
            Console.WriteLine("default constructor");
            objectCount++;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            objectCount++;  
            Console.WriteLine($"x:{x}, y:{y}");
        }
        public double DistanceTo(Point other)
        {
            
            int xDiff = this.x - other.x;
            int yDiff = this.y - other.y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            Console.WriteLine($"the distance is {distance}");
            return distance;
            
        }
        public static int ObjectCount()
        {
           return(objectCount);
        }
    }
}
