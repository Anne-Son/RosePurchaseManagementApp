using EFControllerUtilities;
using RosePurchaseManagementCodeFirstFromDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeam05RosePurchaseManagement
{
    public partial class PurchasingAgentForm : Form
    {
        public PurchasingAgentForm()
        {
            InitializeComponent();

            //set up database and controls when form loads

            this.Load += (s, e) => PurchasingAgentForm_Load();

            buttonPurchase.Click += ButtonPurchase_Click;
            buttonSelect.Click += ButtonSelect_Click;
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            Inventory inventory = (Inventory)dataGridViewSuppliersInventory.CurrentRow.DataBoundItem;

            textBoxFarmName.Text = inventory.Farm.FarmName.ToString();
            textBoxRoseSizeID.Text = inventory.RoseSizeID.ToString();
            textBoxPricePerStem.Text = inventory.Price_per_stem.ToString();
        }

        private void ButtonPurchase_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            BoxPurchase boxPurchase = new BoxPurchase();

            if (!(listBoxWarehouse.SelectedItem is Warehouse warehouse))
            {
                MessageBox.Show("Warehouse to be selected");
                return;
            }
            if (!(listBoxBox.SelectedItem is Box box))
            {
                MessageBox.Show("Box to be selected");
                return;
            }
            using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
            {
                
                //select the item from the listbox
                string selectedFarm = textBoxFarmName.Text.Trim();
                string selectedWarehouse = listBoxWarehouse.SelectedItem.ToString();
                string selectedBox = listBoxBox.SelectedItem.ToString();

                //get the farmId for the selected farm
                var farmID = context.Farms.Where(f => f.FarmName == selectedFarm).FirstOrDefault();

                purchase.FarmID = farmID.FarmID;
                purchase.RoseSizeID = int.Parse(textBoxRoseSizeID.Text);
                purchase.Price_per_stem = float.Parse(textBoxPricePerStem.Text);
                purchase.WarehouseID = listBoxWarehouse.SelectedIndex + 1;

               // boxPurchase.PurchaseID = purchase.PurchaseID;
                //boxPurchase.BoxID = listBoxBox.SelectedIndex + 1;
              //  boxPurchase.Quantity = int.Parse(textBoxQuantity.Text);

               // Controller<RosePurchaseManagementEntities, Purchase>.AddEntity(purchase);
               // Controller<RosePurchaseManagementEntities, BoxPurchase>.AddEntity(boxPurchase);
            }
            //add purchase to the list using controller
            if (Controller<RosePurchaseManagementEntities, Purchase>.AddEntity(purchase) == null)
             {
                MessageBox.Show("cannot add purchase to database");
                return;
            }
            //if (Controller<RosePurchaseManagementEntities, BoxPurchase>.AddEntity(boxPurchase) == null)
            //{
            //    MessageBox.Show("cannot add boxpurchase to database");
            //    return;
            //}
            UpdatePurchase();
        }

        private void AddOrUpdateForm<T>(DataGridView dataGridView, Form form) where T : class
        {
            var result = form.ShowDialog();

            // form has closed

            if (result == DialogResult.OK)
            {
                // reload the db and update the gridview

                dataGridView.DataSource = Controller<RosePurchaseManagementEntities, T>.SetBindingList();

                // update the customer orders report

                UpdatePurchase();
            }

            // do not close, as the form object will be disposed, 
            // just hide the form (make it invisible). 
            // 
            // when the inputForm is opened again (ShowDialog()), the Load event will fire
            //  and the form will be reinitialized

            form.Hide();
        }
        public void UpdatePurchase()
        {
            //set gridview datasource to the query result
            dataGridViewPurchase.DataSource = GetPurchaseBoxQuantities();
            dataGridViewPurchase.Columns["Purchase"].Visible = false;
            dataGridViewPurchase.Columns["BoxPurchase"].Visible = false;
        }

        private void PurchasingAgentForm_Load()
        {
            dataGridViewSuppliersInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSuppliersInventory.ReadOnly = true;
            dataGridViewSuppliersInventory.AllowUserToAddRows = false;
            dataGridViewSuppliersInventory.DataError += (s, e) => HandleDataError<Inventory>(s as DataGridView, e);
            dataGridViewSuppliersInventory.DataSource = Controller<RosePurchaseManagementEntities, Inventory>.GetEntitiesWithIncluded("BoxInventories","Farm");
            dataGridViewSuppliersInventory.Columns["BoxInventories"].Visible = false;
            dataGridViewSuppliersInventory.Columns["RoseSize"].Visible = false;


            dataGridViewPurchase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPurchase.ReadOnly = true;
            dataGridViewPurchase.AllowUserToAddRows = false;
            dataGridViewPurchase.DataSource = GetPurchaseBoxQuantities();
            dataGridViewPurchase.Columns["Purchase"].Visible = false;
            dataGridViewPurchase.Columns["BoxPurchase"].Visible = false;


            //bind the listbox to the relevant table

            listBoxInvoice.DataSource = Controller<RosePurchaseManagementEntities, Invoice>.GetEntitiesWithIncluded("Farm");
            listBoxBox.DataSource = Controller<RosePurchaseManagementEntities, Box>.GetEntitiesWithIncluded("BoxPurchases");
            listBoxWarehouse.DataSource = Controller<RosePurchaseManagementEntities, Warehouse>.GetEntitiesWithIncluded("Purchases");

            //nothing is selected to start, and only one of each can be selected. 
            listBoxInvoice.SelectionMode = SelectionMode.One;
            listBoxInvoice.SelectedIndex = -1;
            listBoxBox.SelectionMode = SelectionMode.One;
            listBoxBox.SelectedIndex = -1;
            listBoxWarehouse.SelectionMode = SelectionMode.One;
            listBoxWarehouse.SelectedIndex = -1;

            textBoxQuantity.ResetText();
        }

        private void HandleDataError<T>(DataGridView dataGridView, DataGridViewDataErrorEventArgs e) 
        {
            Debug.WriteLine("DataError " + typeof(T) + " " + dataGridView.Name + " row " + e.RowIndex + " col " + e.ColumnIndex + " Context: " + e.Context.ToString());
            e.Cancel = true;
        }

        List<PurchaseBoxQuantity> GetPurchaseBoxQuantities()
        {
            List<PurchaseBoxQuantity> purchaseBoxQuantities = new List<PurchaseBoxQuantity>();
            List<Purchase> purchases = (List<Purchase>)Controller<RosePurchaseManagementEntities, Purchase>.GetEntitiesWithIncluded("BoxPurchases", "RoseSize", "Farm", "Invoice", "Warehouse");
            List<Box> boxes = (List<Box>)Controller<RosePurchaseManagementEntities, Box>.GetEntitiesWithIncluded("BoxPurchases");

            foreach (Purchase purchase in purchases)
            {
                foreach (BoxPurchase boxPurchase in purchase.BoxPurchases)
                {
                    PurchaseBoxQuantity purchaseBoxQuantity = new PurchaseBoxQuantity()
                    {
                        PurchaseID = purchase.PurchaseID,
                        FarmName = purchase.Farm.FarmName,
                        Price = purchase.Price_per_stem,
                        InvoiceNumber = purchase.InvoiceID,
                        WarehouseName = purchase.Warehouse.WarehouseName,
                        BoxQuantity = boxPurchase.Quantity
                    };
                    using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
                    {
                        var roseName = context.RoseSizes.Include("Rose").Where(x => x.RoseSizeID == purchase.RoseSizeID).Select(r => r.Rose.RoseName).FirstOrDefault();
                        purchaseBoxQuantity.RoseName = roseName;

                        var boxType = context.BoxPurchases.Include("Box").Where(x => x.BoxID == boxPurchase.BoxID).Select(t => t.Box.BoxName).FirstOrDefault();
                        purchaseBoxQuantity.BoxName = boxType;
                    }

                    purchaseBoxQuantities.Add(purchaseBoxQuantity);
                }
            }
            return purchaseBoxQuantities;
        }
        private class PurchaseBoxQuantity
        {
            [DisplayName("PurchaseID")]
            public int PurchaseID { get; set; }

            [DisplayName("Farm Name")]
            public string FarmName { get; set; }

            [DisplayName("Rose Name")]
            public string RoseName { get; set; }

            [DisplayName("Price Per Stem")]
            public float Price { get; set; }

            [DisplayName("InvoiceNumber")]
            public int? InvoiceNumber { get; set; }

            [DisplayName("Warehouse Name")]
            public string WarehouseName { get; set; }

            [DisplayName("BoxType")]
            public string BoxName { get; set; }

            [DisplayName("BoxQuantity")]
            public int? BoxQuantity { get; set; }

            public Purchase Purchase { get; set; }

            public BoxPurchase BoxPurchase { get; set; }


        }
    }
}
