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
            
           // context.Purchases.Include(d => d.BoxPurchases).Load();

            InitializeDataGridView();


            dataGridViewPurchase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPurchase.ReadOnly = true;
            dataGridViewPurchase.AllowUserToAddRows = false;
            dataGridViewPurchase.DataSource = GetPurchaseBoxQuantities();

            //display the data in the purchase gridview

            //UpdatePurchase();
        }

        private void InitializeDataGridView()
        {
            RosePurchaseManagementEntities context = new RosePurchaseManagementEntities();  

           InitializeDataGridView<Order>(dataGridViewOrder, "RoseSize");
           InitializeDataGridView<Inventory>(dataGridViewInventoryPurchase, "RoseSize", "Farm");
            // InitializeDataGridView<Purchase>(dataGridViewPurchase,"Farm","Invoice","RoseSize","Warehouse");
           // DisplayPurchase();
            

            
            

        }

       List<PurchaseBoxQuantity> GetPurchaseBoxQuantities()
        {
            List<PurchaseBoxQuantity> purchaseBoxQuantities = new List<PurchaseBoxQuantity>();
            List<Purchase> purchases = (List<Purchase>)Controller<RosePurchaseManagementEntities, Purchase>.GetEntitiesWithIncluded("BoxPurchases");
            foreach(Purchase purchase in purchases)
            {
                foreach(BoxPurchase boxPurchase in purchase.BoxPurchases)
                {
                    PurchaseBoxQuantity purchaseBoxQuantity = new PurchaseBoxQuantity()
                    {
                        PurchaseID = purchase.PurchaseID,
                        FarmID = purchase.FarmID,
                        RoseID = purchase.RoseSizeID,
                        Price = purchase.Price_per_stem,
                        InvoiceNumber = purchase.InvoiceID,
                        WarehouseID = purchase.WarehouseID,
                        BoxQuantity = boxPurchase.Quantity
                    };
                    purchaseBoxQuantities.Add(purchaseBoxQuantity);
                }
            }
            return purchaseBoxQuantities;

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
           // dataGridView.DataSource = Controller<RosePurchaseManagementEntities, T>.GetEntitiesWithIncluded(entities);

            //do not show certain columns
            foreach (string column in columnsToHide)
            dataGridView.Columns[column].Visible = false;
        }
        private void HandleDataError<T>(DataGridView gridView, DataGridViewDataErrorEventArgs e)
        {
            Debug.WriteLine("DataError " + typeof(T) + " " + gridView.Name + " row " + e.RowIndex + " col " + e.ColumnIndex + " Context: " + e.Context.ToString());
            e.Cancel = true;
        }

        private class PurchaseBoxQuantity
        {
            [DisplayName("PurchaseID")]
            public int PurchaseID { get; set; }

            [DisplayName("FarmID")]
            public int FarmID { get; set; }

            [DisplayName("RoseID")]
            public int RoseID { get; set; }

            [DisplayName("Price")]
            public float Price { get; set; }

            [DisplayName("InvoiceNumber")]
            public int? InvoiceNumber { get; set; }

            [DisplayName("WarehouseID")]
            public int WarehouseID { get; set; }

            [DisplayName("BoxQuantity")]
            public int BoxQuantity { get; set; }

            public Purchase Purchase { get; set; }

            public BoxPurchase BoxPurchase { get; set; }
        }
    }
}
