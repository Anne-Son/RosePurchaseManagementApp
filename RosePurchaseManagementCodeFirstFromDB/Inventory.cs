namespace RosePurchaseManagementCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inventory")]
    public partial class Inventory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inventory()
        {
            BoxInventories = new HashSet<BoxInventory>();
        }

        public int InventoryID { get; set; }

        public int FarmID { get; set; }

        public int RoseSizeID { get; set; }

        public decimal Price_per_stem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoxInventory> BoxInventories { get; set; }

        public virtual Farm Farm { get; set; }

        public virtual RoseSize RoseSize { get; set; }
    }
}
