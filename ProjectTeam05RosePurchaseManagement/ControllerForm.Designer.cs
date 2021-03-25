
namespace ProjectTeam05RosePurchaseManagement
{
    partial class ControllerForm
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
            this.tabViewInventory = new System.Windows.Forms.TabPage();
            this.tabControlManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlManager
            // 
            this.tabControlManager.Controls.Add(this.tabPagePurchase);
            this.tabControlManager.Controls.Add(this.tabViewInventory);
            this.tabControlManager.Location = new System.Drawing.Point(12, 12);
            this.tabControlManager.Name = "tabControlManager";
            this.tabControlManager.SelectedIndex = 0;
            this.tabControlManager.Size = new System.Drawing.Size(1006, 521);
            this.tabControlManager.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlManager.TabIndex = 1;
            // 
            // tabPagePurchase
            // 
            this.tabPagePurchase.Location = new System.Drawing.Point(4, 25);
            this.tabPagePurchase.Name = "tabPagePurchase";
            this.tabPagePurchase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePurchase.Size = new System.Drawing.Size(998, 492);
            this.tabPagePurchase.TabIndex = 0;
            this.tabPagePurchase.Text = "Purchase";
            this.tabPagePurchase.UseVisualStyleBackColor = true;
            // 
            // tabViewInventory
            // 
            this.tabViewInventory.Location = new System.Drawing.Point(4, 25);
            this.tabViewInventory.Name = "tabViewInventory";
            this.tabViewInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewInventory.Size = new System.Drawing.Size(998, 492);
            this.tabViewInventory.TabIndex = 1;
            this.tabViewInventory.Text = "Inventory";
            this.tabViewInventory.UseVisualStyleBackColor = true;
            // 
            // ControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 545);
            this.Controls.Add(this.tabControlManager);
            this.Name = "ControllerForm";
            this.Text = "ControllerForm";
            this.tabControlManager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlManager;
        private System.Windows.Forms.TabPage tabPagePurchase;
        private System.Windows.Forms.TabPage tabViewInventory;
    }
}