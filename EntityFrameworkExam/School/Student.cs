using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace School
{
    public class Student : DbSet
    {
        public int studentID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public int courseID { get; set; }
        public virtual Course courses { get; set; }
        public virtual ICollection<Registry> Registries { get; set; }


    }
}
