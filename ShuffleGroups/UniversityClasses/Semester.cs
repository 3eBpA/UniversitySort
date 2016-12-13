using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityClasses
{
    public class Semester
    {
        public int ID { get; set; }
        public int numberOfSemester { get; set; }
        public string Specialization { get; set; }

        public List<Group> Groups { get; set; }
        public List<Software> Software { get; set; }
    }
}
