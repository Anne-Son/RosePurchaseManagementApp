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
            buttonDelete.Click += ButtonDelete_Click;

            buttonInvoiceAdd.Click += ButtonInvoiceAdd_Click;
            buttonInvoiceUpdate.Click += ButtonInvoiceUpdate_Click;
            buttonInvoiceDelete.Click += ButtonInvoiceDelete_Click;

            listBoxInvoice.SelectedIndexChanged += (s,e) => GetInvoiceID();

            

        }

       

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void GetInvoiceID()
        {
            if (!(listBoxInvoice.SelectedItem is Invoice invoice))
                return;
            textBoxInvoiceID.Text = invoice.InvoiceID.ToString();
        }

        private void ButtonInvoiceDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonInvoiceUpdate_Click(object sender, EventArgs e)
        {
            using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
            {
                string selectedFarm = listBoxFarms.SelectedItem.ToString();
                var farmID = context.Farms.Where(f => f.FarmName == selectedFarm).FirstOrDefault();

                if (!(listBoxInvoice.SelectedItem is Invoice invoice))
                {
                    MessageBox.Show("Invoice must be selected");
                    return;
                }

                invoice.InvoiceID = int.Parse(textBoxInvoiceNumber.Text);
                invoice.Date = dateTimePickerInvoice.Value;
                invoice.TotalAmount = float.Parse(textBoxTotalAmount.Text.Trim());
                invoice.FarmID = farmID.FarmID;
                
                if (Controller<RosePurchaseManagementEntities, Invoice>.AddEntity(invoice) == null)
                {
                    MessageBox.Show("cannot update invoice to database");
                    return;
                }
            }
            UpdateInvoice();
        }

        private void ButtonInvoiceAdd_Click(object sender, EventArgs e)
        {
            using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
            {
                string selectedFarm = listBoxFarms.SelectedItem.ToString();
                var farmID = context.Farms.Where(f => f.FarmName == selectedFarm).FirstOrDefault();
                Invoice invoice = new Invoice()
                {
                    InvoiceID = int.Parse(textBoxInvoiceNumber.Text),
                    Date = dateTimePickerInvoice.Value,
                    TotalAmount = float.Parse(textBoxTotalAmount.Text.Trim()),
                    FarmID = farmID.FarmID,
                };
                if (Controller<RosePurchaseManagementEntities, Invoice>.AddEntity(invoice) == null)
                {
                    MessageBox.Show("cannot add invoice to database");
                    return;
                }
            }
            UpdateInvoice();
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            Inventory inventory = (Inventory)dataGridViewSuppliersInventory.CurrentRow.DataBoundItem;

            textBoxFarmName.Text = inventory.Farm.FarmName.ToString();
            textBoxRoseSizeID.Text = inventory.RoseSizeID.ToString();
            textBoxPricePerStem.Text = inventory.Price_per_stem.ToString();

            using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
            {
                var invoiceList = context.Invoices.Include("Farm").Where(x => x.FarmID == inventory.FarmID);
                listBoxInvoice.DataSource = invoiceList.ToList();
            }

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
                int selectedInvoice = int.Parse(textBoxInvoiceID.Text);

                //get the farmId for the selected farm
                var farmID = context.Farms.Where(f => f.FarmName == selectedFarm).FirstOrDefault();

                purchase.FarmID = farmID.FarmID;
                purchase.RoseSizeID = int.Parse(textBoxRoseSizeID.Text);
                purchase.Price_per_stem = float.Parse(textBoxPricePerStem.Text);
                purchase.InvoiceID = int.Parse(textBoxInvoiceID.Text);
                purchase.WarehouseID = listBoxWarehouse.SelectedIndex + 1;

               var purch = Controller<RosePurchaseManagementEntities, Purchase>.AddEntity(purchase);

                boxPurchase.PurchaseID = purch.PurchaseID;
                boxPurchase.BoxID = listBoxBox.SelectedIndex + 1;
                boxPurchase.Quantity = int.Parse(textBoxQuantity.Text);
                Controller<RosePurchaseManagementEntities, BoxPurchase>.AddEntity(boxPurchase);
            }
            //add purchase to the list using controller
            if (Controller<RosePurchaseManagementEntities, Purchase>.AddEntity(purchase) == null)
            {
                MessageBox.Show("cannot add purchase to database");
                return;
            }
      
            UpdatePurchase();
            Clear();
        }

        public void UpdatePurchase()
        {

            //set gridview datasource to the query result
            dataGridViewPurchase.DataSource = GetPurchaseBoxQuantities();
            dataGridViewPurchase.Columns["Purchase"].Visible = false;
            dataGridViewPurchase.Columns["BoxPurchase"].Visible = false;
        }
        public void UpdateInvoice()
        {
            
            //set gridview datasource to the query result
            dataGridViewInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInvoice.ReadOnly = true;
            dataGridViewInvoice.AllowUserToAddRows = false;
            dataGridViewInvoice.DataError += (s, e) => HandleDataError<Inventory>(s as DataGridView, e);
            dataGridViewInvoice.DataSource = Controller<RosePurchaseManagementEntities, Invoice>.GetEntitiesWithIncluded("Farm");
            dataGridViewInvoice.Columns["Purchases"].Visible = false;

            listBoxInvoice.DataSource = Controller<RosePurchaseManagementEntities, Invoice>.GetEntitiesWithIncluded("Farm");
        }


        private void PurchasingAgentForm_Load()
        {
            //load Order
            DisplayOrder();

            //load Inventory
            dataGridViewSuppliersInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSuppliersInventory.ReadOnly = true;
            dataGridViewSuppliersInventory.AllowUserToAddRows = false;
            dataGridViewSuppliersInventory.DataError += (s, e) => HandleDataError<Inventory>(s as DataGridView, e);
            dataGridViewSuppliersInventory.DataSource = Controller<RosePurchaseManagementEntities, Inventory>.GetEntitiesWithIncluded("BoxInventories","Farm");
            dataGridViewSuppliersInventory.Columns["BoxInventories"].Visible = false;
            dataGridViewSuppliersInventory.Columns["RoseSize"].Visible = false;

            //load invoice data 
            dataGridViewInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInvoice.ReadOnly = true;
            dataGridViewInvoice.AllowUserToAddRows = false;
            dataGridViewInvoice.DataError += (s, e) => HandleDataError<Invoice>(s as DataGridView, e);
            dataGridViewInvoice.DataSource = Controller<RosePurchaseManagementEntities, Invoice>.GetEntitiesWithIncluded("Farm");
            dataGridViewInvoice.Columns["Purchases"].Visible = false;
           // dataGridViewInvoice.Columns["RoseSize"].Visible = false;

            //load purchaseBox gridview
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
            listBoxFarms.DataSource = Controller<RosePurchaseManagementEntities, Farm>.SetBindingList();

            //nothing is selected to start, and only one of each can be selected. 
            listBoxInvoice.SelectionMode = SelectionMode.One;
            listBoxInvoice.SelectedIndex = -1;
            listBoxBox.SelectionMode = SelectionMode.One;
            listBoxBox.SelectedIndex = -1;
            listBoxWarehouse.SelectionMode = SelectionMode.One;
            listBoxWarehouse.SelectedIndex = -1;
            listBoxFarms.SelectionMode = SelectionMode.One;
            listBoxFarms.SelectedIndex = -1;

            textBoxQuantity.ResetText();
            textBoxFarmName.ResetText();
            textBoxPricePerStem.ResetText();
            textBoxRoseSizeID.ResetText();
            textBoxTotalAmount.ResetText();
                
        }
        private void Clear()
        {
            listBoxInvoice.SelectionMode = SelectionMode.One;
            listBoxInvoice.SelectedIndex = -1;
            listBoxBox.SelectionMode = SelectionMode.One;
            listBoxBox.SelectedIndex = -1;
            listBoxWarehouse.SelectionMode = SelectionMode.One;
            listBoxWarehouse.SelectedIndex = -1;
            listBoxFarms.SelectionMode = SelectionMode.One;
            listBoxFarms.SelectedIndex = -1;

            textBoxQuantity.ResetText();
            textBoxFarmName.ResetText();
            textBoxPricePerStem.ResetText();
            textBoxRoseSizeID.ResetText();
            textBoxTotalAmount.ResetText();
            textBoxInvoiceID.ResetText();
        }

        private void HandleDataError<T>(DataGridView dataGridView, DataGridViewDataErrorEventArgs e) 
        {
            Debug.WriteLine("DataError " + typeof(T) + " " + dataGridView.Name + " row " + e.RowIndex + " col " + e.ColumnIndex + " Context: " + e.Context.ToString());
            e.Cancel = true;
        }
        public void DisplayOrder()
        {
            //open the RosePurchaseEntities context
            using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
            {
                List<OrderDisplay> orderDisplayList = new List<OrderDisplay>();

                var orderList = (from rose in context.Roses
                                 from size in rose.RoseSizes
                                 from order in size.Orders
                                 select new
                                 {
                                     oderid = order.OrderID,
                                     name = rose.RoseName,
                                     bunches = order.Number_of_bunches,

                                 }).ToList();

                foreach (var order in orderList)
                {
                    OrderDisplay orderDisplay = new OrderDisplay()
                    {
                        OderId = order.oderid,
                        NumberOfBunches = order.bunches,
                        RoseName = order.name
                    };
                    orderDisplayList.Add(orderDisplay);
                }
                dataGridViewOrder.DataSource = orderDisplayList;
            }
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

                        var roseSize = context.RoseSizes.Include("Size").Where(r => r.RoseSizeID == purchase.RoseSizeID).Select(s => s.Size.SizeName).FirstOrDefault();
                        purchaseBoxQuantity.RoseSize = roseSize;

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

            [DisplayName("Rose Size")]
            public string RoseSize { get; set; }

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
        public class OrderDisplay
        {
            public int OderId { get; set; }
            public String RoseName { get; set; }
            public int NumberOfBunches { get; set; }


        }
    }
}
