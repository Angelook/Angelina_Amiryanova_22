﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace laba7_1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class demoeEntities1 : DbContext
    {
        public demoeEntities1()
            : base("name=demoeEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<groups> groups { get; set; }
        public virtual DbSet<lectors> lectors { get; set; }
        public virtual DbSet<students> students { get; set; }
        public virtual DbSet<subjects> subjects { get; set; }
        public virtual DbSet<progress> progress { get; set; }
    }
}
