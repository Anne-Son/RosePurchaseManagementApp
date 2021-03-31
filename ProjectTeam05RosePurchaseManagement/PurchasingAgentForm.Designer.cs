
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
            this.dataGridViewSuppliersInventory = new System.Windows.Forms.DataGridView();
            this.tabViewInventory = new System.Windows.Forms.TabPage();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.labelOrderToBeFulfilled = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.buttonAddUpdate = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.tabControlManager.SuspendLayout();
            this.tabPagePurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliersInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlManager
            // 
            this.tabControlManager.Controls.Add(this.tabPagePurchase);
            this.tabControlManager.Controls.Add(this.tabViewInventory);
            this.tabControlManager.Location = new System.Drawing.Point(12, 12);
            this.tabControlManager.Name = "tabControlManager";
            this.tabControlManager.SelectedIndex = 0;
            this.tabControlManager.Size = new System.Drawing.Size(1373, 661);
            this.tabControlManager.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlManager.TabIndex = 1;
            // 
            // tabPagePurchase
            // 
            this.tabPagePurchase.Controls.Add(this.buttonDelete);
            this.tabPagePurchase.Controls.Add(this.buttonSearch);
            this.tabPagePurchase.Controls.Add(this.buttonAddUpdate);
            this.tabPagePurchase.Controls.Add(this.labelSearch);
            this.tabPagePurchase.Controls.Add(this.labelOrderToBeFulfilled);
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
            this.tabPagePurchase.Controls.Add(this.dataGridViewSuppliersInventory);
            this.tabPagePurchase.Location = new System.Drawing.Point(4, 25);
            this.tabPagePurchase.Name = "tabPagePurchase";
            this.tabPagePurchase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePurchase.Size = new System.Drawing.Size(1365, 632);
            this.tabPagePurchase.TabIndex = 0;
            this.tabPagePurchase.Text = "Purchase";
            this.tabPagePurchase.UseVisualStyleBackColor = true;
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.Location = new System.Drawing.Point(1203, 254);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(122, 39);
            this.buttonPurchase.TabIndex = 10;
            this.buttonPurchase.Text = "Purchase";
            this.buttonPurchase.UseVisualStyleBackColor = true;
            // 
            // textBoxPricePerStem
            // 
            this.textBoxPricePerStem.Location = new System.Drawing.Point(1189, 191);
            this.textBoxPricePerStem.Name = "textBoxPricePerStem";
            this.textBoxPricePerStem.Size = new System.Drawing.Size(136, 22);
            this.textBoxPricePerStem.TabIndex = 9;
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(1189, 149);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(136, 22);
            this.textBoxGroup.TabIndex = 8;
            // 
            // labelPricePerStem
            // 
            this.labelPricePerStem.AutoSize = true;
            this.labelPricePerStem.Location = new System.Drawing.Point(1059, 194);
            this.labelPricePerStem.Name = "labelPricePerStem";
            this.labelPricePerStem.Size = new System.Drawing.Size(99, 17);
            this.labelPricePerStem.TabIndex = 7;
            this.labelPricePerStem.Text = "Price per stem";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(1059, 152);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(48, 17);
            this.labelGroup.TabIndex = 6;
            this.labelGroup.Text = "Group";
            // 
            // textBoxRoseName
            // 
            this.textBoxRoseName.Location = new System.Drawing.Point(1189, 109);
            this.textBoxRoseName.Name = "textBoxRoseName";
            this.textBoxRoseName.Size = new System.Drawing.Size(136, 22);
            this.textBoxRoseName.TabIndex = 5;
            // 
            // labelRoseName
            // 
            this.labelRoseName.AutoSize = true;
            this.labelRoseName.Location = new System.Drawing.Point(1059, 114);
            this.labelRoseName.Name = "labelRoseName";
            this.labelRoseName.Size = new System.Drawing.Size(78, 17);
            this.labelRoseName.TabIndex = 4;
            this.labelRoseName.Text = "RoseName";
            // 
            // labelPurchaseData
            // 
            this.labelPurchaseData.AutoSize = true;
            this.labelPurchaseData.Location = new System.Drawing.Point(99, 324);
            this.labelPurchaseData.Name = "labelPurchaseData";
            this.labelPurchaseData.Size = new System.Drawing.Size(102, 17);
            this.labelPurchaseData.TabIndex = 3;
            this.labelPurchaseData.Text = "Purchase Data";
            // 
            // labelSuppliersInventory
            // 
            this.labelSuppliersInventory.AutoSize = true;
            this.labelSuppliersInventory.Location = new System.Drawing.Point(572, 32);
            this.labelSuppliersInventory.Name = "labelSuppliersInventory";
            this.labelSuppliersInventory.Size = new System.Drawing.Size(129, 17);
            this.labelSuppliersInventory.TabIndex = 2;
            this.labelSuppliersInventory.Text = "Suppliers Inventory";
            // 
            // dataGridViewPurchase
            // 
            this.dataGridViewPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchase.Location = new System.Drawing.Point(74, 354);
            this.dataGridViewPurchase.Name = "dataGridViewPurchase";
            this.dataGridViewPurchase.RowHeadersWidth = 51;
            this.dataGridViewPurchase.RowTemplate.Height = 24;
            this.dataGridViewPurchase.Size = new System.Drawing.Size(1048, 236);
            this.dataGridViewPurchase.TabIndex = 1;
            // 
            // dataGridViewSuppliersInventory
            // 
            this.dataGridViewSuppliersInventory.AllowUserToAddRows = false;
            this.dataGridViewSuppliersInventory.AllowUserToDeleteRows = false;
            this.dataGridViewSuppliersInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuppliersInventory.Location = new System.Drawing.Point(548, 65);
            this.dataGridViewSuppliersInventory.Name = "dataGridViewSuppliersInventory";
            this.dataGridViewSuppliersInventory.ReadOnly = true;
            this.dataGridViewSuppliersInventory.RowHeadersWidth = 51;
            this.dataGridViewSuppliersInventory.RowTemplate.Height = 24;
            this.dataGridViewSuppliersInventory.Size = new System.Drawing.Size(473, 228);
            this.dataGridViewSuppliersInventory.TabIndex = 0;
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
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AllowUserToAddRows = false;
            this.dataGridViewOrder.AllowUserToDeleteRows = false;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(74, 65);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.ReadOnly = true;
            this.dataGridViewOrder.RowHeadersWidth = 51;
            this.dataGridViewOrder.RowTemplate.Height = 24;
            this.dataGridViewOrder.Size = new System.Drawing.Size(442, 228);
            this.dataGridViewOrder.TabIndex = 11;
            // 
            // labelOrderToBeFulfilled
            // 
            this.labelOrderToBeFulfilled.AutoSize = true;
            this.labelOrderToBeFulfilled.Location = new System.Drawing.Point(99, 32);
            this.labelOrderToBeFulfilled.Name = "labelOrderToBeFulfilled";
            this.labelOrderToBeFulfilled.Size = new System.Drawing.Size(139, 17);
            this.labelOrderToBeFulfilled.TabIndex = 12;
            this.labelOrderToBeFulfilled.Text = "Order To Be Fulfilled";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(1059, 65);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(125, 17);
            this.labelSearch.TabIndex = 13;
            this.labelSearch.Text = "SuppliersInventory";
            // 
            // buttonAddUpdate
            // 
            this.buttonAddUpdate.Location = new System.Drawing.Point(1189, 425);
            this.buttonAddUpdate.Name = "buttonAddUpdate";
            this.buttonAddUpdate.Size = new System.Drawing.Size(122, 39);
            this.buttonAddUpdate.TabIndex = 15;
            this.buttonAddUpdate.Text = "Add Update";
            this.buttonAddUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(1062, 254);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(122, 39);
            this.buttonSearch.TabIndex = 16;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1189, 495);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(122, 39);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // PurchasingAgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 674);
            this.Controls.Add(this.tabControlManager);
            this.Name = "PurchasingAgentForm";
            this.Text = "PurchasingAgentForm";
            this.tabControlManager.ResumeLayout(false);
            this.tabPagePurchase.ResumeLayout(false);
            this.tabPagePurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliersInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlManager;
        private System.Windows.Forms.TabPage tabPagePurchase;
        private System.Windows.Forms.TabPage tabViewInventory;
        private System.Windows.Forms.DataGridView dataGridViewSuppliersInventory;
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
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonAddUpdate;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelOrderToBeFulfilled;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Button buttonDelete;
    }
}