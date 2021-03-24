namespace RosePurchaseManagementCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public int OrderID { get; set; }

        public int RoseSizeID { get; set; }

        public int Number_of_bunches { get; set; }

        public virtual RoseSize RoseSize { get; set; }
    }
}
