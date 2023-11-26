using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_CLASS22._11._2
{
    internal class Student
    {
        
        public int StudentId { get; set; }
        public string Name { get; set; }

        public override string? ToString()
        {
            return $"Name: {Name} Student ID: {StudentId}";
        }
    }

}
