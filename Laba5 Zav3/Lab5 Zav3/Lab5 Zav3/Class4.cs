using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorna5Work3
{
    class UPMatrix : Matrix
    {
        public UPMatrix()
        {
            Inputter();
        }
        public void Inputter()
        {
            Console.WriteLine("Виберіть спосіб підрахунку визначника матриці: ");
            Console.WriteLine("Введіть - 1 - для метода трикутника, введіть - 2 - для метода Сарюсса");
            input = int.Parse(Console.ReadLine());
        }
    }
}

