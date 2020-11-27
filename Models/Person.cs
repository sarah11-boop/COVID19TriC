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
        public string SNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public enum PersonnelType { Student, Faculty, Staff }
        public string PersonalEmail { get; set; }
        public string SchoolEmail { get; set; }
        public string PhoneNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        [DataType(DataType.Date)]
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