using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    using EX1.Models;
   public class StudentSystemContext:DbContext
    {

        public StudentSystemContext(): base("name=StudentSystemContext")
        {

        }
        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<Resource> Resources { get; set; }

        public virtual DbSet<Homework> Homeworks { get; set; }

        public virtual DbSet<License> Licenses { get; set; }
    }
}
