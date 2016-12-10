using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace University_DB
{
    public class Semester
    {
        public Semester()
        {
            SoftwarePackages = new HashSet<SoftwarePackage>();
        }
        [Key]
        public int Semester_ID { get; set; }

        public virtual ICollection<SoftwarePackage> SoftwarePackages { get; set; }
    }
}
