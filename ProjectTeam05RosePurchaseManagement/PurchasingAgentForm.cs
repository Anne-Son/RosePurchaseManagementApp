using EFControllerUtilities;
using RosePurchaseManagementCodeFirstFromDB;
using SeedDatabaseExtensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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

            //Set button Click events for operating on Purchase table. Make use of a generic method
            //(AddOrUpdateForm) and DeleteForm

            //set up the button handlers

           // buttonPurchase.Click += (s, e) => PurchaseFromInventory();
        }
        /// <summary>
        /// When the form loads, seed the db table, set up datagridview controles, and display
        /// the data in the controls.
        /// </summary>
        private void PurchasingAgentForm_Load()
        {
          
            InitializeDataGridView();

            //display the data in the purchase gridview

            //UpdatePurchase();
        }

        private void InitializeDataGridView()
        {
            //Composite are not editable. Done this on control
            //Set up cell validation for each. Row validation for each, as a user
            //might have left the row due to a focus change, and need to check to see
            // if entity is complete and valid.

            InitializeDataGridView<Order>(dataGridViewOrder);
            InitializeDataGridView<Inventory>(dataGridViewInventoryPurchase, "RoseSize", "Farm");
            InitializeDataGridView<Purchase>(dataGridViewPurchase,"Farm","Invoice","RoseSize","Warehouse");

            dataGridViewPurchase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPurchase.ReadOnly = true;
            dataGridViewPurchase.AllowUserToAddRows = false;

        }

        /// <summary>
        /// Common generic method to initialize datagridview controls,sets the datasource, autosizes the control to the columns.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataGridView"></param>
        /// <param name="columnsToHide"></param>
        private void InitializeDataGridView<T>(DataGridView dataGridView, params string[] columnsToHide) where T : class
        {
            dataGridView.AllowUserToAddRows = false; ;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ReadOnly = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView.DataError += (s, e) => HandleDataError<T>(s as DataGridView, e);
            dataGridView.DataSource = Controller<RosePurchaseManagementEntities, T>.SetBindingList();
           

            //do not show certain columns
            foreach (string column in columnsToHide)
            dataGridView.Columns[column].Visible = false;
        }
        private void HandleDataError<T>(DataGridView gridView, DataGridViewDataErrorEventArgs e)
        {
            Debug.WriteLine("DataError " + typeof(T) + " " + gridView.Name + " row " + e.RowIndex + " col " + e.ColumnIndex + " Context: " + e.Context.ToString());
            e.Cancel = true;
        }
    }
}
