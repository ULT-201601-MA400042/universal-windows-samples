using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEnquiryApp.DataAccess.Models
{
    public class CourseEnquiryDbContext : DbContext
    {
        public DbSet<Learner> Learners { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=CourseEnquiry.db");
        }
    }
}
