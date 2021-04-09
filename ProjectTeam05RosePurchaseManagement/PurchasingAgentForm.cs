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
        int boxId;
        public PurchasingAgentForm()
        {
            InitializeComponent();

            //set up database and controls when form loads

            this.Load += (s, e) => PurchasingAgentForm_Load();

            buttonPurchase.Click += ButtonPurchase_Click;
            buttonDelete.Click += ButtonDelete_Click1;
            buttonDelete.Click += ButtonDelete_Click;

            buttonInvoiceAdd.Click += ButtonInvoiceAdd_Click;
            buttonInvoiceUpdate.Click += ButtonInvoiceUpdate_Click;
            buttonInvoiceDelete.Click += ButtonInvoiceDelete_Click;
            buttonUpdatePurchase.Click += ButtonUpdatePurchase_Click;

            listBoxInvoice.SelectedIndexChanged += (s,e) => GetInvoiceID();

           dataGridViewPurchase.SelectionChanged += DataGridViewPurchase_SelectionChanged;

            dataGridViewSuppliersInventory.SelectionChanged += DataGridViewSuppliersInventory_SelectionChanged;

            

        }

        private void ButtonDelete_Click1(object sender, EventArgs e)
        {
           
            if((dataGridViewPurchase.SelectedRows.Count <= 0))
            {
                MessageBox.Show("Please select the purchase to delete");
                return;
            }
            var selectedPurchase = dataGridViewPurchase.SelectedRows
                .OfType<DataGridViewRow>()
                .ToList();
         
            using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
            {
                var pur = (PurchaseBoxQuantity)selectedPurchase.Select(x => x).FirstOrDefault().DataBoundItem;
                var selectedBoxId = context.Boxes.Where(b => b.BoxName == pur.BoxName).Select(i => i.BoxID).FirstOrDefault();
                Purchase purchase = context.Purchases.Where(p => p.PurchaseID == pur.PurchaseID).FirstOrDefault();
                BoxPurchase boxPurchase = context.BoxPurchases.Where(b => (b.BoxID == selectedBoxId)&&(b.PurchaseID == pur.PurchaseID)).FirstOrDefault();

                context.BoxPurchases.Remove(boxPurchase);
                context.SaveChanges();

                context.Purchases.Remove(purchase);
                context.SaveChanges();
            }

            UpdatePurchase();





        }

        private void ButtonUpdatePurchase_Click(object sender, EventArgs e)
        {
            
            
            if ((listBoxWarehouse.SelectedItems.Count <0))
            {
                MessageBox.Show("Warehouse to be selected");
                return;
            }
            if ((listBoxBox.SelectedItems.Count < 0))
            {
                MessageBox.Show("Box to be selected");
                return;
            }

            var selectedPurchase = dataGridViewPurchase.SelectedRows
                  .OfType<DataGridViewRow>()
                  .ToList();
            if (dataGridViewPurchase.SelectedRows.Count != 0)
            {

                var pur = (PurchaseBoxQuantity)selectedPurchase.Select(x => x).FirstOrDefault().DataBoundItem;
                Purchase purchase = new Purchase();
                BoxPurchase boxPurchase = new BoxPurchase();

                using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
                {


                    purchase = context.Purchases.Where(x => x.PurchaseID == pur.PurchaseID).FirstOrDefault();
                    boxPurchase = context.BoxPurchases.Where(x => x.PurchaseID == pur.PurchaseID).FirstOrDefault();

                    

                    //select the item from the listbox
                    string selectedFarm = textBoxFarmName.Text.Trim();
                    int selectedInvoice = int.Parse(textBoxInvoiceID.Text);

                    //get the farmId for the selected farm
                    //var farmID = context.Farms.Where(f => f.FarmName == selectedFarm).FirstOrDefault();

                    //purchase.FarmID = farmID.FarmID;
                    purchase.RoseSizeID = int.Parse(textBoxRoseSizeID.Text);
                    purchase.Price_per_stem = float.Parse(textBoxPricePerStem.Text);
                    purchase.InvoiceID = int.Parse(textBoxInvoiceID.Text);
                    purchase.WarehouseID = listBoxWarehouse.SelectedIndex + 1;
                    context.SaveChanges();

                    if (context.BoxPurchases.Where(x => (x.PurchaseID == purchase.PurchaseID) && (x.BoxID == listBoxBox.SelectedIndex + 1)).Count() > 0)
                    {
                       
                        boxPurchase.PurchaseID = purchase.PurchaseID;
                        boxPurchase.BoxID = listBoxBox.SelectedIndex + 1;
                        boxPurchase.Quantity = int.Parse(textBoxQuantity.Text);
                        context.SaveChanges();

                    }
                    else
                    {
                        var boxSel = context.BoxPurchases.Where(x => (x.PurchaseID == purchase.PurchaseID) && (x.BoxID == boxId)).FirstOrDefault();
                        context.BoxPurchases.Remove(boxSel);
                        boxPurchase = new BoxPurchase();
                        boxPurchase.PurchaseID = purchase.PurchaseID;
                        boxPurchase.BoxID = listBoxBox.SelectedIndex + 1;
                        boxPurchase.Quantity = int.Parse(textBoxQuantity.Text);
                        context.BoxPurchases.Add(boxPurchase);
                        context.SaveChanges();
                    }


                }
                
                

                UpdatePurchase();
                Clear();
            }
            else
            {
                MessageBox.Show("Please select the purchase");
            }

        }

        private void DataGridViewSuppliersInventory_SelectionChanged(object sender, EventArgs e)
        {

            listBoxInvoice.DataSource = null;
           Inventory inventory = (Inventory)dataGridViewSuppliersInventory.CurrentRow.DataBoundItem;

            listBoxBox.ClearSelected();
            listBoxWarehouse.ClearSelected();
            textBoxQuantity.Text = null;
            textBoxFarmName.Text = inventory.Farm.FarmName.ToString();
            textBoxRoseSizeID.Text = inventory.RoseSizeID.ToString();
            textBoxPricePerStem.Text = inventory.Price_per_stem.ToString();

            using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
            {
                var invoiceList = context.Invoices.Include("Farm").Where(x => x.FarmID == inventory.FarmID).Select(x => x.InvoiceID);
                listBoxInvoice.DataSource = invoiceList.ToList();
            }
        }

        private void DataGridViewPurchase_SelectionChanged(object sender, EventArgs e)
        {

           
            dataGridViewSuppliersInventory.ClearSelection();
          
            
            
            var selectedPurchase = dataGridViewPurchase.SelectedRows
                  .OfType<DataGridViewRow>()
                  .ToList();
            if (dataGridViewPurchase.SelectedRows.Count != 0)
            {

                var pur = (PurchaseBoxQuantity)selectedPurchase.Select(x => x).FirstOrDefault().DataBoundItem;
                textBoxFarmName.Text = pur.FarmName;
                textBoxPricePerStem.Text = pur.Price.ToString();
                textBoxQuantity.Text = pur.BoxQuantity.ToString();
              
                textBoxInvoiceID.Text = pur.InvoiceNumber.ToString();


                using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
                {
                   
                    var purch = context.Purchases.Where(p => p.PurchaseID == pur.PurchaseID).FirstOrDefault();
                    var farmId = context.Farms.Where(x => x.FarmName == pur.FarmName).Select(i => i.FarmID).FirstOrDefault();

                    var inventoryId = context.Inventories.Where(x => (x.FarmID == purch.FarmID) && (x.RoseSizeID == purch.RoseSizeID)).Select(x => x.InventoryID).FirstOrDefault();
                    var invoiceList = context.Invoices.Include("Farm").Where(x => x.FarmID == farmId).Select(x => x.InvoiceID);
                    

                    listBoxInvoice.DataSource = null;
                    listBoxInvoice.DataSource = invoiceList.ToList();
                    textBoxRoseSizeID.Text = purch.RoseSizeID.ToString() ;
                    dataGridViewSuppliersInventory.SelectionChanged -= DataGridViewSuppliersInventory_SelectionChanged;
                   
                     dataGridViewSuppliersInventory.Rows[inventoryId-1].Selected = true;
                    dataGridViewSuppliersInventory.SelectionChanged += DataGridViewSuppliersInventory_SelectionChanged;
                }
               

                listBoxInvoice.SelectedIndex = listBoxInvoice.Items.IndexOf(pur.InvoiceNumber);
                listBoxWarehouse.SelectedIndex = listBoxWarehouse.Items.IndexOf(pur.WarehouseName);
                listBoxBox.SelectedIndex = listBoxBox.Items.IndexOf(pur.BoxName);
                boxId = listBoxBox.SelectedIndex+1;
              
            }
           

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
           
        }





        private void GetInvoiceID()
        {
            if (!(listBoxInvoice.SelectedItems.Count ==0))
            {
                textBoxInvoiceID.Text = listBoxInvoice.SelectedItem.ToString();
            }
            
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
                var invoiceList = context.Invoices.Include("Farm").Where(x => x.FarmID == inventory.FarmID).Select(x => x.InvoiceID);
                listBoxInvoice.DataSource = invoiceList.ToList();
            }

        }

        private void ButtonPurchase_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            BoxPurchase boxPurchase = new BoxPurchase();

            if ((listBoxWarehouse.SelectedItems.Count <0))
            {
                MessageBox.Show("Warehouse to be selected");
                return;
            }
            if ((listBoxBox.SelectedItems.Count < 0))
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

            
            
            listBoxInvoice.DataSource = Controller<RosePurchaseManagementEntities, Invoice>.GetEntitiesWithIncluded("Farm").Select(i => i.InvoiceID).ToList();
            listBoxBox.DataSource = Controller<RosePurchaseManagementEntities, Box>.GetEntitiesWithIncluded("BoxPurchases").Select(b => b.BoxName).ToList();
            listBoxWarehouse.DataSource = Controller<RosePurchaseManagementEntities, Warehouse>.GetEntitiesWithIncluded("Purchases").Select(w => w.WarehouseName).ToList();
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
