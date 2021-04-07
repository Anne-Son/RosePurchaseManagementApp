
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
            this.textBoxInvoiceID = new System.Windows.Forms.TextBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.listBoxBox = new System.Windows.Forms.ListBox();
            this.listBoxWarehouse = new System.Windows.Forms.ListBox();
            this.listBoxInvoice = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelOrderToBeFulfilled = new System.Windows.Forms.Label();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.textBoxPricePerStem = new System.Windows.Forms.TextBox();
            this.textBoxRoseSizeID = new System.Windows.Forms.TextBox();
            this.labelPricePerStem = new System.Windows.Forms.Label();
            this.labelRoseSizeID = new System.Windows.Forms.Label();
            this.textBoxFarmName = new System.Windows.Forms.TextBox();
            this.labelFarmName = new System.Windows.Forms.Label();
            this.labelPurchaseData = new System.Windows.Forms.Label();
            this.labelSuppliersInventory = new System.Windows.Forms.Label();
            this.dataGridViewPurchase = new System.Windows.Forms.DataGridView();
            this.dataGridViewSuppliersInventory = new System.Windows.Forms.DataGridView();
            this.tabViewInvoice = new System.Windows.Forms.TabPage();
            this.textBoxInvoiceNumber = new System.Windows.Forms.TextBox();
            this.labelInvoiceNumber = new System.Windows.Forms.Label();
            this.buttonInvoiceDelete = new System.Windows.Forms.Button();
            this.buttonInvoiceUpdate = new System.Windows.Forms.Button();
            this.buttonInvoiceAdd = new System.Windows.Forms.Button();
            this.labelFarms = new System.Windows.Forms.Label();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.dateTimePickerInvoice = new System.Windows.Forms.DateTimePicker();
            this.listBoxFarms = new System.Windows.Forms.ListBox();
            this.labelInvoice = new System.Windows.Forms.Label();
            this.dataGridViewInvoice = new System.Windows.Forms.DataGridView();
            this.buttonUpdatePurchase = new System.Windows.Forms.Button();
            this.tabControlManager.SuspendLayout();
            this.tabPagePurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliersInventory)).BeginInit();
            this.tabViewInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlManager
            // 
            this.tabControlManager.Controls.Add(this.tabPagePurchase);
            this.tabControlManager.Controls.Add(this.tabViewInvoice);
            this.tabControlManager.Location = new System.Drawing.Point(-12, 12);
            this.tabControlManager.Name = "tabControlManager";
            this.tabControlManager.SelectedIndex = 0;
            this.tabControlManager.Size = new System.Drawing.Size(1397, 861);
            this.tabControlManager.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlManager.TabIndex = 1;
            // 
            // tabPagePurchase
            // 
            this.tabPagePurchase.Controls.Add(this.buttonUpdatePurchase);
            this.tabPagePurchase.Controls.Add(this.textBoxInvoiceID);
            this.tabPagePurchase.Controls.Add(this.buttonSelect);
            this.tabPagePurchase.Controls.Add(this.textBoxQuantity);
            this.tabPagePurchase.Controls.Add(this.labelQuantity);
            this.tabPagePurchase.Controls.Add(this.listBoxBox);
            this.tabPagePurchase.Controls.Add(this.listBoxWarehouse);
            this.tabPagePurchase.Controls.Add(this.listBoxInvoice);
            this.tabPagePurchase.Controls.Add(this.buttonDelete);
            this.tabPagePurchase.Controls.Add(this.labelSearch);
            this.tabPagePurchase.Controls.Add(this.labelOrderToBeFulfilled);
            this.tabPagePurchase.Controls.Add(this.dataGridViewOrder);
            this.tabPagePurchase.Controls.Add(this.buttonPurchase);
            this.tabPagePurchase.Controls.Add(this.textBoxPricePerStem);
            this.tabPagePurchase.Controls.Add(this.textBoxRoseSizeID);
            this.tabPagePurchase.Controls.Add(this.labelPricePerStem);
            this.tabPagePurchase.Controls.Add(this.labelRoseSizeID);
            this.tabPagePurchase.Controls.Add(this.textBoxFarmName);
            this.tabPagePurchase.Controls.Add(this.labelFarmName);
            this.tabPagePurchase.Controls.Add(this.labelPurchaseData);
            this.tabPagePurchase.Controls.Add(this.labelSuppliersInventory);
            this.tabPagePurchase.Controls.Add(this.dataGridViewPurchase);
            this.tabPagePurchase.Controls.Add(this.dataGridViewSuppliersInventory);
            this.tabPagePurchase.Location = new System.Drawing.Point(4, 25);
            this.tabPagePurchase.Name = "tabPagePurchase";
            this.tabPagePurchase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePurchase.Size = new System.Drawing.Size(1389, 832);
            this.tabPagePurchase.TabIndex = 0;
            this.tabPagePurchase.Text = "Purchase";
            this.tabPagePurchase.UseVisualStyleBackColor = true;
            // 
            // textBoxInvoiceID
            // 
            this.textBoxInvoiceID.Location = new System.Drawing.Point(395, 465);
            this.textBoxInvoiceID.Name = "textBoxInvoiceID";
            this.textBoxInvoiceID.Size = new System.Drawing.Size(136, 22);
            this.textBoxInvoiceID.TabIndex = 24;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(1202, 152);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(122, 39);
            this.buttonSelect.TabIndex = 23;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(201, 447);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(136, 22);
            this.textBoxQuantity.TabIndex = 22;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(71, 450);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(61, 17);
            this.labelQuantity.TabIndex = 21;
            this.labelQuantity.Text = "Quantity";
            // 
            // listBoxBox
            // 
            this.listBoxBox.FormattingEnabled = true;
            this.listBoxBox.ItemHeight = 16;
            this.listBoxBox.Location = new System.Drawing.Point(993, 332);
            this.listBoxBox.Name = "listBoxBox";
            this.listBoxBox.Size = new System.Drawing.Size(153, 116);
            this.listBoxBox.TabIndex = 20;
            // 
            // listBoxWarehouse
            // 
            this.listBoxWarehouse.FormattingEnabled = true;
            this.listBoxWarehouse.ItemHeight = 16;
            this.listBoxWarehouse.Location = new System.Drawing.Point(777, 332);
            this.listBoxWarehouse.Name = "listBoxWarehouse";
            this.listBoxWarehouse.Size = new System.Drawing.Size(182, 116);
            this.listBoxWarehouse.TabIndex = 19;
            // 
            // listBoxInvoice
            // 
            this.listBoxInvoice.FormattingEnabled = true;
            this.listBoxInvoice.ItemHeight = 16;
            this.listBoxInvoice.Location = new System.Drawing.Point(395, 332);
            this.listBoxInvoice.Name = "listBoxInvoice";
            this.listBoxInvoice.Size = new System.Drawing.Size(343, 116);
            this.listBoxInvoice.TabIndex = 18;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1178, 705);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(122, 39);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(1059, 65);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(0, 17);
            this.labelSearch.TabIndex = 13;
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
            // buttonPurchase
            // 
            this.buttonPurchase.Location = new System.Drawing.Point(1178, 576);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(122, 39);
            this.buttonPurchase.TabIndex = 10;
            this.buttonPurchase.Text = "Purchase";
            this.buttonPurchase.UseVisualStyleBackColor = true;
            // 
            // textBoxPricePerStem
            // 
            this.textBoxPricePerStem.Location = new System.Drawing.Point(201, 409);
            this.textBoxPricePerStem.Name = "textBoxPricePerStem";
            this.textBoxPricePerStem.Size = new System.Drawing.Size(136, 22);
            this.textBoxPricePerStem.TabIndex = 9;
            // 
            // textBoxRoseSizeID
            // 
            this.textBoxRoseSizeID.Location = new System.Drawing.Point(201, 372);
            this.textBoxRoseSizeID.Name = "textBoxRoseSizeID";
            this.textBoxRoseSizeID.Size = new System.Drawing.Size(136, 22);
            this.textBoxRoseSizeID.TabIndex = 8;
            // 
            // labelPricePerStem
            // 
            this.labelPricePerStem.AutoSize = true;
            this.labelPricePerStem.Location = new System.Drawing.Point(71, 412);
            this.labelPricePerStem.Name = "labelPricePerStem";
            this.labelPricePerStem.Size = new System.Drawing.Size(99, 17);
            this.labelPricePerStem.TabIndex = 7;
            this.labelPricePerStem.Text = "Price per stem";
            // 
            // labelRoseSizeID
            // 
            this.labelRoseSizeID.AutoSize = true;
            this.labelRoseSizeID.Location = new System.Drawing.Point(71, 375);
            this.labelRoseSizeID.Name = "labelRoseSizeID";
            this.labelRoseSizeID.Size = new System.Drawing.Size(81, 17);
            this.labelRoseSizeID.TabIndex = 6;
            this.labelRoseSizeID.Text = "RoseSizeID";
            // 
            // textBoxFarmName
            // 
            this.textBoxFarmName.Location = new System.Drawing.Point(201, 332);
            this.textBoxFarmName.Name = "textBoxFarmName";
            this.textBoxFarmName.Size = new System.Drawing.Size(136, 22);
            this.textBoxFarmName.TabIndex = 5;
            // 
            // labelFarmName
            // 
            this.labelFarmName.AutoSize = true;
            this.labelFarmName.Location = new System.Drawing.Point(71, 337);
            this.labelFarmName.Name = "labelFarmName";
            this.labelFarmName.Size = new System.Drawing.Size(89, 17);
            this.labelFarmName.TabIndex = 4;
            this.labelFarmName.Text = "Farnm Name";
            // 
            // labelPurchaseData
            // 
            this.labelPurchaseData.AutoSize = true;
            this.labelPurchaseData.Location = new System.Drawing.Point(99, 514);
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
            this.dataGridViewPurchase.Location = new System.Drawing.Point(74, 544);
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
            this.dataGridViewSuppliersInventory.Size = new System.Drawing.Size(603, 228);
            this.dataGridViewSuppliersInventory.TabIndex = 0;
            // 
            // tabViewInvoice
            // 
            this.tabViewInvoice.Controls.Add(this.textBoxInvoiceNumber);
            this.tabViewInvoice.Controls.Add(this.labelInvoiceNumber);
            this.tabViewInvoice.Controls.Add(this.buttonInvoiceDelete);
            this.tabViewInvoice.Controls.Add(this.buttonInvoiceUpdate);
            this.tabViewInvoice.Controls.Add(this.buttonInvoiceAdd);
            this.tabViewInvoice.Controls.Add(this.labelFarms);
            this.tabViewInvoice.Controls.Add(this.labelTotalAmount);
            this.tabViewInvoice.Controls.Add(this.label1);
            this.tabViewInvoice.Controls.Add(this.textBoxTotalAmount);
            this.tabViewInvoice.Controls.Add(this.dateTimePickerInvoice);
            this.tabViewInvoice.Controls.Add(this.listBoxFarms);
            this.tabViewInvoice.Controls.Add(this.labelInvoice);
            this.tabViewInvoice.Controls.Add(this.dataGridViewInvoice);
            this.tabViewInvoice.Location = new System.Drawing.Point(4, 25);
            this.tabViewInvoice.Name = "tabViewInvoice";
            this.tabViewInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewInvoice.Size = new System.Drawing.Size(1389, 832);
            this.tabViewInvoice.TabIndex = 1;
            this.tabViewInvoice.Text = "Invoice";
            this.tabViewInvoice.UseVisualStyleBackColor = true;
            // 
            // textBoxInvoiceNumber
            // 
            this.textBoxInvoiceNumber.Location = new System.Drawing.Point(233, 384);
            this.textBoxInvoiceNumber.Name = "textBoxInvoiceNumber";
            this.textBoxInvoiceNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxInvoiceNumber.TabIndex = 12;
            // 
            // labelInvoiceNumber
            // 
            this.labelInvoiceNumber.AutoSize = true;
            this.labelInvoiceNumber.Location = new System.Drawing.Point(102, 389);
            this.labelInvoiceNumber.Name = "labelInvoiceNumber";
            this.labelInvoiceNumber.Size = new System.Drawing.Size(106, 17);
            this.labelInvoiceNumber.TabIndex = 11;
            this.labelInvoiceNumber.Text = "Invoice Number";
            // 
            // buttonInvoiceDelete
            // 
            this.buttonInvoiceDelete.Location = new System.Drawing.Point(561, 558);
            this.buttonInvoiceDelete.Name = "buttonInvoiceDelete";
            this.buttonInvoiceDelete.Size = new System.Drawing.Size(118, 48);
            this.buttonInvoiceDelete.TabIndex = 10;
            this.buttonInvoiceDelete.Text = "Delete";
            this.buttonInvoiceDelete.UseVisualStyleBackColor = true;
            // 
            // buttonInvoiceUpdate
            // 
            this.buttonInvoiceUpdate.Location = new System.Drawing.Point(342, 558);
            this.buttonInvoiceUpdate.Name = "buttonInvoiceUpdate";
            this.buttonInvoiceUpdate.Size = new System.Drawing.Size(118, 48);
            this.buttonInvoiceUpdate.TabIndex = 9;
            this.buttonInvoiceUpdate.Text = "Update";
            this.buttonInvoiceUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonInvoiceAdd
            // 
            this.buttonInvoiceAdd.Location = new System.Drawing.Point(105, 558);
            this.buttonInvoiceAdd.Name = "buttonInvoiceAdd";
            this.buttonInvoiceAdd.Size = new System.Drawing.Size(118, 48);
            this.buttonInvoiceAdd.TabIndex = 8;
            this.buttonInvoiceAdd.Text = "Add";
            this.buttonInvoiceAdd.UseVisualStyleBackColor = true;
            // 
            // labelFarms
            // 
            this.labelFarms.AutoSize = true;
            this.labelFarms.Location = new System.Drawing.Point(560, 358);
            this.labelFarms.Name = "labelFarms";
            this.labelFarms.Size = new System.Drawing.Size(47, 17);
            this.labelFarms.TabIndex = 7;
            this.labelFarms.Text = "Farms";
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Location = new System.Drawing.Point(102, 488);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(92, 17);
            this.labelTotalAmount.TabIndex = 6;
            this.labelTotalAmount.Text = "Total Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date";
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.Location = new System.Drawing.Point(233, 488);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.Size = new System.Drawing.Size(100, 22);
            this.textBoxTotalAmount.TabIndex = 4;
            // 
            // dateTimePickerInvoice
            // 
            this.dateTimePickerInvoice.Location = new System.Drawing.Point(233, 435);
            this.dateTimePickerInvoice.Name = "dateTimePickerInvoice";
            this.dateTimePickerInvoice.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerInvoice.TabIndex = 3;
            // 
            // listBoxFarms
            // 
            this.listBoxFarms.FormattingEnabled = true;
            this.listBoxFarms.ItemHeight = 16;
            this.listBoxFarms.Location = new System.Drawing.Point(563, 389);
            this.listBoxFarms.Name = "listBoxFarms";
            this.listBoxFarms.Size = new System.Drawing.Size(142, 116);
            this.listBoxFarms.TabIndex = 2;
            // 
            // labelInvoice
            // 
            this.labelInvoice.AutoSize = true;
            this.labelInvoice.Location = new System.Drawing.Point(85, 42);
            this.labelInvoice.Name = "labelInvoice";
            this.labelInvoice.Size = new System.Drawing.Size(52, 17);
            this.labelInvoice.TabIndex = 1;
            this.labelInvoice.Text = "Invoice";
            // 
            // dataGridViewInvoice
            // 
            this.dataGridViewInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoice.Location = new System.Drawing.Point(88, 80);
            this.dataGridViewInvoice.Name = "dataGridViewInvoice";
            this.dataGridViewInvoice.RowHeadersWidth = 51;
            this.dataGridViewInvoice.RowTemplate.Height = 24;
            this.dataGridViewInvoice.Size = new System.Drawing.Size(617, 256);
            this.dataGridViewInvoice.TabIndex = 0;
            // 
            // buttonUpdatePurchase
            // 
            this.buttonUpdatePurchase.Location = new System.Drawing.Point(1178, 638);
            this.buttonUpdatePurchase.Name = "buttonUpdatePurchase";
            this.buttonUpdatePurchase.Size = new System.Drawing.Size(122, 39);
            this.buttonUpdatePurchase.TabIndex = 25;
            this.buttonUpdatePurchase.Text = "Update";
            this.buttonUpdatePurchase.UseVisualStyleBackColor = true;
            // 
            // PurchasingAgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 871);
            this.Controls.Add(this.tabControlManager);
            this.Name = "PurchasingAgentForm";
            this.Text = "PurchasingAgentForm";
            this.tabControlManager.ResumeLayout(false);
            this.tabPagePurchase.ResumeLayout(false);
            this.tabPagePurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliersInventory)).EndInit();
            this.tabViewInvoice.ResumeLayout(false);
            this.tabViewInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlManager;
        private System.Windows.Forms.TabPage tabPagePurchase;
        private System.Windows.Forms.TabPage tabViewInvoice;
        private System.Windows.Forms.DataGridView dataGridViewSuppliersInventory;
        private System.Windows.Forms.DataGridView dataGridViewPurchase;
        private System.Windows.Forms.TextBox textBoxPricePerStem;
        private System.Windows.Forms.TextBox textBoxRoseSizeID;
        private System.Windows.Forms.Label labelPricePerStem;
        private System.Windows.Forms.Label labelRoseSizeID;
        private System.Windows.Forms.TextBox textBoxFarmName;
        private System.Windows.Forms.Label labelFarmName;
        private System.Windows.Forms.Label labelPurchaseData;
        private System.Windows.Forms.Label labelSuppliersInventory;
        private System.Windows.Forms.Button buttonPurchase;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelOrderToBeFulfilled;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.ListBox listBoxBox;
        private System.Windows.Forms.ListBox listBoxWarehouse;
        private System.Windows.Forms.ListBox listBoxInvoice;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label labelInvoice;
        private System.Windows.Forms.DataGridView dataGridViewInvoice;
        private System.Windows.Forms.Button buttonInvoiceUpdate;
        private System.Windows.Forms.Button buttonInvoiceAdd;
        private System.Windows.Forms.Label labelFarms;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.DateTimePicker dateTimePickerInvoice;
        private System.Windows.Forms.ListBox listBoxFarms;
        private System.Windows.Forms.Button buttonInvoiceDelete;
        private System.Windows.Forms.TextBox textBoxInvoiceNumber;
        private System.Windows.Forms.Label labelInvoiceNumber;
        private System.Windows.Forms.TextBox textBoxInvoiceID;
        private System.Windows.Forms.Button buttonUpdatePurchase;
    }
}