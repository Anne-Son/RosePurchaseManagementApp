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
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();

            //set up database and controls when form loads

            this.Load += (s, e) => SupplierInventory_Load();

            //event handlers

            buttonAddInventory.Click += ButtonAddInventory_Click;
            buttonUpdateInventory.Click += ButtonUpdateInventory_Click;
            buttonDeleteInventory.Click += ButtonDeleteInventory_Click;

            dataGridViewFlowers.SelectionChanged += (s, e) => GetSupplierInventory();
        }

        private void DataGridViewOrder_SelectionChanged(object sender, EventArgs e)
        {
            var inv = new List<SupplierInventory>(dataGridViewFlowers.SelectedRows.Count);
            var selectedInventory = dataGridViewFlowers.SelectedRows
                  .OfType<DataGridViewRow>()
                  .ToList();
            if (dataGridViewFlowers.SelectedRows.Count != 0)
            {
                var i = (SupplierInventory)selectedInventory.Select(x => x).FirstOrDefault().DataBoundItem;
                comboBoxRoses.Text = i.RoseName;
                textBoxQuantity.Text = i.Quantity.ToString();
                textBoxPrice.Text = i.Price.ToString();
            }
        }

        private void ButtonDeleteInventory_Click(object sender, EventArgs e)
        {

            if ((dataGridViewFlowers.SelectedRows.Count <= 0))
            {
                MessageBox.Show("Please select the inventory to delete");
                return;
            }
            var selectedInventory = dataGridViewFlowers.SelectedRows
                .OfType<DataGridViewRow>()
                .ToList();

            using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
            {
                var inven = (SupplierInventory)selectedInventory.Select(x => x).FirstOrDefault().DataBoundItem;
                var selectedBoxId = context.Boxes.Where(b => b.BoxID == inven.BoxID).Select(i => i.BoxID).FirstOrDefault();
                Inventory inventory = context.Inventories.Where(z => z.InventoryID == inven.InventoryID).FirstOrDefault();
                BoxInventory boxInventory = context.BoxInventories.Where(b => (b.BoxID == selectedBoxId) && (b.InventoryID == inven.InventoryID)).FirstOrDefault();

                context.BoxInventories.Remove(boxInventory);
                context.SaveChanges();

                context.Inventories.Remove(inventory);
                context.SaveChanges();
            }

            GetSupplierInventory();

        }

        private void ButtonUpdateInventory_Click(object sender, EventArgs e)
        {
            var selectedInventory = dataGridViewFlowers.SelectedRows
                 .OfType<DataGridViewRow>()
                 .ToArray();


            if (dataGridViewFlowers.SelectedRows.Count != 0)
            {
                var inven = (SupplierInventory)selectedInventory.Select(x => x).FirstOrDefault().DataBoundItem;
                Inventory invent = new Inventory();
                BoxInventory boxinventory = new BoxInventory();
                using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
                {
                    //select the item from the listbox
                    String selectedFarm = listBoxFarms.SelectedItem.ToString();
                    String selectedRose = comboBoxRoses.Text;

                    //get the roseId for the selected roses
                    var farmId = context.Inventories.Include("Farm").Where(f => f.Farm.FarmName == selectedFarm).FirstOrDefault();
                    var roseSizeId = context.RoseSizes.Include("Rose").Where(r => r.Rose.RoseName == selectedRose).FirstOrDefault();
                    invent.FarmID = farmId.FarmID;
                    invent.RoseSizeID = roseSizeId.RoseSizeID;
                    invent.Price_per_stem = float.Parse(textBoxPrice.Text);
                    boxinventory.Quantity = int.Parse(textBoxQuantity.Text);
                    context.SaveChanges();


                    Controller<RosePurchaseManagementEntities, Inventory>.UpdateEntity(invent);

                    Controller<RosePurchaseManagementEntities, BoxInventory>.UpdateEntity(boxinventory);
                }

                GetSupplierInventory();
            }
        }

        private void ButtonAddInventory_Click(object sender, EventArgs e)
        {


            Inventory invent = new Inventory();
            BoxInventory boxinventory = new BoxInventory();


            if (listBoxFarms.SelectedIndex < 0)
            {
                MessageBox.Show("A farm must be selected. ");
                return;
            }
            if (textBoxQuantity.Text == "")
            {
                MessageBox.Show("Quantity must be inserted.");
                return;
            }
            if (comboBoxRoses.Text == "")
            {
                MessageBox.Show("Rose name must be inserted..");
                return;
            }
            if (textBoxPrice.Text == "")
            {
                MessageBox.Show("Price must be inserted.");
                return;
            }




            using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
            {
                //select the item from the listbox
                String selectedFarm = listBoxFarms.SelectedItem.ToString();
                String selectedRose = comboBoxRoses.Text;


                //get the roseId  and farmid for the selected roses and farms
                var farmId = context.Inventories.Include("Farm").Where(f => f.Farm.FarmName == selectedFarm).FirstOrDefault();
                var roseSizeId = context.RoseSizes.Include("Rose").Where(r => r.Rose.RoseName == selectedRose).FirstOrDefault();
                invent.FarmID = farmId.FarmID;
                invent.RoseSizeID = roseSizeId.RoseSizeID;
                invent.Price_per_stem = float.Parse(textBoxPrice.Text);
                boxinventory.Quantity = int.Parse(textBoxPrice.Text);
            }
            // add inventory to the list using controller
            if (Controller<RosePurchaseManagementEntities, Inventory>.AddEntity(invent) == null || Controller<RosePurchaseManagementEntities, BoxInventory>.AddEntity(boxinventory) == null)
            {
                MessageBox.Show("Cannot add order to database");
                return;
            }
            //display 
            GetSupplierInventory();

            //clear selected farms
            listBoxFarms.ClearSelected();
            //empty string
            comboBoxRoses.Text = "";
            textBoxPrice.Text = "";
            textBoxQuantity.Text = "";


            using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
            {

                // String selectedRose = comboBoxRoses.Text;
                String selectedFarm = listBoxFarms.SelectedItem.ToString();


                var farmID = context.Inventories.Include("Farm").Where(f => f.Farm.FarmName == selectedFarm).FirstOrDefault();
                // var roseSizeId = context.RoseSizes.Include("Rose").Where(r => r.Rose.RoseName == selectedRose).FirstOrDefault();


                invent.FarmID = listBoxFarms.SelectedIndex + 1;

                invent.Price_per_stem = float.Parse(textBoxPrice.Text);

                // invent.RoseSizeID = roseSizeId.RoseSizeID;

                boxinventory.Quantity = int.Parse(textBoxQuantity.Text);

                Controller<RosePurchaseManagementEntities, BoxInventory>.AddEntity(boxinventory);
            }

            if (Controller<RosePurchaseManagementEntities, Inventory>.AddEntity(invent) == null)
            {
                MessageBox.Show("Cannot add to database");
                return;
            }

            GetSupplierInventory();
        }

        private void SupplierInventory_Load()
        {
            InitializeDataGridView<Inventory>(dataGridViewFlowers);
            dataGridViewFlowers.DataSource = GetSupplierInventory();
            dataGridViewFlowers.Columns["Inventory"].Visible = false;
            dataGridViewFlowers.Columns["BoxInventory"].Visible = false;
            dataGridViewFlowers.Columns["RoseSizeID"].Visible = false;
            dataGridViewFlowers.Columns["BoxID"].Visible = false;
            //dataGridViewFlowers.Columns["BoxName"].Visible = false;

            dataGridViewFlowers.DataError += (s, e) => GetSupplierInventory();


            listBoxFarms.DataSource = Controller<RosePurchaseManagementEntities, Farm>.GetEntities();

            listBoxFarms.SelectedIndex = -1;

            textBoxPrice.ResetText();
            textBoxQuantity.ResetText();
            comboBoxRoses.ResetText();


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

            foreach (string column in columnsToHide)
                dataGridView.Columns[column].Visible = false;
        }
        private void HandleDataError<T>(DataGridView gridView, DataGridViewDataErrorEventArgs e)
        {
            Debug.WriteLine("DataError " + typeof(T) + " " + gridView.Name + " row " + e.RowIndex + " col " + e.ColumnIndex + " Context: " + e.Context.ToString());
            e.Cancel = true;
        }


        List<SupplierInventory> GetSupplierInventory()
        {
            List<SupplierInventory> supplierInventories = new List<SupplierInventory>();
            List<Inventory> inventory = (List<Inventory>)Controller<RosePurchaseManagementEntities, Inventory>.GetEntitiesWithIncluded("BoxInventories", "Farm");
            List<Box> box = (List<Box>)Controller<RosePurchaseManagementEntities, Box>.GetEntitiesWithIncluded("BoxInventories");

            foreach (Inventory inventories in inventory)
            {
                foreach (BoxInventory boxes in inventories.BoxInventories)
                {
                    SupplierInventory supplierInventory = new SupplierInventory()
                    {
                        InventoryID = inventories.InventoryID,
                        FarmID = inventories.FarmID,
                        FarmName = inventories.Farm.FarmName,
                        Price = inventories.Price_per_stem,
                        Quantity = boxes.Quantity,

                    };
                    using (RosePurchaseManagementEntities context = new RosePurchaseManagementEntities())
                    {
                        var roseName = context.RoseSizes.Include("Rose").Where(x => x.RoseSizeID == inventories.RoseSizeID).Select(r => r.Rose.RoseName).FirstOrDefault();
                        supplierInventory.RoseName = roseName;
                    }
                    supplierInventories.Add(supplierInventory);
                }
            }
            return supplierInventories;
        }
        private class SupplierInventory
        {
            [DisplayName("Inventory ID")]
            public int InventoryID { get; set; }

            [DisplayName("Farm ID")]
            public int FarmID { get; set; }

            [DisplayName("Farm Name")]
            public string FarmName { get; set; }

            [DisplayName("Rose Size ID")]
            public int RoseSizeID { get; set; }

            [DisplayName("Rose Name")]
            public string RoseName { get; set; }

            [DisplayName("Price per stem")]
            public float Price { get; set; }

            [DisplayName("Box ID")]
            public int BoxID { get; set; }

            [DisplayName("Quantity")]
            public int Quantity { get; set; }

            public Inventory Inventory { get; set; }

            public BoxInventory BoxInventory { get; set; }

        }


    }
}
