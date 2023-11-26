using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_CLASS22._11._2
{
    internal interface IDatabaseOperations
    {
        void Insert(Student student);
        void Update(Student student, string newName);
        void Delete(Student student);
        Student Select(int studentId);
        public void printStudents();

    }
}
