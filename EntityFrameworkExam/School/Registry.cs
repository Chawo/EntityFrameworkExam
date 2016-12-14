using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace School
{
    public class Registry : DbSet
    {
        public int registryID { get; set; }
        public DateTime registryDate { get; set; }
        public int studentID { get; set; }
        public virtual Student students { get; set; }
    }
}
