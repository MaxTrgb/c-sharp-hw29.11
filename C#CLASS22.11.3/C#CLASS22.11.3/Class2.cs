using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_CLASS22._11._3
{
    internal class Bicycle : ITransportation
    {
        public void Brake()
        {
            Console.WriteLine("Bycicle stopped");
        }

        public void Move()
        {
            Console.WriteLine("Bycicle is moving");
        }
    }
}
