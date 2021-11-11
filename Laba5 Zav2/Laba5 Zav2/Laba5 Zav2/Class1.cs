using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab5Zav2
{
    class Cone
    {
        public static Point point = new Point();
        public static double S, Pi = 3.14, V, r, h, R; 
        public static int input = 0;
        public Cone()
        {
            if (input == 1)
            {
                SquareCone();
                VCone();
            }
        }
        private void SquareCone()
        {
            S = Pi * point.X * point.X;
            Console.WriteLine("Площа: " + S);
        }
        private void VCone()
        {
            V = S * point.Y / 3;
            Console.WriteLine("Об'єм: " + V);
        }
        public static void Input()
        {
            Console.WriteLine("Введіть радіус основи конуса: ");
            point.X = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть висоту конуса: ");
            point.Y = int.Parse(Console.ReadLine());
            Console.WriteLine("Радіус конуса: " + point.X);
            Console.WriteLine("Висота конуса: " + point.Y);
        }
    }
}
