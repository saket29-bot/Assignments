using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class ExceptionTest
    {

        static void Main(string[] args)
        {
            int[] arr = new int[10];
            try
            {
                
                Console.WriteLine("Enter the 1st no");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the second no");
                int b= int.Parse(Console.ReadLine());
                int c = a / b;
                arr[11] = 5;
                
            }
            /*catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }*/

            catch (IndexOutOfRangeException e)
            {
                string s = e.Message;
                string s1 = e.StackTrace;
                Console.WriteLine(s);
                Console.WriteLine(s1);
                Console.WriteLine(e.ToString());
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine(d.Message);
            }
            finally
            {
             
            }
        }
    }
}
