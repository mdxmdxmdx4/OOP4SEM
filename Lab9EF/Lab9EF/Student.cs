using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9EF
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }
        public List<Class> StudentClasses { get; set; }

        public override string ToString()
        {
            return $"{this.StudentID}| {this.StudentName} | {this.StudentAge}";
        }
    }
}
