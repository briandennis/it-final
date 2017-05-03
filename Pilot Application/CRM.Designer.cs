namespace Pilot_Application
{
    partial class CRM
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.orderStatusTab = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusGrid = new System.Windows.Forms.DataGridView();
            this.statusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusModelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusRepairDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costGrid = new System.Windows.Forms.DataGridView();
            this.costID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.orderStatusTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.orderStatusTab);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(828, 475);
            this.tabControl1.TabIndex = 0;
            // 
            // orderStatusTab
            // 
            this.orderStatusTab.Controls.Add(this.statusGrid);
            this.orderStatusTab.Location = new System.Drawing.Point(4, 22);
            this.orderStatusTab.Name = "orderStatusTab";
            this.orderStatusTab.Padding = new System.Windows.Forms.Padding(3);
            this.orderStatusTab.Size = new System.Drawing.Size(820, 449);
            this.orderStatusTab.TabIndex = 0;
            this.orderStatusTab.Text = "Order Status";
            this.orderStatusTab.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.costGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(887, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order Cost";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // statusGrid
            // 
            this.statusGrid.AllowUserToAddRows = false;
            this.statusGrid.AllowUserToDeleteRows = false;
            this.statusGrid.AllowUserToResizeColumns = false;
            this.statusGrid.AllowUserToResizeRows = false;
            this.statusGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statusGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statusId,
            this.statusLastName,
            this.statusFirstname,
            this.statusStatusName,
            this.statusModelName,
            this.statusNotes,
            this.statusRepairDate});
            this.statusGrid.Location = new System.Drawing.Point(6, 6);
            this.statusGrid.Name = "statusGrid";
            this.statusGrid.Size = new System.Drawing.Size(769, 427);
            this.statusGrid.TabIndex = 0;
            // 
            // statusId
            // 
            this.statusId.HeaderText = "ID";
            this.statusId.Name = "statusId";
            this.statusId.ReadOnly = true;
            this.statusId.Width = 50;
            // 
            // statusLastName
            // 
            this.statusLastName.HeaderText = "Last Name";
            this.statusLastName.Name = "statusLastName";
            this.statusLastName.ReadOnly = true;
            // 
            // statusFirstname
            // 
            this.statusFirstname.HeaderText = "First Name";
            this.statusFirstname.Name = "statusFirstname";
            this.statusFirstname.ReadOnly = true;
            this.statusFirstname.Width = 75;
            // 
            // statusStatusName
            // 
            this.statusStatusName.HeaderText = "Status";
            this.statusStatusName.Name = "statusStatusName";
            this.statusStatusName.ReadOnly = true;
            this.statusStatusName.Width = 75;
            // 
            // statusModelName
            // 
            this.statusModelName.HeaderText = "Model";
            this.statusModelName.Name = "statusModelName";
            this.statusModelName.ReadOnly = true;
            // 
            // statusNotes
            // 
            this.statusNotes.HeaderText = "Notes";
            this.statusNotes.Name = "statusNotes";
            this.statusNotes.ReadOnly = true;
            this.statusNotes.Width = 250;
            // 
            // statusRepairDate
            // 
            this.statusRepairDate.HeaderText = "Repair Date";
            this.statusRepairDate.Name = "statusRepairDate";
            this.statusRepairDate.ReadOnly = true;
            this.statusRepairDate.Width = 75;
            // 
            // costGrid
            // 
            this.costGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.costGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.costID,
            this.costName,
            this.costPrice,
            this.costQty});
            this.costGrid.Location = new System.Drawing.Point(6, 16);
            this.costGrid.Name = "costGrid";
            this.costGrid.Size = new System.Drawing.Size(544, 417);
            this.costGrid.TabIndex = 0;
            // 
            // costID
            // 
            this.costID.HeaderText = "ID";
            this.costID.Name = "costID";
            this.costID.ReadOnly = true;
            // 
            // costName
            // 
            this.costName.HeaderText = "Part Name";
            this.costName.Name = "costName";
            this.costName.ReadOnly = true;
            this.costName.Width = 200;
            // 
            // costPrice
            // 
            this.costPrice.HeaderText = "Price";
            this.costPrice.Name = "costPrice";
            this.costPrice.ReadOnly = true;
            // 
            // costQty
            // 
            this.costQty.HeaderText = "Quantity";
            this.costQty.Name = "costQty";
            this.costQty.ReadOnly = true;
            // 
            // CRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 499);
            this.Controls.Add(this.tabControl1);
            this.Name = "CRM";
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.orderStatusTab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage orderStatusTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView statusGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusModelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusRepairDate;
        private System.Windows.Forms.DataGridView costGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn costID;
        private System.Windows.Forms.DataGridViewTextBoxColumn costName;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn costQty;
    }
}