using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Art.Cqrs.EF;
using SampleApp.Domain;

namespace SampleApp.Cqrs.EF
{
    public class SampleAppDbContext:EFDbContext
    {
        public SampleAppDbContext(string connectionString) : base(connectionString)
        {
            Database.SetInitializer(new SampleAppDbInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasKey(t => t.OrderId);
            base.OnModelCreating(modelBuilder);
        }

        
    }
}
