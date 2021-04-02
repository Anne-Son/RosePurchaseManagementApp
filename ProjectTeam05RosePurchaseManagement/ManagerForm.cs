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
        public ManagerForm()
        {
            InitializeComponent();
            this.Load += (s, e) => ManagerForm_Load();


            //click listner for oderbutton
            buttonOrder.Click += ButtonOrder_Click;

            //Search Checkbox listner
            checkBoxSearch.CheckedChanged += CheckBoxSearch_CheckedChanged;

            //datepicker value change listner
            dateTimePickerStartDate.ValueChanged += DateTimePickerStartDate_ValueChanged;
            dateTimePickerEndDate.ValueChanged += DateTimePickerEndDate_ValueChanged;
           


        }

        private void DateTimePickerEndDate_ValueChanged(object sender, EventArgs e)
        {
            dispalyPurchase();
        }

        private void DateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {
            dispalyPurchase();
        }

        private void CheckBoxSearch_CheckedChanged(object sender, EventArgs e)
        {
            dispalyPurchase();
        }



        /// <summary>
        /// listner for oder button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ButtonOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();

            //create an oder
            using ( RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
            {
                String selectedRoses = listBoxRoses.SelectedItem.ToString();
                var roseSizeId = context.RoseSizes.Include("Rose").Where(r => r.Rose.RoseName == selectedRoses).FirstOrDefault();
                order.RoseSizeID = roseSizeId.RoseSizeID;
                order.Number_of_bunches = int.Parse(textBoxNumberOfBunches.Text);
            }
            // add oder to the list using controller
            if (Controller<RosePurchaseManagementEntities, Order>.AddEntity(order) == null)
            {
                MessageBox.Show("Cannot add student to database");
                return;
            }
            displayOder();

        }

        private void ManagerForm_Load()
        {

            InitializeDataGridView<Order>(dataGridViewOrder);
            InitializeDataGridView<Purchase>(dataGridViewPurchase);

            var rose = Controller<RosePurchaseManagementEntities, Rose>.GetEntities().ToList();
            var roselist = rose.Select(x => x.RoseName).ToList();
            listBoxRoses.DataSource = roselist;

            listBoxRoses.SelectionMode = SelectionMode.One;
            listBoxRoses.SelectedIndex = -1;

            textBoxNumberOfBunches.ResetText();
            displayOder();
            dispalyPurchase();

        }

        private void InitializeDataGridView<T>(DataGridView dataGridView, params string[] columnsToHide) where T : class
        {
            //Allow users to add/delete rows, and fill out columns to the entire width  of the control
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = true;
            dataGridView.ReadOnly = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataError += (s, e) => HandleDataError<T>(s as DataGridView, e);

            
                foreach (string column in columnsToHide)
                    dataGridView.Columns[column].Visible = false;
        }
        private void HandleDataError<T>(DataGridView gridView, DataGridViewDataErrorEventArgs e)
        {
            Debug.WriteLine("DataError " + typeof(T) + " " + gridView.Name + " row " + e.RowIndex + " col " + e.ColumnIndex + " Context: " + e.Context.ToString());
            e.Cancel = true;
        }

        public void displayOder()
        {
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

                dataGridViewOrder.DataSource = orderDisplayList;



            }
        }
       public void dispalyPurchase()
        {
            List<PurchaseBoxQuantity> purchaseBoxQuantities = new List<PurchaseBoxQuantity>();
            var purchases = Controller<RosePurchaseManagementEntities, Purchase>.GetEntitiesWithIncluded("BoxPurchases", "RoseSize", "Farm", "Invoice", "Warehouse");
            List<Box> boxes = (List<Box>)Controller<RosePurchaseManagementEntities, Box>.GetEntitiesWithIncluded("BoxPurchases");

            if (checkBoxSearch.Checked){

                purchases = purchases.Where(x => x.Invoice.Date >= dateTimePickerStartDate.Value).Where(x => x.Invoice.Date <= dateTimePickerEndDate.Value);
            }

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
            var count = purchaseBoxQuantities.Count();
            labelCount.Text = count.ToString();
            if(count != 0)
            {
                var sum = purchaseBoxQuantities.Select(x => x.Total).Average();
                labelAveragePrice.Text = sum.ToString();
            }
            else
            {
                labelAveragePrice.Text = "";
            }
            
              dataGridViewPurchase.DataSource = purchaseBoxQuantities;

            
           
        }

       
        private void tabPageReport_Click(object sender, EventArgs e)
        {

        }


        public class OrderDisplay
        {
            public int OderId { get; set; }
            public String RoseName { get; set; }
            public int NumberOfBunches { get; set; }


        }
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
