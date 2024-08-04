using Microsoft.EntityFrameworkCore;
using StudentManagmentSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagmentSystem.DAL.Data
{
    public class CustomDbContext:DbContext
    {
        public CustomDbContext(DbContextOptions<CustomDbContext> options):base(options)
        {
        }
        public DbSet<Student> Students { get; set; }

    }
}
