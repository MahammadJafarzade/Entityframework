using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DataAccess
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-BA51GN1C\SQLEXPRESS;Database=Stuff;Integrated Security=true;");
        }
        public DbSet<Employee> employees { get; set; }
    }
}
