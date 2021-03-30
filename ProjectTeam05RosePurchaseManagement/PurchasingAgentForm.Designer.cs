
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.textBoxPricePerStem = new System.Windows.Forms.TextBox();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.labelPricePerStem = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.textBoxRoseName = new System.Windows.Forms.TextBox();
            this.labelRoseName = new System.Windows.Forms.Label();
            this.labelPurchaseData = new System.Windows.Forms.Label();
            this.labelSuppliersInventory = new System.Windows.Forms.Label();
            this.dataGridViewPurchase = new System.Windows.Forms.DataGridView();
            this.dataGridViewInventoryPurchase = new System.Windows.Forms.DataGridView();
            this.tabControlManager.SuspendLayout();
            this.tabPagePurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventoryPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlManager
            // 
            this.tabControlManager.Controls.Add(this.tabPagePurchase);
            this.tabControlManager.Location = new System.Drawing.Point(12, 12);
            this.tabControlManager.Name = "tabControlManager";
            this.tabControlManager.SelectedIndex = 0;
            this.tabControlManager.Size = new System.Drawing.Size(1122, 674);
            this.tabControlManager.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlManager.TabIndex = 1;
            // 
            // tabPagePurchase
            // 
            this.tabPagePurchase.Controls.Add(this.label2);
            this.tabPagePurchase.Controls.Add(this.label1);
            this.tabPagePurchase.Controls.Add(this.dataGridViewOrder);
            this.tabPagePurchase.Controls.Add(this.buttonPurchase);
            this.tabPagePurchase.Controls.Add(this.textBoxPricePerStem);
            this.tabPagePurchase.Controls.Add(this.textBoxGroup);
            this.tabPagePurchase.Controls.Add(this.labelPricePerStem);
            this.tabPagePurchase.Controls.Add(this.labelGroup);
            this.tabPagePurchase.Controls.Add(this.textBoxRoseName);
            this.tabPagePurchase.Controls.Add(this.labelRoseName);
            this.tabPagePurchase.Controls.Add(this.labelPurchaseData);
            this.tabPagePurchase.Controls.Add(this.labelSuppliersInventory);
            this.tabPagePurchase.Controls.Add(this.dataGridViewPurchase);
            this.tabPagePurchase.Controls.Add(this.dataGridViewInventoryPurchase);
            this.tabPagePurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePurchase.Location = new System.Drawing.Point(4, 25);
            this.tabPagePurchase.Name = "tabPagePurchase";
            this.tabPagePurchase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePurchase.Size = new System.Drawing.Size(1114, 645);
            this.tabPagePurchase.TabIndex = 0;
            this.tabPagePurchase.Text = "Purchase";
            this.tabPagePurchase.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(788, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Order to be Fulfilled";
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AllowUserToAddRows = false;
            this.dataGridViewOrder.AllowUserToDeleteRows = false;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(58, 62);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.ReadOnly = true;
            this.dataGridViewOrder.RowHeadersWidth = 51;
            this.dataGridViewOrder.RowTemplate.Height = 24;
            this.dataGridViewOrder.Size = new System.Drawing.Size(336, 228);
            this.dataGridViewOrder.TabIndex = 11;
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.Location = new System.Drawing.Point(854, 245);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(122, 39);
            this.buttonPurchase.TabIndex = 10;
            this.buttonPurchase.Text = "Purchase";
            this.buttonPurchase.UseVisualStyleBackColor = true;
            // 
            // textBoxPricePerStem
            // 
            this.textBoxPricePerStem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPricePerStem.Location = new System.Drawing.Point(897, 181);
            this.textBoxPricePerStem.Name = "textBoxPricePerStem";
            this.textBoxPricePerStem.Size = new System.Drawing.Size(177, 24);
            this.textBoxPricePerStem.TabIndex = 9;
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGroup.Location = new System.Drawing.Point(897, 140);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(177, 24);
            this.textBoxGroup.TabIndex = 8;
            // 
            // labelPricePerStem
            // 
            this.labelPricePerStem.AutoSize = true;
            this.labelPricePerStem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPricePerStem.Location = new System.Drawing.Point(788, 184);
            this.labelPricePerStem.Name = "labelPricePerStem";
            this.labelPricePerStem.Size = new System.Drawing.Size(104, 18);
            this.labelPricePerStem.TabIndex = 7;
            this.labelPricePerStem.Text = "Price per stem";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroup.Location = new System.Drawing.Point(788, 143);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(50, 18);
            this.labelGroup.TabIndex = 6;
            this.labelGroup.Text = "Group";
            // 
            // textBoxRoseName
            // 
            this.textBoxRoseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoseName.Location = new System.Drawing.Point(897, 100);
            this.textBoxRoseName.Name = "textBoxRoseName";
            this.textBoxRoseName.Size = new System.Drawing.Size(177, 24);
            this.textBoxRoseName.TabIndex = 5;
            // 
            // labelRoseName
            // 
            this.labelRoseName.AutoSize = true;
            this.labelRoseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoseName.Location = new System.Drawing.Point(788, 105);
            this.labelRoseName.Name = "labelRoseName";
            this.labelRoseName.Size = new System.Drawing.Size(84, 18);
            this.labelRoseName.TabIndex = 4;
            this.labelRoseName.Text = "RoseName";
            // 
            // labelPurchaseData
            // 
            this.labelPurchaseData.AutoSize = true;
            this.labelPurchaseData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPurchaseData.Location = new System.Drawing.Point(55, 322);
            this.labelPurchaseData.Name = "labelPurchaseData";
            this.labelPurchaseData.Size = new System.Drawing.Size(114, 18);
            this.labelPurchaseData.TabIndex = 3;
            this.labelPurchaseData.Text = "PurchaseData";
            // 
            // labelSuppliersInventory
            // 
            this.labelSuppliersInventory.AutoSize = true;
            this.labelSuppliersInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuppliersInventory.Location = new System.Drawing.Point(434, 28);
            this.labelSuppliersInventory.Name = "labelSuppliersInventory";
            this.labelSuppliersInventory.Size = new System.Drawing.Size(146, 18);
            this.labelSuppliersInventory.TabIndex = 2;
            this.labelSuppliersInventory.Text = "SuppliersInventory";
            // 
            // dataGridViewPurchase
            // 
            this.dataGridViewPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchase.Location = new System.Drawing.Point(58, 363);
            this.dataGridViewPurchase.Name = "dataGridViewPurchase";
            this.dataGridViewPurchase.RowHeadersWidth = 51;
            this.dataGridViewPurchase.RowTemplate.Height = 24;
            this.dataGridViewPurchase.Size = new System.Drawing.Size(1016, 236);
            this.dataGridViewPurchase.TabIndex = 1;
            // 
            // dataGridViewInventoryPurchase
            // 
            this.dataGridViewInventoryPurchase.AllowUserToAddRows = false;
            this.dataGridViewInventoryPurchase.AllowUserToDeleteRows = false;
            this.dataGridViewInventoryPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventoryPurchase.Location = new System.Drawing.Point(437, 62);
            this.dataGridViewInventoryPurchase.Name = "dataGridViewInventoryPurchase";
            this.dataGridViewInventoryPurchase.ReadOnly = true;
            this.dataGridViewInventoryPurchase.RowHeadersWidth = 51;
            this.dataGridViewInventoryPurchase.RowTemplate.Height = 24;
            this.dataGridViewInventoryPurchase.Size = new System.Drawing.Size(336, 228);
            this.dataGridViewInventoryPurchase.TabIndex = 0;
            // 
            // PurchasingAgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 675);
            this.Controls.Add(this.tabControlManager);
            this.Name = "PurchasingAgentForm";
            this.Text = "PurchasingAgentForm";
            this.tabControlManager.ResumeLayout(false);
            this.tabPagePurchase.ResumeLayout(false);
            this.tabPagePurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventoryPurchase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlManager;
        private System.Windows.Forms.TabPage tabPagePurchase;
        private System.Windows.Forms.DataGridView dataGridViewInventoryPurchase;
        private System.Windows.Forms.DataGridView dataGridViewPurchase;
        private System.Windows.Forms.TextBox textBoxPricePerStem;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.Label labelPricePerStem;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.TextBox textBoxRoseName;
        private System.Windows.Forms.Label labelRoseName;
        private System.Windows.Forms.Label labelPurchaseData;
        private System.Windows.Forms.Label labelSuppliersInventory;
        private System.Windows.Forms.Button buttonPurchase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
    }
}