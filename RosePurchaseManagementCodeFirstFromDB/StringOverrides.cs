using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosePurchaseManagementCodeFirstFromDB
{
    // All string overrides are here. Note that max length of all nvarchar columns (strings)
    // are identified in const's here. These are then used in annotations for the particular entity class.
   
    partial class Purchase
    {
        /// <summary>
        /// Max length
        /// </summary>
        public const int PurchaseMaxFarmName = 50;

        public override string ToString()
        {
            return PurchaseID + ": " + Farm.FarmName + " " + RoseSize.Rose + " " + RoseSize.Size + " " + Price_per_stem + " " + Invoice is null? InvoiceID.ToString() + " " + 
        }


    }
}
