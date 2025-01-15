using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using u20649232_HW01_API.Models;

namespace u20649232_HW01_API.Data
{
    public class AppDBContext : DbContext
    {
        //Initialization of class
        public AppDBContext(DbContextOptions<AppDBContext> options): base (options) { }

        //set table
        public DbSet<CourseListing> courseListings { get; set; }

        //Seed repository
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CourseListing>().HasData(
             new CourseListing { courseId = 1, courseName = "INF315",courseDuration= "Semester 1", courseDescription = "Project teams and project managment" },
             new CourseListing { courseId = 2, courseName = "INF154", courseDuration = "Semester 1", courseDescription = "Fundamentals of prgramming in C# webforms" },
             new CourseListing { courseId = 3, courseName = "INF164", courseDuration = "Semester 2", courseDescription = "Fundamentals of html,css and javascript" },
             new CourseListing { courseId = 4, courseName = "INF272", courseDuration = "Year", courseDescription = "Advanced programming in MVC & databases" },
             new CourseListing { courseId = 5, courseName = "INF354", courseDuration = "Semester 1", courseDescription = "Advanced programming in sql, angular and api" },
             new CourseListing { courseId = 6, courseName = "INF171", courseDuration = "Year", courseDescription = "Fundamentals into systems architecture" },
             new CourseListing { courseId = 7, courseName = "INF271", courseDuration = "Year", courseDescription = "Advanced system moddelling and sysetsms analysis" },
             new CourseListing { courseId = 8, courseName = "INF370", courseDuration = "Year", courseDescription = "Full systems development life cycle project" },
             new CourseListing { courseId = 9, courseName = "INF324", courseDuration = "Semester 2", courseDescription = "Tends in IT" },
             new CourseListing { courseId = 10, courseName = "INL320", courseDuration = "Semester 2", courseDescription = "Knowledge managment in organisation at coprate strategic level" }
         );
        }

    }
}
