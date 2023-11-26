using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_CLASS22._11._3
{
    internal class Car : IEngine, ITransportation
    {
        public void Brake()
        {
            Console.WriteLine("Car stoped");
        }

        public void Move()
        {
            Console.WriteLine("Car is moving");
        }

        public void Start()
        {
            Console.WriteLine("Engine started");
        }

        public void Stop()
        {
            Console.WriteLine("Engine stoped");
        }
    }
}
