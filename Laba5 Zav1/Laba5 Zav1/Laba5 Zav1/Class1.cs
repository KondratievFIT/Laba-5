using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab5Zav1
{
    class SquareMove
    {
        public static int x, y;
        public static int length, RemoveOrRotate;
        public static Rectangle res = new Rectangle();
        public static Point lUp = new Point();
        public static Point lDown = new Point();
        public static Point rUp = new Point();
        public static Point rDown = new Point();
        public SquareMove()
        {
            if (RemoveOrRotate == 1)
            {
                RectangleInfo();
                Console.WriteLine("Нажмите стрелку вправо - чтобы передвинуть квадрат вправо, или стрелку влево - чтобы передвинуть влево");
            }
            while (RemoveOrRotate == 1)
            {
                string button = Convert.ToString(Console.ReadKey().Key);
                if (button == "RightArrow")
                {
                    lUp.X++;
                    lDown.X++;
                    rUp.X++;
                    rDown.X++;
                    Display();
                }
                else if (button == "LeftArrow")
                {
                    Move();
                }
            }
        }
        public static void Input()
        {
            Console.WriteLine("Введіть верхній лівий кут(координати), и його довжину");
            Console.WriteLine("X: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Y: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Довжина: ");
            length = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть 1, для пересування квадрату, введіть 2, для обертання");
            RemoveOrRotate = int.Parse(Console.ReadLine());
        }
        private void Move()
        {
            lUp.X--;
            lDown.X--;
            rUp.X--;
            rDown.X--;
            Display();
        }
        protected void RectangleInfo()
        {
            lUp.X = x;
            lUp.Y = y;
            lDown.X = x;
            lDown.Y = y - length;
            rUp.X = x + length;
            rUp.Y = y;
            rDown.X = x + length;
            rDown.Y = y - length;
            res.X = lUp.X;
            res.Y = lUp.Y;
            res.Width = length;
            res.Height = length;
            Display();
            Console.WriteLine("Параметри квадрата: " + res);
        }
        protected void Display()
        {
            Console.WriteLine('-');
            Console.WriteLine("Координати верхнього лівого кута: " + lUp);
            Console.WriteLine("Координати нижнього лівого кута: " + lDown);
            Console.WriteLine("Координати верхнього правого кута: " + rUp);
            Console.WriteLine("Координати нижнього правого кута: " + rDown);
            Console.WriteLine('-');
        }
    }
}
