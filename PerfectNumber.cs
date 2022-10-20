using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public static class PerfectNumber
    {
        public static void CheckPerfectNumber()
        {
            int n, i, sum;
            int mn, mx;
            Console.WriteLine(" Ffind the perfect number within a given number of ranges");
            Console.WriteLine(" Input the starting range of number");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Input the ending range of number ");
            mx = Convert.ToInt32(Console.ReadLine());

            for(n=mn; n<=mx; n++)
            {
                i = 1;
                sum = 0;
                while(i<n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.WriteLine(n);
            }
        }
    }
}
