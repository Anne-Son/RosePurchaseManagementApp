using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosePurchaseManagementCodeFirstFromDB
{
	// All string overrides are here. Note that max length of all nvarchar columns (strings)
	// are identified in const's here. These are then used in annotations for the particular entity class.

	//    partial class Purchase
	//    {
	//        /// <summary>
	//        /// Max length
	//        /// </summary>
	//        public const int PurchaseMaxFarmName = 50;

	//        public override string ToString()
	//        {
	//            return PurchaseID + ": " + FarmID + " " + RoseSizeID  + " " + Price_per_stem + " " + Invoice.InvoiceID + " " + Warehouse.WarehouseID;
	//        }


	//    }
	public partial class Order
	{
		public override string ToString()
		{
			return $"{OrderID} {RoseSizeID}	{Number_of_bunches}";
		}
	}
	public partial class Farm
	{
		public override string ToString()
		{
			return $"{FarmName}";
		}
	}
	public partial class Rose
	{
		public override string ToString()
		{
			return $"{RoseID} {RoseName}	{GroupCode}";
		}
	}
	public partial class RoseSize
	{
		public override string ToString()
		{
			return $"{RoseSizeID} {RoseID} {SizeID}";
		}
	}

	public partial class Size
	{
		public override string ToString()
		{
			return $"{SizeID} {SizeName}  {Freight}";
		}
	}

	public partial class Invoice
	{
		public override string ToString()
		{
			return $"{InvoiceID}  {Date}  {TotalAmount}  {FarmID}  ";
		}
	}

	public partial class Warehouse
	{
		public override string ToString()
		{
			return $"{WarehouseName}";
		}
	}


	public partial class Inventory
	{
		public override string ToString()
		{
			return $"{InventoryID} {Farm.FarmName} {RoseSizeID} {Price_per_stem}  ";
		}
	}
	public partial class Box
	{
		public override string ToString()
		{
			return $"{BoxID}  {BoxName}";
		}
	}
	public partial class BoxInventory
	{
		public override string ToString()
		{
			return $"{Quantity}";
		}
	}
}
