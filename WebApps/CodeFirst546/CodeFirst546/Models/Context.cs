using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst546.Models
{
    public class Context : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}