using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GuniApp_Proj_1.Web.Models
{
    public class Department
    {
        [Key]
        [Display(Name = "Dpeartmnent Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int deptid { get; set; }


        [Required]
        [Display(Name = "Department Name")]
        [Column("varchar")]
        public string deptname { get; set; }
    }
}
