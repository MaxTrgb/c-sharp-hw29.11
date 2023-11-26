using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_CLASS22._11._2
{
    class StudentDatabase : IDatabaseOperations
    {
        List<Student> students = new List<Student>();

        public void Delete(Student student)
        {
            students.Remove(student);
        }

        public void Insert(Student student)
        {
            students.Add(student);
        }


        public Student Select(int studentId)
        {
            foreach (Student student in students)
            {
                if (student.StudentId == studentId)
                {
                    return student;

                }

            }
            return null;
        }

        public void Update(Student student, string newName)
        {         
                
            student.Name = newName;
        }

        public void printStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.Name);
                Console.WriteLine(student.StudentId);
            }
        }
    }
}
