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







			context.SaveChanges();
		}
	}
}
