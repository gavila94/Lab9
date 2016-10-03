using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_New
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Circle Tester\n");

            string repeat = "";
            do
            {
                string inputdata = "";
                double radiusOfCircle = 0;

                
                {
                    Console.Write("Enter Radius:\n ");
                    inputdata = Console.ReadLine();
                   

                } 


                Circle circleRadiusCircumference = new Circle(radiusOfCircle);

                Console.WriteLine($"Circumference: {circleRadiusCircumference.getFormattedCircumference()}");

                Console.WriteLine($"Area: {circleRadiusCircumference.getFormattedArea()}");


                Console.Write("Do you want to Continue?(y/n)\n");
                repeat = Console.ReadLine().Trim().ToLower();
            } while (repeat == "y");

            Console.WriteLine($"Goodbye. You created {Circle.getObjectCount()} Circle Object(s).\n ");

        }
    }
}
