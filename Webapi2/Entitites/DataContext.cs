using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webapi2.Entitites
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CaseWorker> CaseWorkers { get; set; }
        public DbSet<CaseStatus> CaseStatus { get; set; }
        public  DbSet<Case> Cases { get; set; }

    }
}
