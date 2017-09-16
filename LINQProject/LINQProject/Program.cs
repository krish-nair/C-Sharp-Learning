using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 23, 34, 56, 76, 55, 54, 34, 67, 36, 78, 99, 41, 12, 34, 22, 47 };
            int Count = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] > 40)
                    Count += 1;
            }
            int[] Brr = new int[Count];
            int index = 0;

            for(int i = 0; i<Arr.Length; i++)
            {
                if (Arr[i] > 40)
                {
                    Brr[index] = Arr[i];
                    index += 1;
                }
            }
            Array.Sort(Brr);
            Array.Reverse(Brr);
            foreach (int i in Brr)
                Console.WriteLine(i + " ");
            Console.ReadLine();

        }
    }
}
