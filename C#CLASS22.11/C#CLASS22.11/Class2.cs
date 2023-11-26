using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_CLASS22._11
{
    internal class PaypalPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Pay with PayPal");
        }
    }
}
