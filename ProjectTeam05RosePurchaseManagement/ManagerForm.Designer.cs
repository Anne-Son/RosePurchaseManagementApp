
namespace ProjectTeam05RosePurchaseManagement
{
    partial class ManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlManager = new System.Windows.Forms.TabControl();
            this.tabPageOrder = new System.Windows.Forms.TabPage();
            this.buttonUpdateOrder = new System.Windows.Forms.Button();
            this.buttonDeleteOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumberOfBunches = new System.Windows.Forms.TextBox();
            this.listBoxRoses = new System.Windows.Forms.ListBox();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.labelAveragePrice = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxSearch = new System.Windows.Forms.CheckBox();
            this.dataGridViewPurchase = new System.Windows.Forms.DataGridView();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageBackup = new System.Windows.Forms.TabPage();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.buttonBackUp = new System.Windows.Forms.Button();
            this.listBoxWarehouse = new System.Windows.Forms.ListBox();
            this.listBoxRosesIn = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControlManager.SuspendLayout();
            this.tabPageOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.tabPageReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).BeginInit();
            this.tabPageBackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlManager
            // 
            this.tabControlManager.Controls.Add(this.tabPageOrder);
            this.tabControlManager.Controls.Add(this.tabPageReport);
            this.tabControlManager.Controls.Add(this.tabPageBackup);
            this.tabControlManager.Location = new System.Drawing.Point(13, 25);
            this.tabControlManager.Name = "tabControlManager";
            this.tabControlManager.SelectedIndex = 0;
            this.tabControlManager.Size = new System.Drawing.Size(1129, 672);
            this.tabControlManager.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlManager.TabIndex = 0;
            // 
            // tabPageOrder
            // 
            this.tabPageOrder.Controls.Add(this.buttonUpdateOrder);
            this.tabPageOrder.Controls.Add(this.buttonDeleteOrder);
            this.tabPageOrder.Controls.Add(this.label3);
            this.tabPageOrder.Controls.Add(this.buttonOrder);
            this.tabPageOrder.Controls.Add(this.label1);
            this.tabPageOrder.Controls.Add(this.textBoxNumberOfBunches);
            this.tabPageOrder.Controls.Add(this.listBoxRoses);
            this.tabPageOrder.Controls.Add(this.dataGridViewOrder);
            this.tabPageOrder.Location = new System.Drawing.Point(4, 25);
            this.tabPageOrder.Name = "tabPageOrder";
            this.tabPageOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrder.Size = new System.Drawing.Size(1121, 643);
            this.tabPageOrder.TabIndex = 0;
            this.tabPageOrder.Text = "Order";
            this.tabPageOrder.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateOrder
            // 
            this.buttonUpdateOrder.Location = new System.Drawing.Point(552, 318);
            this.buttonUpdateOrder.Name = "buttonUpdateOrder";
            this.buttonUpdateOrder.Size = new System.Drawing.Size(163, 49);
            this.buttonUpdateOrder.TabIndex = 8;
            this.buttonUpdateOrder.Text = "Update Order";
            this.buttonUpdateOrder.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteOrder
            // 
            this.buttonDeleteOrder.Location = new System.Drawing.Point(882, 56);
            this.buttonDeleteOrder.Name = "buttonDeleteOrder";
            this.buttonDeleteOrder.Size = new System.Drawing.Size(128, 38);
            this.buttonDeleteOrder.TabIndex = 7;
            this.buttonDeleteOrder.Text = "Delete Order";
            this.buttonDeleteOrder.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Roses List";
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(82, 576);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(163, 49);
            this.buttonOrder.TabIndex = 4;
            this.buttonOrder.Text = "New Order";
            this.buttonOrder.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 527);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of Bunches";
            // 
            // textBoxNumberOfBunches
            // 
            this.textBoxNumberOfBunches.Location = new System.Drawing.Point(234, 522);
            this.textBoxNumberOfBunches.Name = "textBoxNumberOfBunches";
            this.textBoxNumberOfBunches.Size = new System.Drawing.Size(151, 22);
            this.textBoxNumberOfBunches.TabIndex = 2;
            // 
            // listBoxRoses
            // 
            this.listBoxRoses.FormattingEnabled = true;
            this.listBoxRoses.ItemHeight = 16;
            this.listBoxRoses.Location = new System.Drawing.Point(112, 318);
            this.listBoxRoses.Name = "listBoxRoses";
            this.listBoxRoses.Size = new System.Drawing.Size(261, 180);
            this.listBoxRoses.TabIndex = 1;
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(32, 33);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowHeadersWidth = 51;
            this.dataGridViewOrder.RowTemplate.Height = 24;
            this.dataGridViewOrder.Size = new System.Drawing.Size(765, 258);
            this.dataGridViewOrder.TabIndex = 0;
            // 
            // tabPageReport
            // 
            this.tabPageReport.Controls.Add(this.label9);
            this.tabPageReport.Controls.Add(this.label8);
            this.tabPageReport.Controls.Add(this.label7);
            this.tabPageReport.Controls.Add(this.listBoxRosesIn);
            this.tabPageReport.Controls.Add(this.listBoxWarehouse);
            this.tabPageReport.Controls.Add(this.labelAveragePrice);
            this.tabPageReport.Controls.Add(this.labelCount);
            this.tabPageReport.Controls.Add(this.label6);
            this.tabPageReport.Controls.Add(this.label5);
            this.tabPageReport.Controls.Add(this.checkBoxSearch);
            this.tabPageReport.Controls.Add(this.dataGridViewPurchase);
            this.tabPageReport.Controls.Add(this.dateTimePickerEndDate);
            this.tabPageReport.Controls.Add(this.dateTimePickerStartDate);
            this.tabPageReport.Controls.Add(this.label4);
            this.tabPageReport.Controls.Add(this.label2);
            this.tabPageReport.Location = new System.Drawing.Point(4, 25);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReport.Size = new System.Drawing.Size(1121, 643);
            this.tabPageReport.TabIndex = 1;
            this.tabPageReport.Text = "Report";
            this.tabPageReport.UseVisualStyleBackColor = true;
            this.tabPageReport.Click += new System.EventHandler(this.tabPageReport_Click);
            // 
            // labelAveragePrice
            // 
            this.labelAveragePrice.AutoSize = true;
            this.labelAveragePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAveragePrice.Location = new System.Drawing.Point(323, 345);
            this.labelAveragePrice.Name = "labelAveragePrice";
            this.labelAveragePrice.Size = new System.Drawing.Size(0, 17);
            this.labelAveragePrice.TabIndex = 10;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.Location = new System.Drawing.Point(161, 345);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(0, 17);
            this.labelCount.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Average Price";
            // 
            // checkBoxSearch
            // 
            this.checkBoxSearch.AutoSize = true;
            this.checkBoxSearch.Location = new System.Drawing.Point(771, 40);
            this.checkBoxSearch.Name = "checkBoxSearch";
            this.checkBoxSearch.Size = new System.Drawing.Size(75, 21);
            this.checkBoxSearch.TabIndex = 6;
            this.checkBoxSearch.Text = "Search";
            this.checkBoxSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPurchase
            // 
            this.dataGridViewPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchase.Location = new System.Drawing.Point(58, 111);
            this.dataGridViewPurchase.Name = "dataGridViewPurchase";
            this.dataGridViewPurchase.RowHeadersWidth = 51;
            this.dataGridViewPurchase.RowTemplate.Height = 24;
            this.dataGridViewPurchase.Size = new System.Drawing.Size(850, 189);
            this.dataGridViewPurchase.TabIndex = 5;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(467, 40);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerEndDate.TabIndex = 3;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(144, 40);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerStartDate.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "EndDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "StartDate";
            // 
            // tabPageBackup
            // 
            this.tabPageBackup.Controls.Add(this.buttonRestore);
            this.tabPageBackup.Controls.Add(this.buttonBackUp);
            this.tabPageBackup.Location = new System.Drawing.Point(4, 25);
            this.tabPageBackup.Name = "tabPageBackup";
            this.tabPageBackup.Size = new System.Drawing.Size(1121, 643);
            this.tabPageBackup.TabIndex = 2;
            this.tabPageBackup.Text = "Backup";
            this.tabPageBackup.UseVisualStyleBackColor = true;
            // 
            // buttonRestore
            // 
            this.buttonRestore.Location = new System.Drawing.Point(303, 252);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(156, 76);
            this.buttonRestore.TabIndex = 1;
            this.buttonRestore.Text = "Restore";
            this.buttonRestore.UseVisualStyleBackColor = true;
            // 
            // buttonBackUp
            // 
            this.buttonBackUp.Location = new System.Drawing.Point(303, 120);
            this.buttonBackUp.Name = "buttonBackUp";
            this.buttonBackUp.Size = new System.Drawing.Size(156, 76);
            this.buttonBackUp.TabIndex = 0;
            this.buttonBackUp.Text = "BackUp";
            this.buttonBackUp.UseVisualStyleBackColor = true;
            // 
            // listBoxWarehouse
            // 
            this.listBoxWarehouse.FormattingEnabled = true;
            this.listBoxWarehouse.ItemHeight = 16;
            this.listBoxWarehouse.Location = new System.Drawing.Point(122, 413);
            this.listBoxWarehouse.Name = "listBoxWarehouse";
            this.listBoxWarehouse.Size = new System.Drawing.Size(133, 196);
            this.listBoxWarehouse.TabIndex = 11;
            // 
            // listBoxRosesIn
            // 
            this.listBoxRosesIn.FormattingEnabled = true;
            this.listBoxRosesIn.ItemHeight = 16;
            this.listBoxRosesIn.Location = new System.Drawing.Point(467, 413);
            this.listBoxRosesIn.Name = "listBoxRosesIn";
            this.listBoxRosesIn.Size = new System.Drawing.Size(133, 196);
            this.listBoxRosesIn.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "WareHouse";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(375, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Roses";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Purchase";
            // 
            // ManagerForm
            // 
            this.ClientSize = new System.Drawing.Size(1145, 699);
            this.Controls.Add(this.tabControlManager);
            this.Name = "ManagerForm";
            this.tabControlManager.ResumeLayout(false);
            this.tabPageOrder.ResumeLayout(false);
            this.tabPageOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.tabPageReport.ResumeLayout(false);
            this.tabPageReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).EndInit();
            this.tabPageBackup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControlManager;
        private System.Windows.Forms.TabPage tabPageOrder;
        private System.Windows.Forms.TabPage tabPageReport;
        private System.Windows.Forms.TabPage tabPageBackup;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumberOfBunches;
        private System.Windows.Forms.ListBox listBoxRoses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewPurchase;
        private System.Windows.Forms.CheckBox checkBoxSearch;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAveragePrice;
        private System.Windows.Forms.Button buttonDeleteOrder;
        private System.Windows.Forms.Button buttonUpdateOrder;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.Button buttonBackUp;
        private System.Windows.Forms.ListBox listBoxRosesIn;
        private System.Windows.Forms.ListBox listBoxWarehouse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}