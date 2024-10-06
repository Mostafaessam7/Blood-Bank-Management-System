using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBMS.DBContext
{
    public class BloodContext:DbContext
    {
        public DbSet<BloodTbl> BloodTbls { get; set;}
        public DbSet<DonorTbl>donorTbls { get; set;}
        public DbSet<Patient>patients { get; set;}
        public DbSet<TransferTbl> transferTbls { get; set;}
        public DbSet<Employee>employees { get; set;}
        public BloodContext() : base("Data Source=.;Initial Catalog=BLoodProject;Integrated Security=true;TrustServerCertificate=True") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BloodTbl>().HasKey(b => b.BGroup);
            modelBuilder.Entity<DonorTbl>().HasKey(b => b.NID);

            modelBuilder.Entity<TransferTbl>().HasKey(b => b.TNum);


            base.OnModelCreating(modelBuilder);
        }
    }
}
