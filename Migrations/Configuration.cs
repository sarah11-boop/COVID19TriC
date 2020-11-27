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




        }
    }
}
