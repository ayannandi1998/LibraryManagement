using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement3.Model
{
    public class LMContext : DbContext 
    {
        public LMContext(DbContextOptions<LMContext> options) : base(options)
        {
            
        }
        public LMContext()
        {

        }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Issue> Issues { get; set; }
    }
}
