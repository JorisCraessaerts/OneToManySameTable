using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTestProject
{
    public class Student
    {
        public Student()
        {
            Students = new List<Student>();
        }

        public int StudentId { get; set; }
        public string Name { get; set; }

        public Student Parent { get; set; }
        public int? ParentId { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
