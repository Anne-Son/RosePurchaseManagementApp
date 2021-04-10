
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
            this.buttonUpdateInventory = new System.Windows.Forms.Button();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBoxRoses = new System.Windows.Forms.ComboBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelRoseName = new System.Windows.Forms.Label();
            this.labelFarm = new System.Windows.Forms.Label();
            this.listBoxFarms = new System.Windows.Forms.ListBox();
            this.buttonDeleteInventory = new System.Windows.Forms.Button();
            this.buttonAddInventory = new System.Windows.Forms.Button();
            this.dataGridViewFlowers = new System.Windows.Forms.DataGridView();
            this.tabControlManager = new System.Windows.Forms.TabControl();
            this.tabFlowers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlowers)).BeginInit();
            this.tabControlManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFlowers
            // 
            this.tabFlowers.Controls.Add(this.buttonUpdateInventory);
            this.tabFlowers.Controls.Add(this.textBoxQuantity);
            this.tabFlowers.Controls.Add(this.textBoxPrice);
            this.tabFlowers.Controls.Add(this.comboBoxRoses);
            this.tabFlowers.Controls.Add(this.labelQuantity);
            this.tabFlowers.Controls.Add(this.labelPrice);
            this.tabFlowers.Controls.Add(this.labelRoseName);
            this.tabFlowers.Controls.Add(this.labelFarm);
            this.tabFlowers.Controls.Add(this.listBoxFarms);
            this.tabFlowers.Controls.Add(this.buttonDeleteInventory);
            this.tabFlowers.Controls.Add(this.buttonAddInventory);
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
            // buttonUpdateInventory
            // 
            this.buttonUpdateInventory.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateInventory.Location = new System.Drawing.Point(526, 567);
            this.buttonUpdateInventory.Name = "buttonUpdateInventory";
            this.buttonUpdateInventory.Size = new System.Drawing.Size(169, 35);
            this.buttonUpdateInventory.TabIndex = 11;
            this.buttonUpdateInventory.Text = "Update";
            this.buttonUpdateInventory.UseVisualStyleBackColor = true;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(399, 467);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(121, 26);
            this.textBoxQuantity.TabIndex = 10;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(399, 427);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(121, 26);
            this.textBoxPrice.TabIndex = 9;
            // 
            // comboBoxRoses
            // 
            this.comboBoxRoses.FormattingEnabled = true;
            this.comboBoxRoses.Items.AddRange(new object[] {
            "Creme de la Creme",
            "Vendela",
            "Green Tea ",
            "Full Mix Color",
            "Cayenne",
            "OrangeCabaret Crush",
            "Carrousel",
            "Freedom",
            "Cabaret",
            "Tibet",
            "Free Spirit"});
            this.comboBoxRoses.Location = new System.Drawing.Point(399, 384);
            this.comboBoxRoses.Name = "comboBoxRoses";
            this.comboBoxRoses.Size = new System.Drawing.Size(121, 28);
            this.comboBoxRoses.TabIndex = 8;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(246, 474);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(68, 20);
            this.labelQuantity.TabIndex = 7;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(246, 427);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(44, 20);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Price";
            // 
            // labelRoseName
            // 
            this.labelRoseName.AutoSize = true;
            this.labelRoseName.Location = new System.Drawing.Point(242, 384);
            this.labelRoseName.Name = "labelRoseName";
            this.labelRoseName.Size = new System.Drawing.Size(93, 20);
            this.labelRoseName.TabIndex = 5;
            this.labelRoseName.Text = "Rose Name";
            // 
            // labelFarm
            // 
            this.labelFarm.AutoSize = true;
            this.labelFarm.Location = new System.Drawing.Point(25, 358);
            this.labelFarm.Name = "labelFarm";
            this.labelFarm.Size = new System.Drawing.Size(108, 20);
            this.labelFarm.TabIndex = 4;
            this.labelFarm.Text = "Select a Farm";
            // 
            // listBoxFarms
            // 
            this.listBoxFarms.FormattingEnabled = true;
            this.listBoxFarms.ItemHeight = 20;
            this.listBoxFarms.Location = new System.Drawing.Point(25, 384);
            this.listBoxFarms.Name = "listBoxFarms";
            this.listBoxFarms.Size = new System.Drawing.Size(172, 164);
            this.listBoxFarms.TabIndex = 3;
            // 
            // buttonDeleteInventory
            // 
            this.buttonDeleteInventory.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteInventory.Location = new System.Drawing.Point(838, 567);
            this.buttonDeleteInventory.Name = "buttonDeleteInventory";
            this.buttonDeleteInventory.Size = new System.Drawing.Size(160, 35);
            this.buttonDeleteInventory.TabIndex = 2;
            this.buttonDeleteInventory.Text = "Delete";
            this.buttonDeleteInventory.UseVisualStyleBackColor = true;
            // 
            // buttonAddInventory
            // 
            this.buttonAddInventory.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddInventory.Location = new System.Drawing.Point(209, 567);
            this.buttonAddInventory.Name = "buttonAddInventory";
            this.buttonAddInventory.Size = new System.Drawing.Size(199, 35);
            this.buttonAddInventory.TabIndex = 1;
            this.buttonAddInventory.Text = "Add";
            this.buttonAddInventory.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFlowers
            // 
            this.dataGridViewFlowers.AllowUserToDeleteRows = false;
            this.dataGridViewFlowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlowers.Location = new System.Drawing.Point(25, 17);
            this.dataGridViewFlowers.Name = "dataGridViewFlowers";
            this.dataGridViewFlowers.RowHeadersWidth = 62;
            this.dataGridViewFlowers.RowTemplate.Height = 28;
            this.dataGridViewFlowers.Size = new System.Drawing.Size(1077, 305);
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
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 736);
            this.Controls.Add(this.tabControlManager);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            this.tabFlowers.ResumeLayout(false);
            this.tabFlowers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlowers)).EndInit();
            this.tabControlManager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabFlowers;
        private System.Windows.Forms.TabControl tabControlManager;
        private System.Windows.Forms.DataGridView dataGridViewFlowers;
        private System.Windows.Forms.Button buttonDeleteInventory;
        private System.Windows.Forms.Button buttonAddInventory;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxRoses;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelRoseName;
        private System.Windows.Forms.Label labelFarm;
        private System.Windows.Forms.ListBox listBoxFarms;
        private System.Windows.Forms.Button buttonUpdateInventory;
    }
}