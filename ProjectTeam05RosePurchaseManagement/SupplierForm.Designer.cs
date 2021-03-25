
namespace ProjectTeam05RosePurchaseManagement
{
    partial class SupplierForm
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
            this.tabFlowers = new System.Windows.Forms.TabPage();
            this.tabControlManager = new System.Windows.Forms.TabControl();
            this.tabControlManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFlowers
            // 
            this.tabFlowers.Location = new System.Drawing.Point(4, 25);
            this.tabFlowers.Name = "tabFlowers";
            this.tabFlowers.Padding = new System.Windows.Forms.Padding(3);
            this.tabFlowers.Size = new System.Drawing.Size(998, 492);
            this.tabFlowers.TabIndex = 1;
            this.tabFlowers.Text = "Flowers";
            this.tabFlowers.UseVisualStyleBackColor = true;
            // 
            // tabControlManager
            // 
            this.tabControlManager.Controls.Add(this.tabFlowers);
            this.tabControlManager.Location = new System.Drawing.Point(12, 12);
            this.tabControlManager.Name = "tabControlManager";
            this.tabControlManager.SelectedIndex = 0;
            this.tabControlManager.Size = new System.Drawing.Size(1006, 521);
            this.tabControlManager.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlManager.TabIndex = 2;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 534);
            this.Controls.Add(this.tabControlManager);
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            this.tabControlManager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabFlowers;
        private System.Windows.Forms.TabControl tabControlManager;
    }
}