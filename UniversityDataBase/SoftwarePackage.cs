using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University_DB
{
    public class SoftwarePackage
    {
        public SoftwarePackage()
        {
            this.softwares = new HashSet<Software>();
        }
        [Key]
        public int Package_ID { get; set; }
        [Required]
        public int Software_ID { get; set; }
        public string SoftwarePackageName { get; set; }
        public int Audience_ID { get; set; }
        public int Semester_ID { get; set; }


        public virtual ICollection<Software> softwares { get; set; }


        public virtual Audience Audience { get; set; }
        public virtual Semester Semester { get; set; }
        
    }
}
