using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFLab
{
    class ClassContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
             @"Server=.\SQLEXPRESS;Database=EFLab;Integrated Security=SSPI;");
        }
    }

}
