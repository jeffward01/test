using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOnExam.Models.Dbo;
using Microsoft.AspNet.Identity.EntityFramework;

namespace HandsOnExam.Data.Infrastructure
{
    public class HandsOnExamContext : IdentityDbContext
    {
        public HandsOnExamContext() : base("HandsOnExam")
        {
            //     this.Configuration.LazyLoadingEnabled = false;
        }

        //Dbsets
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
             var customerConfig = modelBuilder.Entity<Customer>();
            customerConfig.HasKey(_ => _.CustomerId);


            base.OnModelCreating(modelBuilder);
        }

    }
}
