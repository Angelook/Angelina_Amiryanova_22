namespace kr_vp_1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class cont1Entities : DbContext
    {
        public cont1Entities()
            : base("name=cont1Entities")
        {
        }

        public virtual DbSet<s_in_group> s_in_group { get; set; }
        public virtual DbSet<s_students> s_students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
