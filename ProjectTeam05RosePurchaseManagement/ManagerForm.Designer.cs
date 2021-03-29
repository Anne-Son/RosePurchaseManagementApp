
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
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumberOfBunches = new System.Windows.Forms.TextBox();
            this.listBoxRoses = new System.Windows.Forms.ListBox();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageBackup = new System.Windows.Forms.TabPage();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControlManager.SuspendLayout();
            this.tabPageOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.tabPageReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.buttonOrder.Text = "Order";
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
            this.tabPageReport.Controls.Add(this.dataGridView1);
            this.tabPageReport.Controls.Add(this.buttonSearch);
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
            this.tabPageBackup.Location = new System.Drawing.Point(4, 25);
            this.tabPageBackup.Name = "tabPageBackup";
            this.tabPageBackup.Size = new System.Drawing.Size(1121, 643);
            this.tabPageBackup.TabIndex = 2;
            this.tabPageBackup.Text = "Backup";
            this.tabPageBackup.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(794, 30);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(98, 32);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(850, 189);
            this.dataGridView1.TabIndex = 5;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSearch;
    }
}