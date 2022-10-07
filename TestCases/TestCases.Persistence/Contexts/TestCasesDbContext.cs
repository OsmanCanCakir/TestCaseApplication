using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCases.Domain.Entities;

namespace TestCases.Persistence.Contexts
{
    public class TestCasesDbContext : DbContext
    {

        public TestCasesDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Users> Users {get; set;}
        public DbSet<Status> Status {get; set;}
        public DbSet<CaseStatus> CaseStatuses {get; set;}
        public DbSet<Cases> Cases {get; set;}
        public DbSet<AssignedCase> AssignedCases {get; set;}


    }
}
