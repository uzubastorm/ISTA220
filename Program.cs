using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void doWork()
        {
            Point origin = new Point();
            Point bottomRight = new Point(1366, 768);
            Point Ajay = new Point(77, 12);
            double distance = origin.DistanceTo(bottomRight);
            double distance2 = Ajay.DistanceTo(origin);
            int oc = Point.ObjectCount();
            Console.WriteLine($"the object count is {oc}");
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
