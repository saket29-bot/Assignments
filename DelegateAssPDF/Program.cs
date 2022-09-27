using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAssPDF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Publisher publisher = new Publisher();
            MessageHandler m = new MessageHandler(publisher.Dispatch);
            publisher.Dispatch("hello");
            Subscriber subscriber = new Subscriber();
            
            m += subscriber.CallME;*/
            Publisher p = new Publisher();
            Subscriber s = new Subscriber();
            p.MessagePass+=s.CallME;
            p.MessagePass += s.MeToo;
            p.MessagePass += Subscriber.AddMe;
            p.Dispatch("hdsgd");





        }
    }
    public delegate void MessageHandler(string message); 
    class Publisher
    { 
        public event MessageHandler MessagePass=null;
        public void Dispatch(string msg)
        {
            if (MessagePass != null)
                MessagePass(msg);
        }
    }
    class Subscriber
    {
        public void CallME(string m)
        {
            Console.WriteLine(m);
        }
        public void MeToo(string m)
        {
            Console.WriteLine(m);
        }
        public static void AddMe(string m)
        {
            Console.WriteLine(m);
        }
    }
}
