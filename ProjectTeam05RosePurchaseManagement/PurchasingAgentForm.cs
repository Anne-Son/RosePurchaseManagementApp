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

            //event handlers for buttons, listbox and datagridview
            //purchasingAgentForm
            buttonPurchase.Click += ButtonPurchase_Click;
            buttonSelect.Click += ButtonSelect_Click;
            buttonDelete.Click += ButtonDelete_Click;
            buttonUpdatePurchase.Click += ButtonUpdatePurchase_Click;

            dataGridViewPurchase.SelectionChanged += (s, e) => GetPurchaseBoxQuantitiesData();

            //Invoice form
            buttonInvoiceAdd.Click += ButtonInvoiceAdd_Click;
            buttonInvoiceUpdate.Click += ButtonInvoiceUpdate_Click;
            buttonInvoiceDelete.Click += ButtonInvoiceDelete_Click;

            listBoxInvoice.SelectedIndexChanged += (s,e) => GetInvoiceID();

        }

        private void ButtonUpdatePurchase_Click(object sender, EventArgs e)
        {
            var selectedPurchase = dataGridViewPurchase.SelectedRows
                .OfType<DataGridViewRow>()
                .ToArray();

            foreach (var row in selectedPurchase)
            {
                using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
                {
                    var purch = (PurchaseBoxQuantity)row.DataBoundItem;
                    Purchase purchase = context.Purchases.Where(x => x.PurchaseID == purch.PurchaseID).FirstOrDefault();

                    string selectedFarm = textBoxFarmName.Text.Trim();
                    int selectedInvoice = int.Parse(textBoxInvoiceID.Text);
                    string selectedRoseName = textBoxRoseSizeID.Text.Trim();

                    var roseSizeID = context.Roses.Where(r => r.RoseName == selectedRoseName).FirstOrDefault();

                    //get the farmId for the selected farm
                    var farmID = context.Farms.Where(f => f.FarmName == selectedFarm).FirstOrDefault();

                    purchase.FarmID = farmID.FarmID;
                    purchase.RoseSizeID = roseSizeID.RoseID;
                    purchase.Price_per_stem = float.Parse(textBoxPricePerStem.Text);
                    purchase.InvoiceID = int.Parse(textBoxInvoiceID.Text);
                    purchase.WarehouseID = listBoxWarehouse.SelectedIndex + 1;
                    
                    Controller<RosePurchaseManagementEntities, Purchase>.UpdateEntity(purchase);

                    BoxPurchase boxPurchase = context.BoxPurchases.Where(b => b.PurchaseID == purch.PurchaseID).FirstOrDefault();
                    boxPurchase.PurchaseID = purchase.PurchaseID;
                    boxPurchase.BoxID = listBoxBox.SelectedIndex + 1;
                    boxPurchase.Quantity = int.Parse(textBoxQuantity.Text);
                    Controller<RosePurchaseManagementEntities, BoxPurchase>.UpdateEntity(boxPurchase);
                }
            }
            UpdatePurchase();
        }

        private void GetPurchaseBoxQuantitiesData()
        {
            PurchaseBoxQuantity purchaseBoxQuantity = (PurchaseBoxQuantity)dataGridViewPurchase.CurrentRow.DataBoundItem;

            textBoxFarmName.Text = purchaseBoxQuantity.FarmName.ToString();
            textBoxRoseSizeID.Text = purchaseBoxQuantity.RoseName.ToString();
            textBoxPricePerStem.Text = purchaseBoxQuantity.Price.ToString();
            textBoxInvoiceID.Text = purchaseBoxQuantity.InvoiceNumber.ToString();
            textBoxQuantity.Text = purchaseBoxQuantity.BoxQuantity.ToString();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            //To get the selected row from the purchase table
            var selectedPurchase = dataGridViewPurchase.SelectedRows
                 .OfType<DataGridViewRow>()
                 .ToArray();

            foreach (var row in selectedPurchase)
            {
                using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
                {
                    var purch = (PurchaseBoxQuantity)row.DataBoundItem;
                    Purchase purchase = context.Purchases.Where(x => x.PurchaseID == purch.PurchaseID).FirstOrDefault();

                    BoxPurchase boxPurchase = context.BoxPurchases.Where(b => b.PurchaseID == purch.PurchaseID).FirstOrDefault();
                    context.Purchases.Remove(purchase);
                    context.BoxPurchases.Remove(boxPurchase);
                    context.SaveChanges();
                }
            }
            UpdatePurchase();
        }

        private void GetInvoiceID()
        {
            if (!(listBoxInvoice.SelectedItem is Invoice invoice))
                return;
            textBoxInvoiceID.Text = invoice.InvoiceID.ToString();
        }

        private void ButtonInvoiceDelete_Click(object sender, EventArgs e)
        {
            //To get the selected row from the invoice table
            var selectedInvoice = dataGridViewInvoice.SelectedRows
                 .OfType<DataGridViewRow>()
                 .ToArray();

            foreach (var row in selectedInvoice)
            {
                using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
                {
                    var inv = (Invoice)row.DataBoundItem;
                    Invoice invoice = context.Invoices.Where(x => x.InvoiceID == inv.InvoiceID).FirstOrDefault();
                    context.Invoices.Remove(invoice);
                    context.SaveChanges();
                }
            }
            UpdateInvoice();
        }

        private void ButtonInvoiceUpdate_Click(object sender, EventArgs e)
        {
            //To get the selected row from the invoice table
            var selectedInvoice = dataGridViewInvoice.SelectedRows
                 .OfType<DataGridViewRow>()
                 .ToArray();
            foreach (var row in selectedInvoice)
            {
                using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
                {
                    var inv = (Invoice)row.DataBoundItem;
                    Invoice invoice = context.Invoices.Where(x => x.InvoiceID == inv.InvoiceID).FirstOrDefault();
                    string selectedFarm = listBoxFarms.SelectedItem.ToString();
                    var farmID = context.Farms.Where(f => f.FarmName == selectedFarm).FirstOrDefault();

                    // invoice.InvoiceID = int.Parse(textBoxInvoiceNumber.Text);
                    invoice.Date = dateTimePickerInvoice.Value;
                    invoice.TotalAmount = float.Parse(textBoxTotalAmount.Text.Trim());
                    invoice.FarmID = farmID.FarmID;

                    Controller<RosePurchaseManagementEntities, Invoice>.UpdateEntity(invoice);
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
            dataGridViewSuppliersInventory.DataSource = GetSupplierInventory();
            dataGridViewSuppliersInventory.Columns["Inventory"].Visible = false;
            dataGridViewSuppliersInventory.Columns["BoxInventory"].Visible = false;

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
            dataGridViewPurchase.ClearSelection();

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
            public string RoseName { get; set; }
            public int NumberOfBunches { get; set; }
        }
    }
}
