using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace COVID19TriC.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        [Required]
        public string DepartmentDescription { get; set; }
    }
}