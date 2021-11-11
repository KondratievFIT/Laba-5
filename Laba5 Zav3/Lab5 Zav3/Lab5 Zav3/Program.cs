using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorna5Work3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Matrix.InputMatrix();
            Matrix.Operation();
            Matrix matrix = new Matrix();
            if (Matrix.OneCount == 3)
            {
                IdentityMatrix determine = new IdentityMatrix();
                Matrix.Input();
                if (Matrix.input == 1)
                {
                    MethodofTriangle1 Triangle1 = new MethodofTriangle1();
                }
                else if (Matrix.input == 2)
                {
                    RuleofSarrus1 Sarrus1 = new RuleofSarrus1();
                }
            }
            else if (Matrix.ZeroCount == 3)
            {
                UPMatrix Upmatrix = new UPMatrix();
                Matrix.Input();
                if (Matrix.input == 1)
                {
                    MethodofTriangle2 Triangle2 = new MethodofTriangle2();
                }
                else if (Matrix.input == 2)
                {
                    RuleofSarrus2 Sarrus2 = new RuleofSarrus2();
                }
            }
        }
    }
}
