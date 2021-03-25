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
    public partial class RosePurchaseManagementAppMainForm : Form
    {
 

        public RosePurchaseManagementAppMainForm()
        {
            InitializeComponent();

            //  calling eventhandler to display forms
            ManagerForm managerForm = new ManagerForm();
            buttonManagerForm.Click += (s, e) => ShowForm(managerForm);
            ControllerForm controllerForm = new ControllerForm();
            buttonControllerForm.Click += (s, e) => ShowForm(controllerForm);
           SupplierForm supplierForm = new SupplierForm();
            buttonSupplierForm.Click += (s, e) => ShowForm(supplierForm);

        }

        private void ShowForm( Form form) 
        {
            //hide the current form
            this.Hide();
           //display the form
            var result = form.ShowDialog();
            form.Hide();
            this.Show();
        }
    }
}
