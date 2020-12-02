using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COVID19TriC.Models
{
    public class Location
    {
        public int LocationID { get; set; }
        [Required]
        public string LocationDescription { get; set; }
    }
}
