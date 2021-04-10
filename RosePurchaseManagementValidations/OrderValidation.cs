using RosePurchaseManagementCodeFirstFromDB;
using System.Diagnostics;
using System.Linq;

namespace RosePurchaseManagementValidations
{
    public static class OrderValidation
    {
        public static bool IsValidOrderId(this Order order)
        {
            using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
            {
                context.Database.Log = (s => Debug.Write(s));
                return context.Orders.Any(c => c.OrderID == order.OrderID);
            }
        }

        public static bool IsValidOrder(this Order order)
        {
            return order.IsValidOrderId();
        }

        /// <summary>
        /// Checks to see if the RoseSizeId is valid. 
        /// </summary>

        public static bool IsValidRoseSizeId(this Order order, bool checkIfOrdered = false)
        {
            using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
            {
                context.Database.Log = (s => Debug.Write(s));
                return context.Orders.Any(o => o.RoseSizeID == order.RoseSizeID);

            }
        }
    }
}
