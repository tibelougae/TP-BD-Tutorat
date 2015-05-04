using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class TutoringDbContext : DbContext
    {
        public DbSet<Tutor> Tutors { get; set; }

        public DbSet<HelpedStudent> HelpedStudent { get; set; }
    }
}
