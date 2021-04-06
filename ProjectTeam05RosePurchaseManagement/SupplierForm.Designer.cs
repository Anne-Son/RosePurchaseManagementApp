
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
            this.dataGridViewFlowers = new System.Windows.Forms.DataGridView();
            this.tabControlManager = new System.Windows.Forms.TabControl();
            this.buttonAddOrUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.tabFlowers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlowers)).BeginInit();
            this.tabControlManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFlowers
            // 
            this.tabFlowers.Controls.Add(this.buttonDelete);
            this.tabFlowers.Controls.Add(this.buttonAddOrUpdate);
            this.tabFlowers.Controls.Add(this.dataGridViewFlowers);
            this.tabFlowers.Location = new System.Drawing.Point(4, 29);
            this.tabFlowers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabFlowers.Name = "tabFlowers";
            this.tabFlowers.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabFlowers.Size = new System.Drawing.Size(1124, 618);
            this.tabFlowers.TabIndex = 1;
            this.tabFlowers.Text = "Flowers";
            this.tabFlowers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFlowers
            // 
            this.dataGridViewFlowers.AllowUserToDeleteRows = false;
            this.dataGridViewFlowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlowers.Location = new System.Drawing.Point(25, 17);
            this.dataGridViewFlowers.Name = "dataGridViewFlowers";
            this.dataGridViewFlowers.RowHeadersWidth = 62;
            this.dataGridViewFlowers.RowTemplate.Height = 28;
            this.dataGridViewFlowers.Size = new System.Drawing.Size(918, 290);
            this.dataGridViewFlowers.TabIndex = 0;
            // 
            // tabControlManager
            // 
            this.tabControlManager.Controls.Add(this.tabFlowers);
            this.tabControlManager.Location = new System.Drawing.Point(14, 15);
            this.tabControlManager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlManager.Name = "tabControlManager";
            this.tabControlManager.SelectedIndex = 0;
            this.tabControlManager.Size = new System.Drawing.Size(1132, 651);
            this.tabControlManager.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlManager.TabIndex = 2;
            // 
            // buttonAddOrUpdate
            // 
            this.buttonAddOrUpdate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddOrUpdate.Location = new System.Drawing.Point(195, 363);
            this.buttonAddOrUpdate.Name = "buttonAddOrUpdate";
            this.buttonAddOrUpdate.Size = new System.Drawing.Size(199, 35);
            this.buttonAddOrUpdate.TabIndex = 1;
            this.buttonAddOrUpdate.Text = "Add / Update";
            this.buttonAddOrUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(594, 363);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(146, 35);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 520);
            this.Controls.Add(this.tabControlManager);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            this.tabFlowers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlowers)).EndInit();
            this.tabControlManager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabFlowers;
        private System.Windows.Forms.TabControl tabControlManager;
        private System.Windows.Forms.DataGridView dataGridViewFlowers;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddOrUpdate;
    }
}