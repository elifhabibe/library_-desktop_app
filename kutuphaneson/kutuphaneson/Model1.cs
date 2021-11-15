namespace kutuphaneson
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<kitap> kitaps { get; set; }
        public virtual DbSet<kitapyazar> kitapyazars { get; set; }
        public virtual DbSet<odunc> oduncs { get; set; }
        public virtual DbSet<tur> turs { get; set; }
        public virtual DbSet<uye> uyes { get; set; }
        public virtual DbSet<yazar> yazars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
