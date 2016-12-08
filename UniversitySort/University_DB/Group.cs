﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University_DB
{
    public class Group
    {
        public Group()
        {
           

        }
        [Key]
        public int Group_ID { get; set; }
        [Required]
        public string Group_Name { get; set; }
        [Required]
        public int Students_Count { get; set; }
        [Required]
        public string Specialization { get; set; }
        
        public int Semester_ID { get; set; }

        public virtual Semester Semester { get; set; }
    }
}
