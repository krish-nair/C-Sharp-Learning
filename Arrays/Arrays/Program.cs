using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            for (int k = 0; k < 10; k++)
            {
                a[k] = k * 2;
                Console.WriteLine(a[k]);
            }

            // Using the foreach loop to get only in an array...

            int[] num = new int[5] { 2, 5, 6, 7, 9};
            
            foreach (var k in num)
            {
                if (k % 2 == 0)
                {
                    Console.WriteLine(k);
                }
                
            }

            // calculating the sum of an array by foreach loop

            int[] x = { 10, 20, 30, 40, 50 };
            int sum = 0;
            foreach (var m in x)
            {
                sum += m;
            }

            Console.WriteLine(sum);

            // two dimensional array

            int[,] no = new int[8, 8];

            // multi dimensional array

             int[,] nums = { { 2, 3}, {5, 6}, {4, 6} };

             for (int k =0; k < 3; k++)
             {
                 for (int j = 0; j < 2; j++)
                 {
                     Console.Write(nums[k, j] + " ");
                 }
                 Console.WriteLine();
             }

            // jagged arraray
        
            int[][] jaggedArray = new int[][]
            {
                new int[] {2, 4, 5 },
                new int[] { 4, 20, 2},
                new int[] { 5,10,23 }
            };
            Console.WriteLine(jaggedArray[2][1]);

            // array methods

            int[] arrMeth = { 2, 4, 6, 4, 10, 20, 32, 41 };
            Console.WriteLine(arrMeth.Length);
            Console.WriteLine(arrMeth.Rank);
            Console.WriteLine(arrMeth.Min());
            Console.WriteLine(arrMeth.Sum());

            Console.WriteLine(arrMeth.Max());


            for (int m =0; m < arrMeth.Length; m++)
            {
                Console.WriteLine(arrMeth[m]);
            }


            // string methods

            string text = "I have a dog. Dogis a pet animal. The color of my dog is brown";

            text = text.Replace("dog", "cat");
            Console.WriteLine(text);

            text = text.Substring(0, text.IndexOf(".") + 5);
            Console.WriteLine(text);









        }
    }
}
