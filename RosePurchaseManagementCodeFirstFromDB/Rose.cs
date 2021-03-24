namespace RosePurchaseManagementCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rose")]
    public partial class Rose
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rose()
        {
            RoseSizes = new HashSet<RoseSize>();
        }

        public int RoseID { get; set; }

        [Required]
        [StringLength(50)]
        public string RoseName { get; set; }

        [Required]
        [StringLength(10)]
        public string GroupCode { get; set; }

        public virtual Group Group { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoseSize> RoseSizes { get; set; }
    }
}
