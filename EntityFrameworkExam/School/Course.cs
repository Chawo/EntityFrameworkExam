using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace School
{
    public class Course : DbSet
    {
        public int courseID { get; set; }
        public string courseName { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
