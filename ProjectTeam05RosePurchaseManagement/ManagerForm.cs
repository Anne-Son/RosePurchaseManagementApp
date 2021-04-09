using DataTableAccessLayer;
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
    public partial class ManagerForm : Form
    {
        // field to keep the access layer field
        private SqlDataTableAccessLayer purchaseDB;
       
        // dataset will hold all tables being used
        private DataSet purchaseDataSet;

        public ManagerForm()
        {
            InitializeComponent();

            // get a new access layer and dataset
            purchaseDB = new SqlDataTableAccessLayer();

            purchaseDataSet = new DataSet()
            {
                // must be named for backup purposes

                DataSetName = "PurchaseDataSet",
            };

            //Load Manager Form 
            this.Load += (s, e) => ManagerForm_Load();

            //click listner for oderbutton
            buttonOrder.Click += ButtonOrder_Click;

            //Search Checkbox listner
            checkBoxSearch.CheckedChanged += CheckBoxSearch_CheckedChanged;

            //datepicker value change listner
            dateTimePickerStartDate.ValueChanged += DateTimePickerStartDate_ValueChanged;
            dateTimePickerEndDate.ValueChanged += DateTimePickerEndDate_ValueChanged;

            //Click Listner for deleteOrder
            buttonDeleteOrder.Click += ButtonDeleteOrder_Click;

            //Click Listner for updateOrder
            buttonUpdateOrder.Click += ButtonUpdateOrder_Click;

            buttonBackUp.Click += ButtonBackUp_Click;
            buttonRestore.Click += ButtonRestore_Click;

            listBoxWarehouse.SelectedIndexChanged += ListBoxWarehouse_SelectedIndexChanged;

            dataGridViewOrder.SelectionChanged += DataGridViewOrder_SelectionChanged;
        }
        /// <summary>
        /// Listbox change listner for Warehouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ListBoxWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayRoses();
        }
        /// <summary>
        /// Restore
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRestore_Click(object sender, EventArgs e)
        {
            // Getting connection string.
            string connectionString = purchaseDB.GetConnectionString("DatabaseConnection");
            purchaseDB.OpenConnection(connectionString);
            purchaseDB.RestoreDataSetFromBackup(purchaseDataSet);
            purchaseDB.CloseConnection();
            MessageBox.Show("Database is sucessfully restored");
        }
        /// <summary>
        /// 
        /// Backup 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBackUp_Click(object sender, EventArgs e)
        {
            // Getting connection string.
            string connectionString = purchaseDB.GetConnectionString("DatabaseConnection");
            purchaseDB.OpenConnection(connectionString);
            purchaseDB.BackupDataSetToXML(purchaseDataSet);
            purchaseDB.CloseConnection();
            MessageBox.Show("Database is sucessfully backuped");
        }

        /// <summary>
        /// Update listener of Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpdateOrder_Click(object sender, EventArgs e)
        {
            //making sure a student is selected
            if (dataGridViewOrder.SelectedRows.Count < 0)
            {
                MessageBox.Show("Order to be updated must be selected");
                return;
            }
            else
            {
                //Check whether the datafield is intialized
                if (int.TryParse(textBoxNumberOfBunches.Text, out int numberOfBunches) && (listBoxRoses.SelectedItems.Count > 0))
                {
                    //Get the row from the datagridviewOrder as Order displa
                    var selectedOrder = dataGridViewOrder.SelectedRows
                               .OfType<DataGridViewRow>()
                               .ToList();
                    var ord = (OrderDisplay)selectedOrder.Select(x => x).FirstOrDefault().DataBoundItem;

                 
                    //Create a new order
                    Order order = new Order();
                    using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
                    {
                        //Get the selected order
                         order = context.Orders.Where(i => i.OrderID == ord.OderId).FirstOrDefault();
                        //select the item from the listbox
                        String selectedRoses = listBoxRoses.SelectedItem.ToString();

                        //get the roseId for the selected roses
                        var roseSizeId = context.RoseSizes.Include("Rose").Where(r => r.Rose.RoseName == selectedRoses).FirstOrDefault();

                        //set properties ororder 
                        order.RoseSizeID = roseSizeId.RoseSizeID;
                        order.Number_of_bunches = numberOfBunches; 
                    }
                    // Update order to the list using controller
                    Controller<RosePurchaseManagementEntities, Order>.UpdateEntity(order);

                    //display orderDatagridView
                    DisplayOder();

                    //clear selected roses
                    listBoxRoses.ClearSelected();
                    //empty string
                    textBoxNumberOfBunches.Text = "";
                }
                else
                {
                    //display if data is not valid
                    MessageBox.Show("Enter the valid data");
                }
            }
        }
        /// <summary>
        /// Datagrudview change listner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewOrder_SelectionChanged(object sender, EventArgs e)
        {
            //Select the order dispaly from the datagridview
           
            var selectedOrder = dataGridViewOrder.SelectedRows
                 .OfType<DataGridViewRow>()
                 .ToList();
            //checking if something is selected from dataGridViewOrder
            if(dataGridViewOrder.SelectedRows.Count != 0)
            {
                //Get data from the selected row as OrderDisplay
                var orderDisplay = (OrderDisplay)selectedOrder.Select(x => x).FirstOrDefault().DataBoundItem;
                textBoxNumberOfBunches.Text = orderDisplay.NumberOfBunches.ToString();

                //setting the selected one in listBoxRoses
                listBoxRoses.SelectedIndex = listBoxRoses.Items.IndexOf(orderDisplay.RoseName);
            }
        }
        /// <summary>
        /// DElete order listner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeleteOrder_Click(object sender, EventArgs e)
        {
            //To get the selected row from the order table
            var selectedOrder = dataGridViewOrder.SelectedRows
                 .OfType<DataGridViewRow>()
                 .ToArray();
            //Remove each selected by selecting
            foreach (var row in selectedOrder)
            {
                using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
                {
                    var ord = (OrderDisplay)row.DataBoundItem;

                    Order order = context.Orders.Where(x => x.OrderID == ord.OderId).FirstOrDefault();
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
            }
            DisplayOder();
        }

        /// <summary>
        /// on change listner for enddate picker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateTimePickerEndDate_ValueChanged(object sender, EventArgs e)
        {
            DisplayPurchase();
        }
        /// <summary>
        /// on change listner for startdate picker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {
            DisplayPurchase();
        }
        /// <summary>
        /// event listner for checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBoxSearch_CheckedChanged(object sender, EventArgs e)
        {
            DisplayPurchase();
        }

        /// <summary>
        /// listner for oder button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOrder_Click(object sender, EventArgs e)
        {

            if(int.TryParse(textBoxNumberOfBunches.Text, out int numberOfBunches)&&(listBoxRoses.SelectedItems.Count >0))
            {
                //create an oder
                Order order = new Order();

                using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
                {
                    //select the item from the listbox
                    String selectedRoses = listBoxRoses.SelectedItem.ToString();

                    //get the roseId for the selected roses
                    var roseSizeId = context.RoseSizes.Include("Rose").Where(r => r.Rose.RoseName == selectedRoses).FirstOrDefault();
                    order.RoseSizeID = roseSizeId.RoseSizeID;
                    order.Number_of_bunches = numberOfBunches;
                }
                // add oder to the list using controller
                if (Controller<RosePurchaseManagementEntities, Order>.AddEntity(order) == null)
                {
                    MessageBox.Show("Cannot add order to database");
                    return;
                }
                //display orderDatagridView
                DisplayOder();

                //clear selected roses
                listBoxRoses.ClearSelected();
                //empty string
                textBoxNumberOfBunches.Text = "";
            }
            else
            {
                MessageBox.Show("Enter the valid data");
            }

        }
        /// <summary>
        /// Loading function for Form
        /// </summary>
        private void ManagerForm_Load()
        {
            //Initiliaze each dataGridViews Listboxes and TextBoxes
            InitializeDataGridView<Order>(dataGridViewOrder);
            InitializeDataGridView<Purchase>(dataGridViewPurchase);

            var rose = Controller<RosePurchaseManagementEntities, Rose>.GetEntities().ToList();
            var roseList = rose.Select(x => x.RoseName).ToList();
            listBoxRoses.DataSource = roseList;

            var warehouse = Controller<RosePurchaseManagementEntities, Warehouse>.GetEntities().ToList();
            var wareHouseList = warehouse.Select(x => x.WarehouseName).ToList();
            listBoxWarehouse.DataSource = wareHouseList;
            ResetDefaults();
            DisplayRoses();

            listBoxWarehouse.SelectionMode = SelectionMode.MultiExtended;
            listBoxRoses.SelectionMode = SelectionMode.One;
            listBoxRoses.SelectedIndex = -1;

            textBoxNumberOfBunches.ResetText();
            DisplayOder();
            DisplayPurchase();

        }
        public void ResetDefaults()
        { 
            //Reseting warehouseListbox
            for (int i = 0; i < listBoxWarehouse.Items.Count; i++)
                listBoxWarehouse.SetSelected(i, true);
        }
        /// <summary>
        /// Display Listbox roses
        /// </summary>

        public void DisplayRoses()
        {
            //get the selected items from the listWareHouse
            var selectedList = listBoxWarehouse.SelectedItems;
            using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
            {
                //Get each Roses in each WareHouse
                //Get the selected warehouse from the Listbox
                List<String> list = new List<String>();
                foreach(String warehouse in selectedList)
                {
                    
                    var wareHouseId = context.Warehouses.Where(x => x.WarehouseName == warehouse).Select(i => i.WarehouseID).FirstOrDefault();
                    var item = context.Purchases.Include("RoseSize").Where(x => x.WarehouseID == wareHouseId).Select(r => r.RoseSize.Rose.RoseName).FirstOrDefault();
                    list.Add(item);
                }
                listBoxRosesIn.DataSource = list;
            }
        }

        private void InitializeDataGridView<T>(DataGridView dataGridView, params string[] columnsToHide) where T : class
        {
            //Allow users to add/delete rows, and fill out columns to the entire width  of the control
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = true;
            dataGridView.ReadOnly = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataError += (s, e) => HandleDataError<T>(s as DataGridView, e);
            dataGridView.MultiSelect = false;
            
            //Hide the columns 
                foreach (string column in columnsToHide)
                    dataGridView.Columns[column].Visible = false;
        }
        /// <summary>
        /// error handling datagridview
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="gridView"></param>
        /// <param name="e"></param>
        private void HandleDataError<T>(DataGridView gridView, DataGridViewDataErrorEventArgs e)
        {
            Debug.WriteLine("DataError " + typeof(T) + " " + gridView.Name + " row " + e.RowIndex + " col " + e.ColumnIndex + " Context: " + e.Context.ToString());
            e.Cancel = true;
        }

        /// <summary>
        /// Display datagridviewOrder
        /// </summary>
        public void DisplayOder()
        {
            //open the RosePurchaseEntities context
            using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
            {
                //Create a list to display order
                List<OrderDisplay> orderDisplayList = new List<OrderDisplay>();
                
                //set up each properties for each OrderlIst Object
                var orderList = (from rose in context.Roses
                          from size in rose.RoseSizes
                          from order in size.Orders
                          select new
                          {
                              oderid = order.OrderID,
                              name = rose.RoseName,
                              bunches = order.Number_of_bunches,

                          }).ToList();

                foreach(var order in orderList)
                {
                    OrderDisplay orderDisplay = new OrderDisplay()
                    {
                        OderId = order.oderid,
                        NumberOfBunches = order.bunches,
                        RoseName = order.name
                    };
                    orderDisplayList.Add(orderDisplay);
                    
                }
                //set up datasource for dataGridViewOrder
                dataGridViewOrder.DataSource = orderDisplayList;
            }
        }
        /// <summary>
        /// Display PurchaseDatgridview
        /// </summary>
       public void DisplayPurchase()
        {
            //Create lsit of box Purchase Quatity
            List<PurchaseBoxQuantity> purchaseBoxQuantities = new List<PurchaseBoxQuantity>();

            //Get each purchases
            var purchases = Controller<RosePurchaseManagementEntities, Purchase>.GetEntitiesWithIncluded("BoxPurchases", "RoseSize", "Farm", "Invoice", "Warehouse");
            List<Box> boxes = (List<Box>)Controller<RosePurchaseManagementEntities, Box>.GetEntitiesWithIncluded("BoxPurchases");

            //Check checkbox is checked or not
            if (checkBoxSearch.Checked){

                purchases = purchases.Where(x => x.Invoice.Date >= dateTimePickerStartDate.Value).Where(x => x.Invoice.Date <= dateTimePickerEndDate.Value);
            }

            //Set up properties for each PurchaseBoxQuantity object
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
                        Total = purchase.Invoice.TotalAmount,
                        Date = purchase.Invoice.Date,
                        BoxQuantity = boxPurchase.Quantity
                    };
                    //GEt each BoxPurchase based on purchase quantity
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
            //Getting the count
            var count = purchaseBoxQuantities.Count();
            labelCount.Text = count.ToString();
            if(count != 0)
            {
                //Setting up th average
                var sum = purchaseBoxQuantities.Select(x => x.Total).Average();
                labelAveragePrice.Text = sum.ToString();
            }
            else
            {
                labelAveragePrice.Text = "";
            }
            //set up datasource of dataGridViewPurchase 
            dataGridViewPurchase.DataSource = purchaseBoxQuantities;

        }

       
        private void tabPageReport_Click(object sender, EventArgs e)
        {

        }

       /// <summary>
       /// Class to display Order 
       /// </summary>
        public class OrderDisplay
        {
            public int OderId { get; set; }
            public String RoseName { get; set; }
            public int NumberOfBunches { get; set; }
        }
        /// <summary>
        /// Class to display PurchaseBoxQuantity
        /// </summary>
        private class PurchaseBoxQuantity
        {
            [DisplayName("PurchaseID")]
            public int PurchaseID { get; set; }

            [DisplayName("Farm Name")]
            public String FarmName { get; set; }

            [DisplayName("Rose Name")]
            public String RoseName { get; set; }


            [DisplayName("Price Per Stem")]
            public float Price { get; set; }

            [DisplayName("InvoiceNumber")]
            public int? InvoiceNumber { get; set; }

            [DisplayName("Date")]
            public DateTime Date { get; set; }

            [DisplayName("Total")]
            public float Total { get; set; }

            [DisplayName("Warehouse Name")]
            public String WarehouseName { get; set; }

            [DisplayName("BoxType")]
            public String BoxName { get; set; }

            [DisplayName("BoxQuantity")]
            public int BoxQuantity { get; set; }
        }

    }
}
