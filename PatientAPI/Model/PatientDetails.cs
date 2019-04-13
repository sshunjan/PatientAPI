using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PatientAPI.Model
{
    public class PatientDetails
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LirstName { get; set; }
        [Required]
        [Column(TypeName = "varchar(8)")]
        public string BirthDate { get; set; } // MM/DD/YY
    }
}
