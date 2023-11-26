using C_CLASS22._11._2;

namespace MySpace
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Test1";  
            student.StudentId = 1;

            Student student1 = new Student();
            student1.Name = "Test2";
            student1.StudentId = 2;

            IDatabaseOperations studentDatabase = new StudentDatabase();
            studentDatabase.Insert(student);
            studentDatabase.Insert(student1);

            Console.WriteLine("Print: ");
            studentDatabase.printStudents();

            Console.WriteLine("Select:");
            Console.WriteLine(studentDatabase.Select(1));

            Console.WriteLine("Update:");
            studentDatabase.Update(student,"New Name");
            studentDatabase.printStudents();

            Console.WriteLine("Deleting...");
            studentDatabase.Delete(student);

            studentDatabase.printStudents();

        }
    }
}