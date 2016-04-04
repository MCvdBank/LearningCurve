using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LearningCurve.Models;

namespace LearningCurve.Data
{
    public class LocalInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LocalContext>
    {
        protected override void Seed(LocalContext context)
        {
            var people = new List<Person>
                {
                    new Person { Name = "RM" }
                };

            people.ForEach(s => context.People.Add(s));
            context.SaveChanges();
        }
    }
}
