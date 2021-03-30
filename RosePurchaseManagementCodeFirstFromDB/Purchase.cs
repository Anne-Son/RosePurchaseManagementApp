namespace RosePurchaseManagementCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Purchase")]
    public partial class Purchase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Purchase()
        {
            BoxPurchases = new HashSet<BoxPurchase>();
        }
        [Key]
        public int PurchaseID { get; set; }

        [ForeignKey("Farm")]
        public int FarmID { get; set; }

        [ForeignKey("RoseSize")]
        public int RoseSizeID { get; set; }

        public float Price_per_stem { get; set; }

        [ForeignKey("Invoice")]
        public int? InvoiceID { get; set; }

        [ForeignKey("Warehouse")]
        public int WarehouseID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoxPurchase> BoxPurchases { get; set; }

        public virtual Farm Farm { get; set; }

        public virtual Invoice Invoice { get; set; }

        public virtual RoseSize RoseSize { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}
