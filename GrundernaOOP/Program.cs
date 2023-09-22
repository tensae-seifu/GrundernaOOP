using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Grunderna_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Circle cir = new Circle(5);//initializing a new object frothe class circle and passing the rad variable as a aparameter

            cir.GetCircumference(5); //calling the method to get the Cicumference

            cir.GetVolume(5);

            Triangle tri = new Triangle(6, 5); //instansiate a new abojet from the triangle class


            //display the result using the methods 

            Console.WriteLine($"The area of a circle with Radious 5 is:{cir.GetArea(5)}\n");

            Console.WriteLine($"The area of a circle with Radious 6 is:{cir.GetArea(6)}\n");


            Console.WriteLine($"The area of a Triangle with base 6 and a height 5 is:{tri.GetArea(6, 5)}\n");

        }
    }
}