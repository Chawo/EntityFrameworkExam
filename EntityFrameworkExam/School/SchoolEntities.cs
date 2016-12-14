using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace School
{
    class SchoolEntities : DbContext
    {
        public virtual DbSet<Registry> Registry { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Student> Student { get; set; }
    }
}
