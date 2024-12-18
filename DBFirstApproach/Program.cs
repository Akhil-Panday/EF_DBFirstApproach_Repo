using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (EF_Demo_DBEntities DBEntities = new EF_Demo_DBEntities())
            {
                List<Student> listStudents = DBEntities.Students.ToList();
                Console.WriteLine();
                foreach (Student student in listStudents)
                {
                    Console.WriteLine($" Name = {student.FirstName} {student.LastName}," +
                        $" Email {student.StudentAddress?.Email}," +
                        $" Mobile {student.StudentAddress?.Mobile}");
                }
                Console.ReadLine();
            }
            using (EF_Demo_DBEntities dBEntities = new EF_Demo_DBEntities())
            {
                List<Teacher> teachersList = dBEntities.Teachers.ToList();
                Console.WriteLine();
                foreach(Teacher teacher in teachersList)
                {
                    Console.WriteLine($"Teacher Name = {teacher.FirstName} {teacher.LastName},");
                }
                Console.ReadLine();
            }
        }
    }
}
