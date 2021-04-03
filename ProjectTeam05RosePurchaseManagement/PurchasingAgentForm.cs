﻿using EFControllerUtilities;
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
    public partial class PurchasingAgentForm : Form
    {
        public PurchasingAgentForm()
        {
            InitializeComponent();

            //set up database and controls when form loads

            this.Load += (s, e) => PurchasingAgentForm_Load();

            AddPurchaseForm addPurchaseForm = new AddPurchaseForm();
            buttonAddUpdate.Click += (s,e) => AddOrUpdateForm<Purchase>(dataGridViewPurchase, addPurchaseForm);
            
        }

        private void AddOrUpdateForm<T>(DataGridView dataGridView, Form form) where T : class
        {
            var result = form.ShowDialog();

            // form has closed

            if (result == DialogResult.OK)
            {
                // reload the db and update the gridview

                dataGridView.DataSource = Controller<RosePurchaseManagementEntities, T>.SetBindingList();

                // update the customer orders report

                UpdatePurchase();
            }

            // do not close, as the form object will be disposed, 
            // just hide the form (make it invisible). 
            // 
            // when the inputForm is opened again (ShowDialog()), the Load event will fire
            //  and the form will be reinitialized

            form.Hide();
        }
        public void UpdatePurchase()
        {
            //set gridview datasource to the query result
            dataGridViewPurchase.DataSource = GetPurchaseBoxQuantities();
            dataGridViewPurchase.Columns["Purchase"].Visible = false;
            dataGridViewPurchase.Columns["BoxPurchase"].Visible = false;
        }

        private void PurchasingAgentForm_Load()
        {
            dataGridViewPurchase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPurchase.ReadOnly = true;
            dataGridViewPurchase.AllowUserToAddRows = false;
            dataGridViewPurchase.DataSource = GetPurchaseBoxQuantities();
            dataGridViewPurchase.Columns["Purchase"].Visible = false;
            dataGridViewPurchase.Columns["BoxPurchase"].Visible = false;
        }
        List<PurchaseBoxQuantity> GetPurchaseBoxQuantities()
        {
            List<PurchaseBoxQuantity> purchaseBoxQuantities = new List<PurchaseBoxQuantity>();
            List<Purchase> purchases = (List<Purchase>)Controller<RosePurchaseManagementEntities, Purchase>.GetEntitiesWithIncluded("BoxPurchases");
            List<Box> boxes = (List<Box>)Controller<RosePurchaseManagementEntities, Box>.GetEntitiesWithIncluded("BoxPurchases");

            foreach (Purchase purchase in purchases)
            {
                foreach (BoxPurchase boxPurchase in purchase.BoxPurchases)
                {
                    PurchaseBoxQuantity purchaseBoxQuantity = new PurchaseBoxQuantity()
                    {
                        PurchaseID = purchase.PurchaseID,
                        FarmID = purchase.FarmID,
                        RoseID = purchase.RoseSizeID,
                        Price = purchase.Price_per_stem,
                        InvoiceNumber = purchase.InvoiceID,
                        WarehouseID = purchase.WarehouseID,
                        BoxID = boxPurchase.BoxID,
                        BoxQuantity = boxPurchase.Quantity
                    };
                    purchaseBoxQuantities.Add(purchaseBoxQuantity);
                }
            }
            return purchaseBoxQuantities;
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

            [DisplayName("BoxID")]
            public int BoxID { get; set; }

            [DisplayName("BoxQuantity")]
            public int BoxQuantity { get; set; }

            public Purchase Purchase { get; set; }

            public BoxPurchase BoxPurchase { get; set; }

        }
    }
}
