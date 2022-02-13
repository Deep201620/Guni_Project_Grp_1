using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GuniApp_Proj_1.Web.Models
{
    public class MyIdentityUser : IdentityUser<Guid>
    {
        //Adding additional columns to AspNetUser table

        [Display(Name = "Display Name")]
        [StringLength(60)]
        [Required]
        [MinLength(3)]
        public string DisplayName { get; set; }

        [Display(Name = "Date Of Birth")]
        [PersonalData]
        [Required]
        [Column(TypeName = "smalldatetime")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "is Admin ?")]
        [Required]
        public bool isAdminUser { get; set; }
    }
}
