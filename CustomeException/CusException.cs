using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomeException
{
    internal class OverdrawnException:ApplicationException
    {
        private string message;
        public double AccBalance { get; set; }
        public OverdrawnException(string message, double accBalance):base(message)
        {
            this.message = message;
            AccBalance = accBalance;
        }   
    }
}
