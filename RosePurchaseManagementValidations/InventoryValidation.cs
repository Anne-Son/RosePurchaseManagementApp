using RosePurchaseManagementCodeFirstFromDB;
using System.Diagnostics;
using System.Linq;

namespace RosePurchaseManagementValidations
{
    public static class InventoryValidation
    {

        /// <summary>
        /// Make sure all info exists and is not blank
        /// </summary>
        /// <param name="inventory"></param>
        /// <returns></returns>
        public static bool InfoIsInvalid(this Inventory inventory)
        {
            return (inventory.InventoryID == null || inventory.InventoryID < 0 ||
                    inventory.FarmID == null || inventory.FarmID < 0 ||
                    inventory.Price_per_stem == null || inventory.Price_per_stem < 0);
        }
    }
}
