namespace kutuphaneson
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("odunc")]
    public partial class odunc
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte oduncid { get; set; }

        public byte? uyeid { get; set; }

        public byte? kitapid { get; set; }

        [Column(TypeName = "date")]
        public DateTime? vermetarih { get; set; }

        public virtual kitap kitap { get; set; }

        public virtual uye uye { get; set; }
    }
}
