using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversityMS.Models
{
    public class Department
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Department Code is Mandatory Field")]
        [Display(Name = "Code")]
        [StringLength(7, MinimumLength = 2, ErrorMessage = "Departmrnt Code Must be 2 to  7 characters long")]
        public string DepartmentCode { get; set; }
        [Required(ErrorMessage = "Department Name is Mandatory Field")]
        [Display(Name = "Name")]
        
        public string DepartmentName { get; set; }
    }
}