
namespace ProjectTeam05RosePurchaseManagement
{
    partial class PurchasingAgentForm
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
            this.tabPagePurchase = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewInventoryPurchase = new System.Windows.Forms.DataGridView();
            this.tabViewInventory = new System.Windows.Forms.TabPage();
            this.labelSuppliersInventory = new System.Windows.Forms.Label();
            this.labelPurchaseData = new System.Windows.Forms.Label();
            this.labelRoseName = new System.Windows.Forms.Label();
            this.textBoxRoseName = new System.Windows.Forms.TextBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelPricePerStem = new System.Windows.Forms.Label();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.textBoxPricePerStem = new System.Windows.Forms.TextBox();
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.tabControlManager.SuspendLayout();
            this.tabPagePurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventoryPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlManager
            // 
            this.tabControlManager.Controls.Add(this.tabPagePurchase);
            this.tabControlManager.Controls.Add(this.tabViewInventory);
            this.tabControlManager.Location = new System.Drawing.Point(12, 12);
            this.tabControlManager.Name = "tabControlManager";
            this.tabControlManager.SelectedIndex = 0;
            this.tabControlManager.Size = new System.Drawing.Size(1016, 661);
            this.tabControlManager.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlManager.TabIndex = 1;
            // 
            // tabPagePurchase
            // 
            this.tabPagePurchase.Controls.Add(this.buttonPurchase);
            this.tabPagePurchase.Controls.Add(this.textBoxPricePerStem);
            this.tabPagePurchase.Controls.Add(this.textBoxGroup);
            this.tabPagePurchase.Controls.Add(this.labelPricePerStem);
            this.tabPagePurchase.Controls.Add(this.labelGroup);
            this.tabPagePurchase.Controls.Add(this.textBoxRoseName);
            this.tabPagePurchase.Controls.Add(this.labelRoseName);
            this.tabPagePurchase.Controls.Add(this.labelPurchaseData);
            this.tabPagePurchase.Controls.Add(this.labelSuppliersInventory);
            this.tabPagePurchase.Controls.Add(this.dataGridView1);
            this.tabPagePurchase.Controls.Add(this.dataGridViewInventoryPurchase);
            this.tabPagePurchase.Location = new System.Drawing.Point(4, 25);
            this.tabPagePurchase.Name = "tabPagePurchase";
            this.tabPagePurchase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePurchase.Size = new System.Drawing.Size(1008, 632);
            this.tabPagePurchase.TabIndex = 0;
            this.tabPagePurchase.Text = "Purchase";
            this.tabPagePurchase.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 363);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(872, 236);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridViewInventoryPurchase
            // 
            this.dataGridViewInventoryPurchase.AllowUserToAddRows = false;
            this.dataGridViewInventoryPurchase.AllowUserToDeleteRows = false;
            this.dataGridViewInventoryPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventoryPurchase.Location = new System.Drawing.Point(58, 59);
            this.dataGridViewInventoryPurchase.Name = "dataGridViewInventoryPurchase";
            this.dataGridViewInventoryPurchase.ReadOnly = true;
            this.dataGridViewInventoryPurchase.RowHeadersWidth = 51;
            this.dataGridViewInventoryPurchase.RowTemplate.Height = 24;
            this.dataGridViewInventoryPurchase.Size = new System.Drawing.Size(458, 228);
            this.dataGridViewInventoryPurchase.TabIndex = 0;
            // 
            // tabViewInventory
            // 
            this.tabViewInventory.Location = new System.Drawing.Point(4, 25);
            this.tabViewInventory.Name = "tabViewInventory";
            this.tabViewInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewInventory.Size = new System.Drawing.Size(1008, 632);
            this.tabViewInventory.TabIndex = 1;
            this.tabViewInventory.Text = "Inventory";
            this.tabViewInventory.UseVisualStyleBackColor = true;
            // 
            // labelSuppliersInventory
            // 
            this.labelSuppliersInventory.AutoSize = true;
            this.labelSuppliersInventory.Location = new System.Drawing.Point(55, 26);
            this.labelSuppliersInventory.Name = "labelSuppliersInventory";
            this.labelSuppliersInventory.Size = new System.Drawing.Size(125, 17);
            this.labelSuppliersInventory.TabIndex = 2;
            this.labelSuppliersInventory.Text = "SuppliersInventory";
            // 
            // labelPurchaseData
            // 
            this.labelPurchaseData.AutoSize = true;
            this.labelPurchaseData.Location = new System.Drawing.Point(55, 322);
            this.labelPurchaseData.Name = "labelPurchaseData";
            this.labelPurchaseData.Size = new System.Drawing.Size(98, 17);
            this.labelPurchaseData.TabIndex = 3;
            this.labelPurchaseData.Text = "PurchaseData";
            // 
            // labelRoseName
            // 
            this.labelRoseName.AutoSize = true;
            this.labelRoseName.Location = new System.Drawing.Point(578, 98);
            this.labelRoseName.Name = "labelRoseName";
            this.labelRoseName.Size = new System.Drawing.Size(78, 17);
            this.labelRoseName.TabIndex = 4;
            this.labelRoseName.Text = "RoseName";
            // 
            // textBoxRoseName
            // 
            this.textBoxRoseName.Location = new System.Drawing.Point(708, 93);
            this.textBoxRoseName.Name = "textBoxRoseName";
            this.textBoxRoseName.Size = new System.Drawing.Size(136, 22);
            this.textBoxRoseName.TabIndex = 5;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(578, 146);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(48, 17);
            this.labelGroup.TabIndex = 6;
            this.labelGroup.Text = "Group";
            // 
            // labelPricePerStem
            // 
            this.labelPricePerStem.AutoSize = true;
            this.labelPricePerStem.Location = new System.Drawing.Point(578, 196);
            this.labelPricePerStem.Name = "labelPricePerStem";
            this.labelPricePerStem.Size = new System.Drawing.Size(99, 17);
            this.labelPricePerStem.TabIndex = 7;
            this.labelPricePerStem.Text = "Price per stem";
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(708, 143);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(136, 22);
            this.textBoxGroup.TabIndex = 8;
            // 
            // textBoxPricePerStem
            // 
            this.textBoxPricePerStem.Location = new System.Drawing.Point(708, 193);
            this.textBoxPricePerStem.Name = "textBoxPricePerStem";
            this.textBoxPricePerStem.Size = new System.Drawing.Size(136, 22);
            this.textBoxPricePerStem.TabIndex = 9;
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.Location = new System.Drawing.Point(644, 248);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(122, 39);
            this.buttonPurchase.TabIndex = 10;
            this.buttonPurchase.Text = "buttonPurchase";
            this.buttonPurchase.UseVisualStyleBackColor = true;
            // 
            // PurchasingAgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 674);
            this.Controls.Add(this.tabControlManager);
            this.Name = "PurchasingAgentForm";
            this.Text = "PurchasingAgentForm";
            this.tabControlManager.ResumeLayout(false);
            this.tabPagePurchase.ResumeLayout(false);
            this.tabPagePurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventoryPurchase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlManager;
        private System.Windows.Forms.TabPage tabPagePurchase;
        private System.Windows.Forms.TabPage tabViewInventory;
        private System.Windows.Forms.DataGridView dataGridViewInventoryPurchase;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxPricePerStem;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.Label labelPricePerStem;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.TextBox textBoxRoseName;
        private System.Windows.Forms.Label labelRoseName;
        private System.Windows.Forms.Label labelPurchaseData;
        private System.Windows.Forms.Label labelSuppliersInventory;
        private System.Windows.Forms.Button buttonPurchase;
    }
}