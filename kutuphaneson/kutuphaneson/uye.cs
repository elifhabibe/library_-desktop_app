namespace kutuphaneson
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("uye")]
    public partial class uye
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public uye()
        {
            oduncs = new HashSet<odunc>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte uyeid { get; set; }

        [StringLength(20)]
        public string uyead { get; set; }

        [StringLength(20)]
        public string uyesoyad { get; set; }

        [StringLength(20)]
        public string adres { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<odunc> oduncs { get; set; }
    }
}
