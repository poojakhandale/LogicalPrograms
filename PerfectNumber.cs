using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalprogramming.fibonacci
{
    public  class PerfectNumber
    {
        public static void PerfectNumbers()
        {
            int start, end;
            Console.WriteLine("Enter the starting range: ");
            start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the ending range: ");
            end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Perfect numbers between " + start + " and " + end + ":");
            for (int i = start; i <= end; i++)
            {
                int sum = 0;

                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }

                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

    

