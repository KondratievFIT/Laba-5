using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab5Zav1
{
    class SquareRotation : SquareMove
    {
        public static Point q = new Point();
        public SquareRotation()
        {
            if (RemoveOrRotate == 2)
            {
                RectangleInfo();
                Console.WriteLine("Натисніть стрілку вправо для того щоб перевернути квадрат праворуч, або стрілку вліво для того щоб перевернуть влево");
            }
            while (RemoveOrRotate == 2)
            {
                string button = Convert.ToString(Console.ReadKey().Key);
                if (button == "RightArrow")
                {
                    q = lUp;
                    lUp = lDown;
                    lDown = rDown;
                    rDown = rUp;
                    rUp = q;
                    Display();
                }
                else if (button == "LeftArrow")
                {
                    q = lDown;
                    lDown = lUp;
                    lUp = rUp;
                    rUp = rDown;
                    rDown = q;
                    Display();
                }
            }
        }
    }
}