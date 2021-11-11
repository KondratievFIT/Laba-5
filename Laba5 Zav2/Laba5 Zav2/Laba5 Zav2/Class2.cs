using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Zav2
{
    class Conoid : Cone
    {
        public Conoid()
        {
            VConoid();
        }
        private void VConoid()
        {
            V = Pi * h * (Math.Pow(R, 2) + R * r + Math.Pow(r, 2) / 3);
            Console.WriteLine("Об'єм зрізаного конуса: " + V);
        }
        public static void Input1()
        {
            Console.WriteLine("Введіть висоту конуса: ");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть радіус більшої основи конуса: ");
            R = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите радіус меньшої основы конуса: ");
            r = double.Parse(Console.ReadLine());
            Console.WriteLine("Висота конуса: " + h);
            Console.WriteLine("Радіус більшої основы: " + R);
            Console.WriteLine("Радиус меньшої основы: " + r);
        }
    }
}