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
    public class Audience
    {
        public Audience()
        {
            SoftwarePackages = new HashSet<SoftwarePackage>();
        }
        [Key]
        public int Audience_ID { get; set; }
        [Required]
        public int Audience_Number { get; set; }
        [Required]
        public int Places { get; set; }
        [Required]
        public bool isBusy { get; set; }
        
        public virtual ICollection<SoftwarePackage> SoftwarePackages { get; set; }

        public Group Group { get; set; }
      
    }
}
