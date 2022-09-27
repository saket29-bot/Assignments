using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    internal class Program
    {
        public static List<Account> accList=new List<Account>();  
        static void Main(string[] args)
        {
            Account acc1 = new Saving(123, "Saket", 3000, 1234, true, DateTime.Now, DateTime.MinValue, "Male");
            accList.Add(acc1);

        }



    }
    class Account
    {
        public long AccNo { get; set; }   
        public string Name { get; set; }
        public int Balance { get; set; }
        public int PinNo { get; set; }
        public bool IsActive { get; set; }
        public DateTime OpeningDate { get; set; }
        public DateTime ClosingDate { get; set; }
        

        public void Deposite(int Amount)
        {
            Balance= Balance + Amount;
        }
        public void Withdraw(int Amount)
        {
            Balance = Balance - Amount;
        }
        public void Closing(long accNo)
        {
            foreach(Account a in Program.accList)
            {
                
                    
            }
        }

    }
    class Saving:Account
    {
        public string Gender { get; set; }
        public Saving(long accNo, string name, int balance, int pinNo, bool isActive, DateTime openingDate, DateTime closingDate,string gender)
        {
            AccNo = accNo;
            Name = name;
            Balance = balance;
            PinNo = pinNo;
            IsActive = isActive;
            OpeningDate = openingDate;
            ClosingDate = closingDate;
            Gender = gender;
        }

    }
    class Current:Account
    {
        public string CompanyName { get; set; }
        public Current(long accNo, string name, int balance, int pinNo, bool isActive, DateTime openingDate, DateTime closingDate, string companyName)
        {
            AccNo = accNo;
            Name = name;
            Balance = balance;
            PinNo = pinNo;
            IsActive = isActive;
            OpeningDate = openingDate;
            ClosingDate = closingDate;
            CompanyName = companyName;
        }
    }
    class Accountmanager
    {

    }
}
