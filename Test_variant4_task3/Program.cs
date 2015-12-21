using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_variant4_task3
{
    class Program
    {
        //Вычислить функию y = (4*a*x^2 + 3.7*x + b) / (x - 0.5)
        static void Main(string[] args)
        {
            double[] a = new double[] { 1, 1.5, 2 };
            double[] x = new double[] {0, 0.2, 0.4, 0.6, 0.8, 1};
            double b = 1.2;
            double y;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < x.Length; j++)
                {
                    y = (4*a[i]*x[j]*x[j] + 3.7*x[j] + b)/(x[j] - 0.5);
                    Console.WriteLine("y for a = " + a[i] + " and x = " + x[j] + " equals " + y);
                }
            }
            Console.ReadKey();           
        }
    }
}
