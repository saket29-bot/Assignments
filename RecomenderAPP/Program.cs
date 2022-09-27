using CorrelationEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecomenderAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("enter 1st array length");
             int n = int.Parse(Console.ReadLine());
             int[] a = new int[n];
             Console.WriteLine("Enter elements:");
             for(int i=0;i<n;i++)
             {
                 a[i] = int.Parse(Console.ReadLine());
             }
             Console.WriteLine("enter 2st array length");
             int m = int.Parse(Console.ReadLine());
             int[] b = new int[m];
             Console.WriteLine("Enter elements:");
             for (int i = 0; i < m; i++)
             {
                 b[i] = int.Parse(Console.ReadLine());
             }*/
            int[] a1 = { 15, 18, 21, 0, 27, 34, 35 };
            int[] a2 = { 25, 25, 27, 31, 32 };
            PearsonRecomender p = new PearsonRecomender();
            Console.WriteLine(p.GetCorrelation(a1,a2));
        }
    }
}
