using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }

        static int Area(int h, int w)
        {
            return h * w;
        }

        static int calc(int from, int to, int step = 1)
        {
            int res = 0;
            for (int i = from; i < to; i += step)
            {
                res += i;
            }
            return res;
        }

        // Recursion method

            static int Fact(int sum)
        {
            if (sum == 1)
            {
                return 1;
            }
            return sum * Fact(sum - 1);
        }

        // creating a pyramid

            static void DrawPyramid(int n)
            {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)

                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            }

        static void Main(string[] args)
        {
            /*Console.WriteLine(Sum(8, 7));
            // int res = Area(w: 20, h: 10);
            //Console.WriteLine("The area of rectangle is {0}", res);

            int res = calc(step:2, to: 15, from: 5);
            Console.WriteLine(res);

            // calling recrsion method

            Console.WriteLine(Fact(5)); */

            // drawing a pyramid

            DrawPyramid(10);
        }
    }
}
