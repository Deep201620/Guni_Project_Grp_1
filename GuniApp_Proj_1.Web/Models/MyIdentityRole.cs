using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace GuniApp_Proj_1.Web.Models
{
    public class MyIdentityRole : IdentityRole<Guid>
    {
        //Adding additonal column to identity role

        [StringLength(100)]
        public string Description { get; set; }
    }
}
