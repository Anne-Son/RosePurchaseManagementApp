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
        }
        /// <summary>
        /// Add an order from Supliers Inventory, Quantity of boxes and Warehouse that user selects.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddPurchase_Click(object sender, EventArgs e)
        {
            if(listBoxSuppliersInventory.SelectedIndex < 0 || listBoxBox.SelectedIndex < 0 || textBoxQuantity.Text == "" || listBoxWarehouse.SelectedIndex < 0)
            {
                MessageBox.Show("Inventory, Box and Warehouse must be selected. Quantity must be inserted");
                return;
            }
            Inventory inventory = listBoxSuppliersInventory.SelectedItem as Inventory;
            Box box = listBoxBox.SelectedItem as Box;
            Warehouse warehouse = listBoxWarehouse.SelectedItem as Warehouse;

            Purchase purchase = new Purchase()
            {
                PurchaseID = inventory.InventoryID,
                FarmID = inventory.FarmID,
                RoseSizeID = inventory.RoseSizeID,
                Price_per_stem = inventory.Price_per_stem,
                WarehouseID = warehouse.WarehouseID,
            };

            BoxPurchase boxPurchase = new BoxPurchase()
            {
                PurchaseID = inventory.InventoryID,
                BoxID = box.BoxID,
                Quantity = Int32.Parse(textBoxQuantity.Text),
            };

            Controller<RosePurchaseManagementEntities, Purchase>.AddEntity(purchase);
            Controller<RosePurchaseManagementEntities, BoxPurchase>.AddEntity(boxPurchase);

            this.DialogResult = DialogResult.OK;

            Close();

        }

        private void AddPurchase_Load(object sender, EventArgs e)
        {
            var inventory = Controller<RosePurchaseManagementEntities, Inventory>.SetBindingList();

            var box = Controller<RosePurchaseManagementEntities, Box>.GetEntitiesWithIncluded("BoxPurchases");

            var warehouse = Controller<RosePurchaseManagementEntities, Warehouse>.GetEntitiesWithIncluded("Purchases");

            //bind the listbox to the relevant table

            listBoxSuppliersInventory.DataSource = inventory;
            listBoxBox.DataSource = box;
            listBoxWarehouse.DataSource = warehouse;

            //nothing is selected to start, and only one of each can be selected. 
            listBoxSuppliersInventory.SelectionMode = SelectionMode.One;
            listBoxSuppliersInventory.SelectedIndex = -1;
            listBoxBox.SelectionMode = SelectionMode.One;
            listBoxBox.SelectedIndex = -1;
            listBoxWarehouse.SelectionMode = SelectionMode.One;
            listBoxWarehouse.SelectedIndex = -1;

        }
    }
}
