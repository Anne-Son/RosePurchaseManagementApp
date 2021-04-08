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
    public partial class PurchasingAgentForm : Form
    {
        public PurchasingAgentForm()
        {
            InitializeComponent();

            //set up database and controls when form loads

            this.Load += (s, e) => PurchasingAgentForm_Load();

            buttonPurchase.Click += ButtonPurchase_Click;
           // AddPurchaseForm addPurchaseForm = new AddPurchaseForm();
          
            //buttonAddUpdate.Click += (s,e) => AddOrUpdateForm<Purchase>(dataGridViewPurchase, addPurchaseForm);
            
        }

        private void ButtonPurchase_Click(object sender, EventArgs e)
        {
            //create a purchase 
            Purchase purchase = new Purchase();

            using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
            {

            }
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

            //var Farm= Controller<RosePurchaseManagementEntities, Farm>.GetEntities();
            //var FarmList = Farm.Select(x => x.FarmName).ToList();
            //listBoxFarm.DataSource = FarmList;
            listBoxFarm.DataSource = Controller<RosePurchaseManagementEntities, Farm>.GetEntities();

            //var rose = Controller<RosePurchaseManagementEntities, Rose>.GetEntities();
            //var roselist = rose.Select(x => x.RoseName).ToList();
            //listBoxRoseName.DataSource = roselist;
            listBoxRoseName.DataSource = Controller<RosePurchaseManagementEntities, Rose>.GetEntities();

            //var size = Controller<RosePurchaseManagementEntities, RosePurchaseManagementCodeFirstFromDB.Size>.GetEntitiesWithIncluded("RoseSizes");
            //var roseSizelist = size.Select(x => x.SizeName).ToList();
            //listBoxRoseSize.DataSource = roseSizelist;
            listBoxRoseSize.DataSource = Controller<RosePurchaseManagementEntities, RosePurchaseManagementCodeFirstFromDB.Size>.GetEntitiesWithIncluded("RoseSizes");

            listBoxInvoice.DataSource = Controller<RosePurchaseManagementEntities, Invoice>.GetEntities();

            listBoxWarehouse.DataSource = Controller<RosePurchaseManagementEntities, Warehouse>.GetEntities();

            listBoxRoseName.SelectedIndex = -1;
            listBoxRoseSize.SelectedIndex = -1;
            listBoxFarm.SelectedIndex = -1;
            listBoxRoseSize.SelectedIndex = -1;

            textBoxPricePerStem.ResetText();
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

            [DisplayName("Price Per Stem")]
            public float Price { get; set; }

            [DisplayName("InvoiceNumber")]
            public int? InvoiceNumber { get; set; }

            [DisplayName("Warehouse Name")]
            public string WarehouseName { get; set; }

            [DisplayName("BoxType")]
            public string BoxName { get; set; }

            [DisplayName("BoxQuantity")]
            public int BoxQuantity { get; set; }

            public Purchase Purchase { get; set; }

            public BoxPurchase BoxPurchase { get; set; }


        }


    }
}
