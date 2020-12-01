using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace COVID19TriC.Models
{
    public class Status
    {
        public int StatusID { get; set; }
        [Required]
        public string StatusDescription { get; set; }
    }
}