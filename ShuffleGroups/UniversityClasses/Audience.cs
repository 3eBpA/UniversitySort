using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityClasses
{
   public  class Audience
    {
        public int ID { get; set; }
        public int number { get; set; }
        public int quantityPlaces { get; set; }
        public bool isBusy { get; set; }

        public Group Group { get; set; }
        public List<Software> Software { get; set; }
    }
}
