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




        }
    }
}
