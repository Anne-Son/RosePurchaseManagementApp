using RosePurchaseManagementCodeFirstFromDB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedDatabaseExtensions
{
	public static class SeedDatabaseExtensionMethods
	{
		/// <summary>
		/// zero out the db tables, then seed all tables with initial data
		/// </summary>
		public static void SeedDatabase(this RosePurchaseManagementEntities context)
		{
			// set up database log to write to output window in VS
			context.Database.Log = (s => Debug.Write(s));

			// reset the db
			context.Database.Delete();
			context.Database.Create();

			context.SaveChanges();

			// another way to reinitialize the database, resetting everything and zeroing out data

			//Database.SetInitializer(new DropCreateDatabaseAlways<StudentRegistrationEntities>());
			//context.Database.Initialize(true);        

			context.Boxes.Load();
			context.BoxInventories.Load();
			context.BoxPurchases.Load();
			context.Farms.Load();
			context.Groups.Load();
			context.Inventories.Load();
			context.Invoices.Load();
			context.Orders.Load();
			context.Purchases.Load();
			context.Roses.Load();
			context.RoseSizes.Load();
			context.Sizes.Load();
			context.Warehouses.Load();

			//Loading Box data to the database
			List<Box> boxList = new List<Box>()  {
				new Box { BoxID=1,BoxName="Quarter Box"},
				new Box { BoxID=2,BoxName="Half Box"},
				new Box { BoxID=3,BoxName="Full Box"},
				
			};
			Dictionary<int, Box> boxes = boxList.ToDictionary(x => x.BoxID, x => x);
			context.Boxes.AddRange(boxes.Values);

			//Loading Group data to the database
			List<Group> groupList = new List<Group>  {
				new  Group { GroupName ="Cream", GroupCode ="CR"},
				new  Group { GroupName ="Green", GroupCode ="GR"},
			    new  Group { GroupName ="Mixture", GroupCode ="MIX"},
				new  Group { GroupName ="Orange", GroupCode ="OR"},
			    new  Group { GroupName ="PINK", GroupCode ="PI"},
			    new  Group { GroupName ="RED", GroupCode ="RE"},
			    new  Group { GroupName ="White", GroupCode ="WH"},
			    new  Group { GroupName ="Two Colors", GroupCode ="TT"},
			};

			Dictionary<String, Group> group = groupList.ToDictionary(x => x.GroupCode, x => x);
			context.Groups.AddRange(group.Values);

			//Loading warehouse data to the database
			List<Warehouse> warehouseList = new List<Warehouse>  {
				new  Warehouse { WarehouseID=1,WarehouseName="BQT"},
				new  Warehouse { WarehouseID=2,WarehouseName="CARL"},
				new  Warehouse { WarehouseID=3,WarehouseName="ECLO"},
			    new  Warehouse { WarehouseID=4,WarehouseName="ERIC"},
			    new  Warehouse { WarehouseID=5,WarehouseName="MATS"},
			    new  Warehouse { WarehouseID=6,WarehouseName="ORCHI"},
			    new  Warehouse { WarehouseID=7,WarehouseName="SHINE"},
			    new  Warehouse { WarehouseID=8,WarehouseName="KARE9"},
			    new  Warehouse { WarehouseID=9,WarehouseName="TWIG3"},
				new  Warehouse { WarehouseID=10,WarehouseName="MISCMA"},
		        new  Warehouse { WarehouseID=11,WarehouseName="SOUT9"},
				new  Warehouse { WarehouseID=12,WarehouseName="ROLL"},
				new  Warehouse { WarehouseID=13,WarehouseName="VIDAL"},
				new  Warehouse { WarehouseID=14,WarehouseName="MOSA"},
				new  Warehouse { WarehouseID=15,WarehouseName="JEAN8"},
				new  Warehouse { WarehouseID=16,WarehouseName="HFM"},
				new  Warehouse { WarehouseID=17,WarehouseName="VEGAS"},
			};
			Dictionary<int, Warehouse> warehouse = warehouseList.ToDictionary(x => x.WarehouseID, x => x);
			context.Warehouses.AddRange(warehouse.Values);


			//Loading Farm data to the database
			List<Farm>FarmList = new List<Farm>()  {
				new  Farm { FarmID=1,FarmName="Qualisa",Phone="593484427",Email="qualisa@qualisa.com" },
				new  Farm { FarmID=2,FarmName="Ecuatorian'",Phone="593556879",Email="ecuatorian@ecuatorian.com" },
				new  Farm { FarmID=3,FarmName="Welyflor",Phone="593556543",Email="welyflor@welyflor.com" },
				new  Farm { FarmID=4,FarmName="Inroses",Phone="593566543",Email="inroses@inroses.com" },

			};

			Dictionary<int, Farm> farms = FarmList.ToDictionary(x => x.FarmID, x => x);
			context.Farms.AddRange(farms.Values);

			//Loading BoxPurchase data to the database
			List<BoxPurchase> boxPurchaseList = new List<BoxPurchase>()  {
				new  BoxPurchase { PurchaseID=1,Box=boxes[3],Quantity=2 },
				new  BoxPurchase { PurchaseID=2,Box=boxes[2],Quantity=10 },
				new  BoxPurchase { PurchaseID=3,Box=boxes[1],Quantity=4 },
				new  BoxPurchase { PurchaseID=4,Box=boxes[3],Quantity=5 },
				new  BoxPurchase { PurchaseID=5,Box=boxes[1],Quantity=8 },
				new  BoxPurchase { PurchaseID=6,Box=boxes[2],Quantity=6 },

			};

			var boxPurchase = boxPurchaseList.ToDictionary(x => Tuple.Create(x.PurchaseID,x.BoxID), x => x);
			context.BoxPurchases.AddRange(boxPurchase.Values);


			//Loading Rose data to the database
			List<Rose> RoseList = new List<Rose>()  {
				new  Rose { RoseID=1,RoseName="Cream de la Creme",GroupCode="CR" },
				new  Rose { RoseID=2,RoseName="Vendela",GroupCode="CR" },
				new  Rose { RoseID=3,RoseName="Green Tea",GroupCode="GR" },
			    new  Rose { RoseID=4,RoseName="Full Mix Color",GroupCode="MIX" },
				new  Rose { RoseID=5,RoseName="Cayenne",GroupCode="OR" },
				new  Rose { RoseID=6,RoseName="OrangeCabaret Crush",GroupCode="OR" },
				new  Rose { RoseID=7,RoseName="Carrousel",GroupCode="PI" },
				new  Rose { RoseID=8,RoseName="Freedom",GroupCode="RE" },
				new  Rose { RoseID=9,RoseName="Cabaret",GroupCode="TT" },
				new  Rose { RoseID=10,RoseName="Tibet",GroupCode="WH" },
				new  Rose { RoseID=11,RoseName="Free Spirit",GroupCode="OR" },

			};

			Dictionary<int, Rose> roses = RoseList.ToDictionary(x => x.RoseID, x => x);
			context.Roses.AddRange(roses.Values);

			//Loading size data to the database
			List<Size> sizeList = new List<Size>()  {
				new  Size { SizeID=1,SizeName="40",Freight=0.16f },
				new  Size { SizeID=2,SizeName="50",Freight=0.18f },
				new  Size { SizeID=3,SizeName="40/50",Freight=0.17f },
				new  Size { SizeID=4,SizeName="60",Freight=0.20f },
				new  Size { SizeID=5,SizeName="50/60",Freight=0.19f },
				new  Size { SizeID=6,SizeName="70",Freight=0.22f },
			};
		

			Dictionary<int, Size> sizes = sizeList.ToDictionary(x => x.SizeID, x => x);
			context.Sizes.AddRange(sizes.Values);


			//Loading RoseSize data to the database
			List<RoseSize> RoseSizeList = new List<RoseSize>()  {
				new  RoseSize { RoseSizeID=1,RoseID=1,SizeID=1 },
				new  RoseSize { RoseSizeID=2,RoseID=2,SizeID=2 },
				new  RoseSize { RoseSizeID=3,RoseID=3,SizeID=3 },
			    new  RoseSize { RoseSizeID=4,RoseID=4,SizeID=2 },
				new  RoseSize { RoseSizeID=5,RoseID=5,SizeID=2 },
				new  RoseSize { RoseSizeID=6,RoseID=7,SizeID=4 },
				new  RoseSize { RoseSizeID=7,RoseID=8,SizeID=2 },
				new  RoseSize { RoseSizeID=8,RoseID=9,SizeID=2 },
				new  RoseSize { RoseSizeID=9,RoseID=10,SizeID=2 },
				new  RoseSize { RoseSizeID=10,RoseID=11,SizeID=1 },

			};


			Dictionary<int, RoseSize> roseSize = RoseSizeList.ToDictionary(x => x.RoseSizeID, x => x);
			context.RoseSizes.AddRange(roseSize.Values);

			//Loading size data to the database
			List<Invoice> invoicesList = new List<Invoice>()  {
				new  Invoice {InvoiceID= 1233, Date = DateTime.ParseExact("01-02-2021","dd-MM-yyyy",null),TotalAmount=70, FarmID=1  },
			    new  Invoice {InvoiceID= 1234, Date = DateTime.ParseExact("01-02-2021","dd-MM-yyyy",null),TotalAmount=70, FarmID=1  },
				new  Invoice {InvoiceID= 2244, Date = DateTime.ParseExact("02-02-2021","dd-MM-yyyy",null),TotalAmount=70, FarmID=2 },
			    new  Invoice {InvoiceID= 3124, Date = DateTime.ParseExact("02-02-2021","dd-MM-yyyy",null),TotalAmount=70, FarmID=3 },
				new  Invoice {InvoiceID= 4124, Date = DateTime.ParseExact("06-03-2021","dd-MM-yyyy",null),TotalAmount=90, FarmID=4 },
				new  Invoice {InvoiceID= 5124, Date = DateTime.ParseExact("20-03-2021","dd-MM-yyyy",null),TotalAmount=65, FarmID=2 },

			};

			Dictionary<int, Invoice> invoices = invoicesList.ToDictionary(x => x.InvoiceID, x => x);
			context.Invoices.AddRange(invoices.Values);


			
			//Loading order data the database
			List<Order> OrderList = new List<Order>()  {
				new  Order {OrderID =1,RoseSizeID=1,Number_of_bunches=52 },
				new  Order {OrderID =2,RoseSizeID=2,Number_of_bunches=22 },
				new  Order {OrderID =3,RoseSizeID=3,Number_of_bunches=7 },
				new  Order {OrderID =4,RoseSizeID=4,Number_of_bunches=15 },
				new  Order {OrderID =5,RoseSizeID=5,Number_of_bunches=176 },
				new  Order {OrderID =6,RoseSizeID=7,Number_of_bunches=9 },
				new  Order {OrderID =7,RoseSizeID=8,Number_of_bunches=139 },
				new  Order {OrderID =8,RoseSizeID=9,Number_of_bunches=14 },
				new  Order {OrderID =9,RoseSizeID=10,Number_of_bunches=6 },
				new  Order {OrderID =10,RoseSizeID=6,Number_of_bunches=12 },

			};

			Dictionary<int, Order> order = OrderList.ToDictionary(x => x.OrderID, x => x);
			context.Orders.AddRange(order.Values);

			//Loading Inventory data to the database
			List<Inventory> inventoryList = new List<Inventory>()  {
				new  Inventory { InventoryID=1,FarmID=1,RoseSizeID=2,Price_per_stem=0.30f },
				new  Inventory { InventoryID=2,FarmID=2,RoseSizeID=4,Price_per_stem=0.40f },
				new  Inventory { InventoryID=3,FarmID=3,RoseSizeID=3,Price_per_stem=0.45f },
				new  Inventory { InventoryID=4,FarmID=4,RoseSizeID=4,Price_per_stem=0.30f },
				new  Inventory { InventoryID=5,FarmID=1,RoseSizeID=2,Price_per_stem=0.30f },
				new  Inventory { InventoryID=6,FarmID=2,RoseSizeID=7,Price_per_stem=0.30f },
				new  Inventory { InventoryID=7,FarmID=2,RoseSizeID=5,Price_per_stem=0.40f },
			};


			Dictionary<int, Inventory> inventory = inventoryList.ToDictionary(x => x.InventoryID, x => x);
			context.Inventories.AddRange(inventory.Values);


			//Loading purchase data to the database
			List<Purchase> purchaseList = new List<Purchase>()  {
				new Purchase {PurchaseID =1 , FarmID = 1, RoseSizeID =3,Price_per_stem=0.25f,InvoiceID=1233,WarehouseID=1 },
				new Purchase {PurchaseID =2 , FarmID = 1, RoseSizeID =4,Price_per_stem=0.28f,InvoiceID=1234,WarehouseID=2 },
				new Purchase {PurchaseID =3 , FarmID = 3, RoseSizeID =3,Price_per_stem=0.30f,InvoiceID=3124,WarehouseID=3 },
				new Purchase {PurchaseID =4 , FarmID = 4, RoseSizeID =6,Price_per_stem=0.29f,InvoiceID=4124,WarehouseID=4 },
				new Purchase {PurchaseID =5 , FarmID = 2, RoseSizeID =1,Price_per_stem=0.30f,InvoiceID=2244,WarehouseID=1 },
				new Purchase {PurchaseID =6 , FarmID = 2, RoseSizeID =2,Price_per_stem=0.39f,InvoiceID=5124,WarehouseID=1 },
			};

			Dictionary<int, Purchase> purchase = purchaseList.ToDictionary(x => x.PurchaseID, x => x);
			context.Purchases.AddRange(purchase.Values);

			// Loading BoxInventory data to the database
			List<BoxInventory> boxInventoryList = new List<BoxInventory>()  {
				new  BoxInventory {InventoryID=1,BoxID=2,Quantity=2 },
				new  BoxInventory {InventoryID=2,BoxID=3,Quantity=10 },
				new  BoxInventory {InventoryID=3,BoxID=1,Quantity=4 },
				new  BoxInventory {InventoryID=4,BoxID=3,Quantity=5 },
				new  BoxInventory {InventoryID=5,BoxID=3,Quantity=9 },
			    new  BoxInventory {InventoryID=6,BoxID=1,Quantity=3 },
				new  BoxInventory {InventoryID=7,BoxID=2,Quantity=2 },

			};

			Dictionary<int, BoxInventory> boxInventory = boxInventoryList.ToDictionary(x => x.InventoryID, x => x);
			context.BoxInventories.AddRange(boxInventory.Values);

			context.SaveChanges();
		}
	}
}
