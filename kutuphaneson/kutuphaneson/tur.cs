namespace kutuphaneson
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tur")]
    public partial class tur
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte turid { get; set; }

        [StringLength(20)]
        public string turaciklama { get; set; }
    }
}
