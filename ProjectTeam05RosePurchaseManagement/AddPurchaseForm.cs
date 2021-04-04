using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFControllerUtilities;
using RosePurchaseManagementCodeFirstFromDB;

namespace ProjectTeam05RosePurchaseManagement
{
    public partial class AddPurchaseForm : Form
    {
        /// <summary>
        /// Set up Load, Click and FormClosed event handlers.
        /// </summary>
        public AddPurchaseForm()
        {
            InitializeComponent();

            this.Load += AddPurchase_Load;

            buttonAddPurchase.Click += ButtonAddPurchase_Click;

            listBoxSuppliersInventory.SelectedIndexChanged += (s, e) => GetInventories();
        }

        private void GetInventories()
        {
            if (!(listBoxSuppliersInventory.SelectedItem is Inventory inventory))
                return;
            textBoxFarmName.Text = inventory.Farm.FarmName.ToString();
            textBoxRoseSizeID.Text = inventory.RoseSizeID.ToString();
            textBoxPricePerStem.Text = inventory.Price_per_stem.ToString();

        }

        /// <summary>
        /// Add an order from Supliers Inventory, Quantity of boxes and Warehouse that user selects.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddPurchase_Click(object sender, EventArgs e)
        {

            if (listBoxSuppliersInventory.SelectedIndex < 0 || listBoxBox.SelectedIndex < 0 || textBoxQuantity.Text == "" || listBoxWarehouse.SelectedIndex < 0)
            {
                MessageBox.Show("Inventory, Box and Warehouse must be selected. Quantity must be inserted");
                return;
            }
            using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
            {
                Purchase purchase = new Purchase();
                string selectedFarm = textBoxFarmName.Text.Trim();
                string selectedWarehouse = listBoxWarehouse.SelectedItem.ToString();

                var farmID = context.Inventories.Include("Farm").Where(f => f.Farm.FarmName == selectedFarm).FirstOrDefault();

                var warehouseID = context.Warehouses.Where(w => w.WarehouseName == selectedWarehouse).FirstOrDefault();

              
                purchase.FarmID = farmID.FarmID;
                purchase.RoseSizeID = int.Parse(textBoxRoseSizeID.Text);
                purchase.Price_per_stem = float.Parse(textBoxPricePerStem.Text);
                purchase.InvoiceID = int.Parse(textBoxInvoiceID.Text);
                purchase.WarehouseID = warehouseID.WarehouseID;
                
            }

            BoxPurchase boxPurchase = new BoxPurchase()
            {
                Quantity = Int32.Parse(textBoxQuantity.Text),
            };

           // Controller<RosePurchaseManagementEntities, Purchase>.AddEntity(purchase);
            Controller<RosePurchaseManagementEntities, BoxPurchase>.AddEntity(boxPurchase);

            this.DialogResult = DialogResult.OK;

            Close();

        }

        private void AddPurchase_Load(object sender, EventArgs e)
        {
            
            var inventory = Controller<RosePurchaseManagementEntities, Inventory>.SetBindingList().ToList();
            var inventoryList = inventory.Select(x => new { x.InventoryID, x.FarmID, x.RoseSizeID, x.Price_per_stem }).ToList();

            var box = Controller<RosePurchaseManagementEntities, Box>.GetEntitiesWithIncluded("BoxPurchases").ToList();
            var boxList = box.Select(x => x.BoxName).ToList();

            var warehouse = Controller<RosePurchaseManagementEntities, Warehouse>.GetEntitiesWithIncluded("Purchases").ToList();
            var warehouseList = warehouse.Select(x => x.WarehouseName).ToList();

            //bind the listbox to the relevant table

            listBoxSuppliersInventory.DataSource = inventoryList;
            listBoxBox.DataSource = boxList;
            listBoxWarehouse.DataSource = warehouseList;

            //nothing is selected to start, and only one of each can be selected. 
            listBoxSuppliersInventory.SelectionMode = SelectionMode.One;
            listBoxSuppliersInventory.SelectedIndex = -1;
            listBoxBox.SelectionMode = SelectionMode.One;
            listBoxBox.SelectedIndex = -1;
            listBoxWarehouse.SelectionMode = SelectionMode.One;
            listBoxWarehouse.SelectedIndex = -1;

            textBoxQuantity.ResetText();

        }
    }
}
