using EFControllerUtilities;
using RosePurchaseManagementCodeFirstFromDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeam05RosePurchaseManagement
{
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();

            //set up database and controls when form loads

            this.Load += (s, e) => SupplierInventory_Load();
        }

        private void SupplierInventory_Load()
        {
            dataGridViewFlowers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFlowers.ReadOnly = true;
            dataGridViewFlowers.AllowUserToAddRows = false;
            dataGridViewFlowers.DataSource = GetSupplierInventory();
            dataGridViewFlowers.Columns["Inventory"].Visible = false;
            dataGridViewFlowers.Columns["BoxInventory"].Visible = false;
        }


        List<SupplierInventory> GetSupplierInventory()
        {
            List<SupplierInventory> supplierInventories = new List<SupplierInventory>();
            List<Inventory> inventory = (List<Inventory>)Controller<RosePurchaseManagementEntities, Inventory>.GetEntitiesWithIncluded("BoxInventories", "Farm");
            List<Box> box = (List<Box>)Controller<RosePurchaseManagementEntities, Box>.GetEntitiesWithIncluded("BoxInventories");

            foreach (Inventory inventories in inventory)
            {
                foreach (BoxInventory boxes in inventories.BoxInventories)
                {
                    SupplierInventory supplierInventory = new SupplierInventory()
                    {
                        InventoryID = inventories.InventoryID,
                        FarmID = inventories.FarmID, 
                        FarmName = inventories.Farm.FarmName,
                        RoseSizeID = inventories.RoseSizeID,
                        Price = inventories.Price_per_stem,
                        BoxID = boxes.BoxID,
                        Quantity = boxes.Quantity,
                        
                    };
                    using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
                    {
                        var roseName = context.RoseSizes.Include("Rose").Where(x => x.RoseSizeID == inventories.RoseSizeID).Select(r => r.Rose.RoseName).FirstOrDefault();
                        supplierInventory.RoseName = roseName;
                    }
                        supplierInventories.Add(supplierInventory);
                }
            }
            return supplierInventories;
        }
        private class SupplierInventory
        {
            [DisplayName("Inventory ID")]
            public int InventoryID { get; set; }

            [DisplayName("Farm ID")]
            public int FarmID { get; set; }

            [DisplayName("Farm Name")]
            public string FarmName { get; set; }

            [DisplayName("Rose Size ID")]
            public int RoseSizeID { get; set; }

            [DisplayName("Rose Name")]
            public string RoseName { get; set; }

            [DisplayName("Price per stem")]
            public float Price { get; set; }

            [DisplayName("Box ID")]
            public int BoxID { get; set; }

            [DisplayName("Quantity")]
            public int Quantity { get; set; }

            public Inventory Inventory { get; set; }

            public BoxInventory BoxInventory { get; set; }

        }
    }
}
