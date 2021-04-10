using RosePurchaseManagementCodeFirstFromDB;
using System.Diagnostics;
using System.Linq;

namespace RosePurchaseManagementValidations
{
    public static class PurchaseValidation

    {
        public static bool IsValidPurchaseId(this Purchase purchase)
        {
            using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
            {
                context.Database.Log = (s => Debug.Write(s));
                return context.Purchases.Any(c => c.PurchaseID == purchase.PurchaseID);
            }
        }

        public static bool IsValidPurchase(this Purchase purchase)
        {
            return purchase.IsValidPurchaseId();
        }



        /// <summary>
        /// Make sure all Purchase info exists and is not blank
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        public static bool InfoIsInvalid(this Purchase purchase)
        {
            return (purchase.PurchaseID == null || purchase.PurchaseID < 0 ||
                purchase.FarmID == null || purchase.FarmID < 0 ||
                purchase.RoseSizeID == null || purchase.RoseSizeID < 0 ||
                purchase.Price_per_stem == null || purchase.Price_per_stem < 0 ||
                purchase.InvoiceID == null || purchase.InvoiceID < 0 ||
                purchase.WarehouseID == null || purchase.WarehouseID < 0);
        }
    }
}
