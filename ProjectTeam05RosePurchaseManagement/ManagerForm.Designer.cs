
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
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.tabPageBackup = new System.Windows.Forms.TabPage();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.tabControlManager.SuspendLayout();
            this.tabPageOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
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
            this.tabControlManager.Size = new System.Drawing.Size(1129, 608);
            this.tabControlManager.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlManager.TabIndex = 0;
            // 
            // tabPageOrder
            // 
            this.tabPageOrder.Controls.Add(this.dataGridViewOrder);
            this.tabPageOrder.Location = new System.Drawing.Point(4, 25);
            this.tabPageOrder.Name = "tabPageOrder";
            this.tabPageOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrder.Size = new System.Drawing.Size(1121, 579);
            this.tabPageOrder.TabIndex = 0;
            this.tabPageOrder.Text = "Order";
            this.tabPageOrder.UseVisualStyleBackColor = true;
            // 
            // tabPageReport
            // 
            this.tabPageReport.Location = new System.Drawing.Point(4, 25);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReport.Size = new System.Drawing.Size(1121, 579);
            this.tabPageReport.TabIndex = 1;
            this.tabPageReport.Text = "Report";
            this.tabPageReport.UseVisualStyleBackColor = true;
            this.tabPageReport.Click += new System.EventHandler(this.tabPageReport_Click);
            // 
            // tabPageBackup
            // 
            this.tabPageBackup.Location = new System.Drawing.Point(4, 25);
            this.tabPageBackup.Name = "tabPageBackup";
            this.tabPageBackup.Size = new System.Drawing.Size(998, 492);
            this.tabPageBackup.TabIndex = 2;
            this.tabPageBackup.Text = "Backup";
            this.tabPageBackup.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(32, 33);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowHeadersWidth = 51;
            this.dataGridViewOrder.RowTemplate.Height = 24;
            this.dataGridViewOrder.Size = new System.Drawing.Size(693, 207);
            this.dataGridViewOrder.TabIndex = 0;
            // 
            // ManagerForm
            // 
            this.ClientSize = new System.Drawing.Size(1145, 637);
            this.Controls.Add(this.tabControlManager);
            this.Name = "ManagerForm";
            this.tabControlManager.ResumeLayout(false);
            this.tabPageOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
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
    }
}