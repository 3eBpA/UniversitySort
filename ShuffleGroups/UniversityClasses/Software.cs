using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityClasses
{
   public class Software
    {
        public int ID { get; set; }
        public string name { get; set; }

        public List<Audience> Audience { get; set; }
        public List<Semester> Semesters { get; set; }
    }
}
