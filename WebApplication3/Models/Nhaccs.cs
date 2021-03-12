namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Nhaccs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nhaccs()
        {
            hanghoas = new HashSet<hanghoas>();
        }

        [Key]
        [StringLength(50)]
        public string Ma { get; set; }

        [StringLength(50)]
        public string TenNCC { get; set; }

        [StringLength(11)]
        public string SoDienThoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hanghoas> hanghoas { get; set; }
    }
}
