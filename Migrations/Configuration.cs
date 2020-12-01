namespace COVID19TriC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using COVID19TriC.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<COVID19TriC.Data.COVID19TriCContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "COVID19TriC.Data.COVID19TriCContext";
        }

        protected override void Seed(COVID19TriC.Data.COVID19TriCContext context)
        {
            context.Status.AddOrUpdate(i => i.StatusDescription,
            new Status
            {
                StatusDescription = "Awaiting Test results"
            },

            new Status
            {
                StatusDescription = "Tested Positive While at College, Symptomatic"
            },

            new Status
            {
                StatusDescription = "Tested Positive at a Clinical Site , Symptomatic"
            },

            new Status
            {
                StatusDescription = "Tested Positive Not at College, Symptomatic"
            },

            new Status
            {
                StatusDescription = "Travel Advisory"
            },

            new Status
            {
                StatusDescription = "Tested Negative"
            }
            );

            context.States.AddOrUpdate(s => s.StateName,
            new State
            {
                StateName = "AL"
            },

            new State
            {
                StateName = "AK"
            },

            new State
            {
                StateName = "AZ"
            },

            new State
            {
                StateName = "AR"
            },

            new State
            {
                StateName = "CA"
            },

            new State
            {
                StateName = "CO"
            },

            new State
            {
                StateName = "CT"
            },

            new State
            {
                StateName = "DE"
            },

            new State
            {
                StateName = "DC"
            },

            new State
            {
                StateName = "FL"
            },

            new State
            {
                StateName = "GA"
            },

            new State
            {
                StateName = "HI"
            },

            new State
            {
                StateName = "ID"
            },

            new State
            {
                StateName = "IL"
            },

            new State
            {
                StateName = "IN"
            },

            new State
            {
                StateName = "IA"
            },

            new State
            {
                StateName = "KS"
            },

            new State
            {
                StateName = "KY"
            },

            new State
            {
                StateName = "LA"
            },

            new State
            {
                StateName = "ME"
            },

            new State
            {
                StateName = "MD"
            },

            new State
            {
                StateName = "MA"
            },

            new State
            {
                StateName = "MI"
            },

            new State
            {
                StateName = "MN"
            },

            new State
            {
                StateName = "MS"
            },

            new State
            {
                StateName = "MO"
            },

            new State
            {
                StateName = "MT"
            },

            new State
            {
                StateName = "NE"
            },

            new State
            {
                StateName = "NV"
            },

            new State
            {
                StateName = "NH"
            },

            new State
            {
                StateName = "NJ"
            },

            new State
            {
                StateName = "NM"
            },

            new State
            {
                StateName = "NY"
            },

            new State
            {
                StateName = "NC"
            },

            new State
            {
                StateName = "ND"
            },

            new State
            {
                StateName = "OH"
            },

            new State
            {
                StateName = "OK"
            },

            new State
            {
                StateName = "OR"
            },

            new State
            {
                StateName = "PA"
            },

            new State
            {
                StateName = "RI"
            },

            new State
            {
                StateName = "SC"
            },

            new State
            {
                StateName = "SD"
            },

            new State
            {
                StateName = "TN"
            },

            new State
            {
                StateName = "TX"
            },

            new State
            {
                StateName = "UT"
            },

            new State
            {
                StateName = "VT"
            },

            new State
            {
                StateName = "VA"
            },

            new State
            {
                StateName = "WA"
            },

            new State
            {
                StateName = "WV"
            },

            new State
            {
                StateName = "WI"
            },

            new State
            {
                StateName = "WY"
            }

            );

            context.Locations.AddOrUpdate(l => l.LocationDescription,
            new Location
            {
                LocationDescription = "Advanced Technology Training Center"
            },

            new Location
            {
                LocationDescription = "Brunswick University Center"
            },

            new Location
            {
                LocationDescription = "Corporate College East"
            },

            new Location
            {
                LocationDescription = "Corporate College West"
            },

            new Location
            {
                LocationDescription = "District Administrative Offices"
            },

            new Location
            {
                LocationDescription = "Eastern Campus"
            },

            new Location
            {
                LocationDescription = "Hospitality Management Center"
            },

            new Location
            {
                LocationDescription = "Jerry Sue Thornton Center"
            },

            new Location
            {
                LocationDescription = "Manufacturing Technology Center"
            },

            new Location
            {
                LocationDescription = "Metropolitan Campus"
            },

            new Location
            {
                LocationDescription = "Public Safety Training Center"
            },

            new Location
            {
                LocationDescription = "Transportation Innovation Center"
            },

            new Location
            {
                LocationDescription = "Western Campus"
            },

            new Location
            {
                LocationDescription = "Westshore Campus"
            }

            );

            context.Departments.AddOrUpdate(d => d.DepartmentDescription,
            new Department
            {
                DepartmentDescription = "Accounting"
            },

            new Department
            {
                DepartmentDescription = "Adult Diploma Program"
            },

            new Department
            {
                DepartmentDescription = "American Sign Language"
            },

            new Department
            {
                DepartmentDescription = "Applied Industrial Technology"
            },

            new Department
            {
                DepartmentDescription = "Aspire"
            },

            new Department
            {
                DepartmentDescription = "Art"
            },

            new Department
            {
                DepartmentDescription = "Science"
            },

            new Department
            {
                DepartmentDescription = "Automotive Technology"
            },

            new Department
            {
                DepartmentDescription = "Business Management"
            },

            new Department
            {
                DepartmentDescription = "Captioning And Court Reporting"
            },

            new Department
            {
                DepartmentDescription = "Cisco"
            },

            new Department
            {
                DepartmentDescription = "Conflict Resolution And Peace Studies"
            },

            new Department
            {
                DepartmentDescription = "Corporate College"
            },

            new Department
            {
                DepartmentDescription = "Creative Arts"
            },

            new Department
            {
                DepartmentDescription = "Criminal Justice"
            },

            new Department
            {
                DepartmentDescription = "Deaf Interpretive Services"
            },

            new Department
            {
                DepartmentDescription = "Early Childhood Education"
            },

            new Department
            {
                DepartmentDescription = "Engineering Technology"
            },

            new Department
            {
                DepartmentDescription = "English As A Second Language"
            },

            new Department
            {
                DepartmentDescription = "Fire"
            },

            new Department
            {
                DepartmentDescription = "Health Careers"
            },

            new Department
            {
                DepartmentDescription = "Honors & Scholars"
            },

            new Department
            {
                DepartmentDescription = "Hospitality Management"
            },

            new Department
            {
                DepartmentDescription = "Information Technology"
            },

            new Department
            {
                DepartmentDescription = "Liberal Arts, Humanities, Social, and Behavioral Sciences"
            },

            new Department
            {
                DepartmentDescription = "Manufacturing"
            },

            new Department
            {
                DepartmentDescription = "Nursing"
            },

            new Department
            {
                DepartmentDescription = "Online Training"
            },

            new Department
            {
                DepartmentDescription = "Paralegal"
            },

            new Department
            {
                DepartmentDescription = "Plant Science And Landscape Technology"
            },

            new Department
            {
                DepartmentDescription = "Public Safety"
            },

            new Department
            {
                DepartmentDescription = "Senior Adult Education"
            },

            new Department
            {
                DepartmentDescription = "STEM"
            },

            new Department
            {
                DepartmentDescription = "Study Abroad"
            },

            new Department
            {
                DepartmentDescription = "Teacher Education"
            },

            new Department
            {
                DepartmentDescription = "Transportation"
            },

            new Department
            {
                DepartmentDescription = "Transportation Center"
            },

            new Department
            {
                DepartmentDescription = "Welding"
            },

            new Department
            {
                DepartmentDescription = "Workforce"
            },

            new Department
            {
                DepartmentDescription = "Office of the President"
            },

            new Department
            {
                DepartmentDescription = "Board of Trustees Office"
            },

            new Department
            {
                DepartmentDescription = "Business Continuity"
            },

            new Department
            {
                DepartmentDescription = "Capital and Construction"
            },

            new Department
            {
                DepartmentDescription = "Customer Service"
            },

            new Department
            {
                DepartmentDescription = "Foundation"
            },

            new Department
            {
                DepartmentDescription = "Government Relations"
            },

            new Department
            {
                DepartmentDescription = "Human Resources"
            },

            new Department
            {
                DepartmentDescription = "Information Technology Services"
            },

            new Department
            {
                DepartmentDescription = "Office of Legal Services"
            },

            new Department
            {
                DepartmentDescription = "Plant Operations"
            },

            new Department
            {
                DepartmentDescription = "Integrated Communications"
            },

            new Department
            {
                DepartmentDescription = "Supplier Managed Services"
            },

            new Department
            {
                DepartmentDescription = "Campus Police & Security Services"
            }
            );

                      
        }
    }
}
