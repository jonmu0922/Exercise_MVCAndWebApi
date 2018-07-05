namespace Exercise_MVCAndWebApi.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TestContext : DbContext
    {
        public TestContext()
            : base("name=DBConnectionString")
        {
        }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<SysUser> SysUser { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
