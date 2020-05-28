using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JACUniversity.Models;

namespace JACUniversity.Models
{
    public class JACUniversityContext : DbContext
    {
        public JACUniversityContext (DbContextOptions<JACUniversityContext> options)
            : base(options)
        {
        }

        public DbSet<JACUniversity.Models.Student> Student { get; set; }

        public DbSet<JACUniversity.Models.Course> Course { get; set; }

        public DbSet<JACUniversity.Models.Enrollment> Enrollment { get; set; }



    }
}
