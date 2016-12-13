using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityClasses
{
   public class Group
    {
        
        public int ID { get; set; }
        public string name { get; set; }
        public int quantityStudents { get; set; }

        public Semester Semester { get; set; }
    }
}
