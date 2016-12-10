using System.ComponentModel.DataAnnotations;
namespace University_DB
{
    public class Software
    {

        public Software()
        {
            
        }
        [Key]
        public int Software_ID { get; set; }
        [Required]
        public string Name { get; set; }
        public int SoftwarePackage_ID { get; set; }

        public SoftwarePackage SoftwarePackage { get; set; }

       
    }
}
