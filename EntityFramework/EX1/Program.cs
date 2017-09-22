using EX1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentSystemContext context = new StudentSystemContext();

            context.Database.Initialize(true);
            //ListAllStudentsAndHomeworks(context);
            PrintStudentsInfo(context);
            Console.ReadKey();
        }
        public static void ListAllStudentsAndHomeworks(StudentSystemContext context)
        {
            List<Student> students = context.Students.ToList();
            List<Homework> homeworks = context.Homeworks.ToList();

            foreach (Student stud in students)
            {
                Console.WriteLine($"Student: {stud.Name}");

                foreach (Homework hw in homeworks)
                {
                    if (hw.Student.Id == stud.Id)
                    {
                        Console.WriteLine($"Content: {hw.Content}, Content-Type: {hw.ContentType}");
                    }
                }
            }
        }
        public static void PrintStudentsInfo(StudentSystemContext context)
        {
            List<Student> students = context.Students
                .ToList()
                .OrderByDescending(s => s.Courses.Select(c => c.Price).Sum())
                .ThenByDescending(s => s.Courses.Count)
                .ThenByDescending(s => s.Name)
                .ToList();

            foreach (Student st in students)
            {
                int coursesCount = st.Courses.Count;
                decimal totalPrice = st.Courses.Select(c => c.Price).Sum();
                decimal averagePrice = totalPrice / coursesCount;

                Console.WriteLine($"Student name: {st.Name} Courses: {coursesCount} Total price: {totalPrice:F2} Average price: {averagePrice:F2}");
            }
        }
    }
}
