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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
            this.Load += (s, e) => ManagerForm_Load();


        }

        private void ManagerForm_Load()
        {

            InitializeDataGridView<Order>(dataGridViewOrder);
        }

        private void InitializeDataGridView<T>(DataGridView dataGridView, params string[] columnsToHide) where T : class
        {
            //Allow users to add/delete rows, and fill out columns to the entire width  of the control
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = true;
            dataGridView.ReadOnly = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            var s = Controller<RosePurchaseManagementEntities, T>.GetEntitiesWithIncluded("RoseSize");

            displayOder();
                foreach (string column in columnsToHide)
                    dataGridView.Columns[column].Visible = false;
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

        private void tabPageReport_Click(object sender, EventArgs e)
        {

        }
    }
}
