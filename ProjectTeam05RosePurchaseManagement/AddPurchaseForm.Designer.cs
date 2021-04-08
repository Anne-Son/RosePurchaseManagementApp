
namespace ProjectTeam05RosePurchaseManagement
{
    partial class AddPurchaseForm
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
            this.buttonAddPurchase = new System.Windows.Forms.Button();
            this.listBoxSuppliersInventory = new System.Windows.Forms.ListBox();
            this.listBoxBox = new System.Windows.Forms.ListBox();
            this.listBoxWarehouse = new System.Windows.Forms.ListBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxFarmName = new System.Windows.Forms.TextBox();
            this.textBoxRoseSizeID = new System.Windows.Forms.TextBox();
            this.textBoxPricePerStem = new System.Windows.Forms.TextBox();
            this.textBoxInvoiceID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddPurchase
            // 
            this.buttonAddPurchase.Location = new System.Drawing.Point(436, 343);
            this.buttonAddPurchase.Name = "buttonAddPurchase";
            this.buttonAddPurchase.Size = new System.Drawing.Size(147, 37);
            this.buttonAddPurchase.TabIndex = 0;
            this.buttonAddPurchase.Text = "Add Purchase";
            this.buttonAddPurchase.UseVisualStyleBackColor = true;
            // 
            // listBoxSuppliersInventory
            // 
            this.listBoxSuppliersInventory.FormattingEnabled = true;
            this.listBoxSuppliersInventory.ItemHeight = 16;
            this.listBoxSuppliersInventory.Location = new System.Drawing.Point(29, 37);
            this.listBoxSuppliersInventory.Name = "listBoxSuppliersInventory";
            this.listBoxSuppliersInventory.Size = new System.Drawing.Size(480, 196);
            this.listBoxSuppliersInventory.TabIndex = 1;
            // 
            // listBoxBox
            // 
            this.listBoxBox.FormattingEnabled = true;
            this.listBoxBox.ItemHeight = 16;
            this.listBoxBox.Location = new System.Drawing.Point(562, 41);
            this.listBoxBox.Name = "listBoxBox";
            this.listBoxBox.Size = new System.Drawing.Size(155, 116);
            this.listBoxBox.TabIndex = 2;
            // 
            // listBoxWarehouse
            // 
            this.listBoxWarehouse.FormattingEnabled = true;
            this.listBoxWarehouse.ItemHeight = 16;
            this.listBoxWarehouse.Location = new System.Drawing.Point(759, 41);
            this.listBoxWarehouse.Name = "listBoxWarehouse";
            this.listBoxWarehouse.Size = new System.Drawing.Size(117, 196);
            this.listBoxWarehouse.TabIndex = 3;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantity.Location = new System.Drawing.Point(562, 206);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(155, 27);
            this.textBoxQuantity.TabIndex = 4;
            // 
            // textBoxFarmName
            // 
            this.textBoxFarmName.Location = new System.Drawing.Point(48, 264);
            this.textBoxFarmName.Name = "textBoxFarmName";
            this.textBoxFarmName.Size = new System.Drawing.Size(100, 22);
            this.textBoxFarmName.TabIndex = 5;
            // 
            // textBoxRoseSizeID
            // 
            this.textBoxRoseSizeID.Location = new System.Drawing.Point(191, 264);
            this.textBoxRoseSizeID.Name = "textBoxRoseSizeID";
            this.textBoxRoseSizeID.Size = new System.Drawing.Size(100, 22);
            this.textBoxRoseSizeID.TabIndex = 6;
            // 
            // textBoxPricePerStem
            // 
            this.textBoxPricePerStem.Location = new System.Drawing.Point(327, 264);
            this.textBoxPricePerStem.Name = "textBoxPricePerStem";
            this.textBoxPricePerStem.Size = new System.Drawing.Size(100, 22);
            this.textBoxPricePerStem.TabIndex = 7;
            // 
            // textBoxInvoiceID
            // 
            this.textBoxInvoiceID.Location = new System.Drawing.Point(464, 264);
            this.textBoxInvoiceID.Name = "textBoxInvoiceID";
            this.textBoxInvoiceID.Size = new System.Drawing.Size(100, 22);
            this.textBoxInvoiceID.TabIndex = 8;
            // 
            // AddPurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 404);
            this.Controls.Add(this.textBoxInvoiceID);
            this.Controls.Add(this.textBoxPricePerStem);
            this.Controls.Add(this.textBoxRoseSizeID);
            this.Controls.Add(this.textBoxFarmName);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.listBoxWarehouse);
            this.Controls.Add(this.listBoxBox);
            this.Controls.Add(this.listBoxSuppliersInventory);
            this.Controls.Add(this.buttonAddPurchase);
            this.Name = "AddPurchaseForm";
            this.Text = "Add Purchase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddPurchase;
        private System.Windows.Forms.ListBox listBoxSuppliersInventory;
        private System.Windows.Forms.ListBox listBoxBox;
        private System.Windows.Forms.ListBox listBoxWarehouse;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxFarmName;
        private System.Windows.Forms.TextBox textBoxRoseSizeID;
        private System.Windows.Forms.TextBox textBoxPricePerStem;
        private System.Windows.Forms.TextBox textBoxInvoiceID;
    }
}