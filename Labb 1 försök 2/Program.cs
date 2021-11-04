using System;

namespace Labb_1_försök_2
{
    public class Circle
    {
        private int _radius;
        public Circle(int radius)      
        {
            _radius = radius;
        }
        public float _pi = 3.141f;

        public double getArea()
        {

            double area;
            area = _radius * _radius * _pi;
            return area;
        }
        public double getOmkrets()
        {

            double omkrets;
            omkrets = (_radius + _radius) * _pi;
            return omkrets;
        }
        public double getVolym()
        {

            double volym;
            volym = (4 * _pi * _radius * _radius * _radius) / 3;
            return volym;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);

            Circle c2 = new Circle(6);


            Console.WriteLine("Cirkel med radius 5 har arean {0}, omkrets {1} och som sfär volymen: {2}", Math.Round(c1.getArea(), 2), Math.Round(c1.getOmkrets(), 2), Math.Round(c1.getVolym(), 2));
            Console.WriteLine("Cirkel med radius 6 har arena {0}, omkrets {1} och som sfär volymen: {2}", Math.Round(c2.getArea(), 2), Math.Round(c2.getOmkrets(), 2), Math.Round(c2.getVolym(), 2));
           
        }
    }
}
