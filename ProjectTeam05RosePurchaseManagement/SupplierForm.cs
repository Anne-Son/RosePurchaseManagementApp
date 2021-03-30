using RosePurchaseManagementCodeFirstFromDB;
using SeedDatabaseExtensions;
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
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
            this.Load += (s, e) => SupplierForm_Load();
        }

        private void SupplierForm_Load()
        {

            using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
            {
                context.SeedDatabase();
            }
            // common setup for datagridview control

            InitializeDataGridView<Inventory>(dataGridViewFlowers);
        }

        private void InitializeDataGridView<T>(DataGridView dataGridViewFlowers, params string[] columnsToHide) where T : class
        {

            // Allow users to add/delete rows, and fill out columns to the entire width of the control

            dataGridViewFlowers.AllowUserToAddRows = false;

            dataGridViewFlowers.AllowUserToDeleteRows = true;
            dataGridViewFlowers.ReadOnly = true;
            dataGridViewFlowers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            displayFlowers();
            foreach (string column in columnsToHide)
                dataGridViewFlowers.Columns[column].Visible = false;
        }

        private void displayFlowers()
        {
            using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
            {
                var flowers = (from rose in context.Roses
                                            from inventory in context.Inventories
                                            from box in inventory.BoxInventories
                                            from size in rose.RoseSizes
                                            from farm in context.Farms 
                                             select new
                                            {
                                                InventoryID = inventory.InventoryID,
                                                FarmID = farm.FarmID,
                                                RoseSizeID = inventory.RoseSizeID,
                                                Price_per_stem = inventory.Price_per_stem,
                                                BoxID = box.BoxID,
                                                Quantity = box.Quantity,

                                            }).ToList();



                dataGridViewFlowers.DataSource = flowers;

            }
        }
    }
}
