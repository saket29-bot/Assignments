using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CustomeException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAcc s=new SavingsAcc(12345,2000);
            s.Withdraw(2500);

        }
    }
    class SavingsAcc
    {
        private int AccNumber;
        private double Balance;
        public SavingsAcc(int accNumber, double balance)
        {
            this.AccNumber = accNumber;
            this.Balance = balance;
        }
        public void Withdraw(double Amount)
        {
            try
            {
                Balance -= Amount;
                if(Balance < 0) 
                    throw new OverdrawnException("Balance is less",Balance);
                else
                    Console.WriteLine("updated balance:"+Balance);
            }
            catch(OverdrawnException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
