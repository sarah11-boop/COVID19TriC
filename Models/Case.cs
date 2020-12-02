using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace COVID19TriC.Models
{
    public class Case
    {
        public int CaseID { get; set; }
        [Required]
        public bool Quarantined { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateQuarantineEnds { get; set; }
        [Required]
        public bool CountyNotified { get; set; }
        [Required]
        public string GeneralComments { get; set; }
        [Required]
        public string ExposureComments { get; set; }

        [DataType(DataType.Date)]
         [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateLastAtLocation { get; set; }

        [DataType(DataType.Date)]
         [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfExposure { get; set; }

        [DataType(DataType.Date)]
         [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfSymptoms { get; set; }

        [DataType(DataType.Date)]
         [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfTest { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfDiagnosis { get; set; }

        [DataType(DataType.Date)]
         [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateReported { get; set; }
        [Required]
        public string Symptoms { get; set; }
        [Required]
        public string ReportingName { get; set; }
        [Required]
        public string ReportingTitle { get; set; }

        [DataType(DataType.Date)]
         [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateCreated { get; set; }

        [DataType(DataType.Date)]
         [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateModified { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public int ReportingDepartmentID { get; set; }
        public int TravelRestrictionState { get; set; }
        public int StatusID { get; set; }
        public int PersonID { get; set; }
        public virtual Status Status { get; set; }
        public virtual Person Person { get; set; }
        public virtual Department Department { get; set; }
        public virtual Location Location { get; set; }

        public string formattedExpComments
        {
            get
            {
                int maxLength = Math.Min(ExposureComments.Length, 40);
                string exp = ExposureComments.Substring(0, maxLength);
                return exp;
            }
        }
        public string formattedGenComments
        {
            get
            {
                int maxLength = Math.Min(GeneralComments.Length, 40);
                string gen = GeneralComments.Substring(0, maxLength);
                return gen;
            }
        }

    }
}
