using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Zav2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть -'1' для розрахунку конуса та -'2' для усеченного");
            Cone.input = int.Parse(Console.ReadLine());
            if (Cone.input == 1)
            {
                Cone.Input();
                Cone cone = new Cone();
            }
            else if (Cone.input == 2)
            {
                Conoid.Input1();
                Conoid conoid = new Conoid();
            }
        }
    }
}
