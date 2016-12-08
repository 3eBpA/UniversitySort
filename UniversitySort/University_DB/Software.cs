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
    public class Software
    {

        public Software()
        {
            this.softwarePackeges = new HashSet<SoftwarePackage>();
        }
        [Key]
        public int Software_ID { get; set; }
        [Required]
        public string Name { get; set; }


       public virtual ICollection<SoftwarePackage> softwarePackeges { get; set; }
    }
}
