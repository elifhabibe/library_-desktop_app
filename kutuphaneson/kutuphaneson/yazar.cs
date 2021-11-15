namespace kutuphaneson
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("yazar")]
    public partial class yazar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public yazar()
        {
            kitapyazars = new HashSet<kitapyazar>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte yazarid { get; set; }

        [StringLength(20)]
        public string yazarad { get; set; }

        [StringLength(20)]
        public string yazarsoyadi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kitapyazar> kitapyazars { get; set; }
    }
}
