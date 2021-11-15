namespace kutuphaneson
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("kitap")]
    public partial class kitap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public kitap()
        {
            kitapyazars = new HashSet<kitapyazar>();
            oduncs = new HashSet<odunc>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte kitapid { get; set; }

        [StringLength(20)]
        public string kitapad { get; set; }

        public int? ısbnno { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kitapyazar> kitapyazars { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<odunc> oduncs { get; set; }
    }
}
