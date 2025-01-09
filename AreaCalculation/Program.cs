using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int shortEdge, longEdge, area, environment;
            Console.WriteLine("Please Enter The Short Edge: ");
            shortEdge= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter The Long Edge: ");
            longEdge= Convert.ToInt32(Console.ReadLine());
            area = shortEdge * longEdge;
            environment = 2 * (shortEdge + longEdge);
            Console.WriteLine("Area: "+ area);
            Console.WriteLine("Environment: " + environment);
            Console.ReadKey();

        }
    }
}
