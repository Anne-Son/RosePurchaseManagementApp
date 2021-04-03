
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
            this.SuspendLayout();
            // 
            // buttonAddPurchase
            // 
            this.buttonAddPurchase.Location = new System.Drawing.Point(435, 319);
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
            this.listBoxSuppliersInventory.Location = new System.Drawing.Point(48, 41);
            this.listBoxSuppliersInventory.Name = "listBoxSuppliersInventory";
            this.listBoxSuppliersInventory.Size = new System.Drawing.Size(331, 196);
            this.listBoxSuppliersInventory.TabIndex = 1;
            // 
            // listBoxBox
            // 
            this.listBoxBox.FormattingEnabled = true;
            this.listBoxBox.ItemHeight = 16;
            this.listBoxBox.Location = new System.Drawing.Point(435, 41);
            this.listBoxBox.Name = "listBoxBox";
            this.listBoxBox.Size = new System.Drawing.Size(155, 116);
            this.listBoxBox.TabIndex = 2;
            // 
            // listBoxWarehouse
            // 
            this.listBoxWarehouse.FormattingEnabled = true;
            this.listBoxWarehouse.ItemHeight = 16;
            this.listBoxWarehouse.Location = new System.Drawing.Point(668, 41);
            this.listBoxWarehouse.Name = "listBoxWarehouse";
            this.listBoxWarehouse.Size = new System.Drawing.Size(267, 196);
            this.listBoxWarehouse.TabIndex = 3;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantity.Location = new System.Drawing.Point(435, 206);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(155, 27);
            this.textBoxQuantity.TabIndex = 4;
            // 
            // AddPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 404);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.listBoxWarehouse);
            this.Controls.Add(this.listBoxBox);
            this.Controls.Add(this.listBoxSuppliersInventory);
            this.Controls.Add(this.buttonAddPurchase);
            this.Name = "AddPurchase";
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
    }
}