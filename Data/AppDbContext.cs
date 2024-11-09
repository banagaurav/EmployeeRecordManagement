using System;
using Microsoft.EntityFrameworkCore;
using RecordManagement.Models;

namespace RecordManagement.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }

    //Db properties
    public DbSet<Department> Departments { get; set; }
    public DbSet<Employee> Employees { get; set; }
}
