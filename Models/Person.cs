using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Collections.Specialized;
using System.Web.Mvc;
using System.Web.Routing;

namespace COVID19TriC.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        [Required]
        public string SNumber { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string MiddleName { get; set; }
        public enum PersonnelType { Student, Faculty, Staff }
        [Required]
        public string PersonalEmail { get; set; }
        public string SchoolEmail { get; set; }
        public string PhoneNumber { get; set; }

        
         [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateCreated { get; set; }

        [DataType(DataType.Date)]
         [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateModified { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public int LocationID { get; set; }
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }
        public virtual Location Location { get; set; }
        public string formattedPhoneNumber
        {
             get
             {
                return string.Format("({0}) {1}-{2}", PhoneNumber.Substring(0, 3), PhoneNumber.Substring(3, 3), PhoneNumber.Substring(6, 4));               
             }

        }

        
       
    }
    

    
}
