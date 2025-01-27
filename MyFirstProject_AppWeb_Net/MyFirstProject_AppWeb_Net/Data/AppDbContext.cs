using Microsoft.EntityFrameworkCore;
using MyFirstProject_AppWeb_Net.Models;
using System.Collections.Generic;

namespace MyFirstProject_AppWeb_Net.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}