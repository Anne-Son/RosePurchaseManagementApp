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
            buttonSearch.Click += ButtonSearch_Click;


        }

        private void ButtonSearch_Click(object sender, EventArgs e)
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

                var orderList = (from rose in context.Roses
                          from size in rose.RoseSizes
                          from order in size.Orders
                          select new
                          {
                              oderid = order.OrderID,
                              name = rose.RoseName,
                              bunches = order.Number_of_bunches,

                          }).ToList();

                dataGridViewOrder.DataSource = orderList;



            }
        }
       public void dispalyPurchase()
        {
            var s = Controller<RosePurchaseManagementEntities, Purchase>.GetEntitiesWithIncluded("Farm","RoseSize","Invoice","Warehouse").ToList();
            /* using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
             {
                 var purchaseList = context.Purchases.Include("Farm").Include("RoseSize").Include("Rose").Select(x=> x).FirstOrDefault();
                 label1.Text = purchaseList.RoseSize.Rose.RoseName;
             }*/
            dataGridViewOrder.DataSource = s;
            label4.Text = s.Select(x => x.RoseSizeID).FirstOrDefault().ToString();
        }

        private void tabPageReport_Click(object sender, EventArgs e)
        {

        }


        public class order
        {
            public int oderId { get; set; }
            public String roseName { get; set; }
            public int numberOfBunches { get; set; }


        }
        public class purchase
        {
            public int purchaseId { get; set; }
            public String roseName { get; set; }
            public int numberOfBunches { get; set; }
            public decimal pricePerStem { get; set; }
            public DateTime dateOfPurchase { get; set; }



        }

       
    }
}
