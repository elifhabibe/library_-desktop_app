namespace kutuphaneson
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("kitapyazar")]
    public partial class kitapyazar
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte kitapyazarid { get; set; }

        public byte? yazarid { get; set; }

        public byte? kitapid { get; set; }

        public virtual kitap kitap { get; set; }

        public virtual yazar yazar { get; set; }
    }
}
