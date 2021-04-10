
namespace ProjectTeam05RosePurchaseManagement
{
    partial class RosePurchaseManagementAppMainForm
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
            this.buttonManagerForm = new System.Windows.Forms.Button();
            this.buttonSupplierForm = new System.Windows.Forms.Button();
            this.buttonControllerForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonManagerForm
            // 
            this.buttonManagerForm.Location = new System.Drawing.Point(97, 117);
            this.buttonManagerForm.Name = "buttonManagerForm";
            this.buttonManagerForm.Size = new System.Drawing.Size(143, 80);
            this.buttonManagerForm.TabIndex = 0;
            this.buttonManagerForm.Text = "Manager";
            this.buttonManagerForm.UseVisualStyleBackColor = true;
            // 
            // buttonSupplierForm
            // 
            this.buttonSupplierForm.Location = new System.Drawing.Point(253, 255);
            this.buttonSupplierForm.Name = "buttonSupplierForm";
            this.buttonSupplierForm.Size = new System.Drawing.Size(143, 80);
            this.buttonSupplierForm.TabIndex = 1;
            this.buttonSupplierForm.Text = "Supplier";
            this.buttonSupplierForm.UseVisualStyleBackColor = true;
            // 
            // buttonControllerForm
            // 
            this.buttonControllerForm.Location = new System.Drawing.Point(405, 117);
            this.buttonControllerForm.Name = "buttonControllerForm";
            this.buttonControllerForm.Size = new System.Drawing.Size(143, 80);
            this.buttonControllerForm.TabIndex = 2;
            this.buttonControllerForm.Text = "Purchasing Agent";
            this.buttonControllerForm.UseVisualStyleBackColor = true;
            // 
            // RosePurchaseManagementAppMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 400);
            this.Controls.Add(this.buttonControllerForm);
            this.Controls.Add(this.buttonSupplierForm);
            this.Controls.Add(this.buttonManagerForm);
            this.Name = "RosePurchaseManagementAppMainForm";
            this.Text = "Rose Purchase Management";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonManagerForm;
        private System.Windows.Forms.Button buttonSupplierForm;
        private System.Windows.Forms.Button buttonControllerForm;
    }
}

