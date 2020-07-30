using System;
using System.Linq;

namespace EntityFrameworkTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adding students to Students table.");
            var context = new SchoolContext();
            var students = context.Students.ToList().Where(s => s.ParentId == null).ToList();
            //var parent = context.Students.FirstOrDefault(s => s.Name == "Thomas");
            //parent.Students.Add(new Student
            //{
            //    Name = "Bert Bavet",
            //    Parent = parent,
            //});
            context.SaveChanges();

            Console.WriteLine("Students are added to the Students table");
            Console.ReadKey();
        }
    }
}
