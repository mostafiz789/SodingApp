using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SodingSampleApp.Models;

namespace SodingSampleApp.DataAccess
{
    public class DataInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var students = new List<Task>
            {
                new Task{Name="Task A",Description="Number One",DateCreated=DateTime.Parse("2005-09-01"),DateUpdated=DateTime.Parse("2005-09-01")},
                new Task{Name="Task B",Description="Student",DateCreated=DateTime.Parse("2005-09-01"),DateUpdated=DateTime.Parse("2005-09-01")},
                new Task{Name="New Task",Description="Good",DateCreated=DateTime.Parse("2005-09-01"),DateUpdated=DateTime.Parse("2005-09-01")},
            };

            students.ForEach(s => context.Tasks.Add(s));
            context.SaveChanges(); 
        }
    }
}