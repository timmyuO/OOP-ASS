using System;

namespace TheOOPAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("enter length of polygon sides");
            double l = double.Parse(Console.ReadLine());                /*length*/

            Console.WriteLine("enter number of sides");
            double s = double.Parse(Console.ReadLine());                /*side*/

            Console.WriteLine("enter apothem of polygon");
            double a = double.Parse(Console.ReadLine());                /*apothem*/

            PolygonCalc calc = new PolygonCalc();
            Console.WriteLine("the polygon's perimeter is: " + calc.perimeterCalc(l, s));

            Console.WriteLine("the area of the polygon without the apothem is: " + calc.AreaCalc(l));

            Console.WriteLine("the area of the polygon is: " + calc.AreaCalc(l, s, a));
        }
    }

    public interface IRegularPolygon                                            /*Interface*/
    {
        double perimeterCalc(double length, double sides);

        double AreaCalc(double length, double sides, double apothem);
    }

    public class PolygonCalc : IRegularPolygon                          /* abstraction/inheritance */
    {

        public double length { get { return length; } set { length = value; } }

        public double sides { get { return sides; } set { sides = value; } }

        public double apothem { get { return apothem; } set { apothem = value; } }       /*Encapsulation*/

        public double perimeterCalc(double length, double sides)
        {
            double perimeter = length * sides;
            return perimeter;
        }

        public double AreaCalc(double length, double sides, double apothem)
        {
            double area = 0.5 * length * sides * apothem;
            return area;
        }

        public float AreaCalc(double length)                                /*Polymorphism*/
        {

            float areaWithoutApothem = (float)(length * length);
            return areaWithoutApothem;
        }
    }
}
