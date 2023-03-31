using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Student
    {
        public int studentId { get; set; }
        public string studentName { get; set; }
        public override string ToString()
        {
            return $"{this.studentId}: {this.studentName}";
        }
    }
}
