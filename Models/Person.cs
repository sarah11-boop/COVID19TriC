using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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
        [Required]
        public string SchoolEmail { get; set; }
        [Required]
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
    }
   
}