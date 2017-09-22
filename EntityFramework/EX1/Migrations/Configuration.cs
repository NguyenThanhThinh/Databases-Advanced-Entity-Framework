namespace EX1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EX1.StudentSystemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
           
        }

        protected override void Seed(EX1.StudentSystemContext context)
        {
          
        }
    }
}
