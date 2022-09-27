using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestFindSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleLoop.SimpleLoopTest a=new SimpleLoop.SimpleLoopTest();
            int b=a.FindSum(4);
            Console.WriteLine(b);

        }
    }
}
