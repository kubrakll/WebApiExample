using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiExample.Models.classes
{
    public class Context:DbContext
    {
        public DbSet<Student> students { get; set; }
    }
}