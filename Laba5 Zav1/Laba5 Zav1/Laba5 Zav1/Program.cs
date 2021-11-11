using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Zav1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            SquareMove.Input();
            SquareMove Move = new SquareMove();
            SquareRotation Rotate = new SquareRotation();
        }
    }
}
