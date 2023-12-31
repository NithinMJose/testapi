﻿using Microsoft.EntityFrameworkCore;
using MyApi.Models;
using System.Data;

namespace MyApi.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
                
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
