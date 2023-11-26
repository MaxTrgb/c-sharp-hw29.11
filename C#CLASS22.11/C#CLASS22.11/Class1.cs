using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_CLASS22._11
{
    class CreditCardPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Pay with credit card");
        }
    }
}
