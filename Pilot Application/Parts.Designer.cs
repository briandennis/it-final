namespace Pilot_Application
{
    partial class Parts
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Parts");
            this.listViewParts = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.testing = new System.Windows.Forms.Label();
            this.listViewPictureBox = new System.Windows.Forms.PictureBox();
            this.listViewGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.treeViewPictureBox = new System.Windows.Forms.PictureBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.dataGridTab = new System.Windows.Forms.TabPage();
            this.gridGrid = new System.Windows.Forms.DataGridView();
            this.gridId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLabor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listViewParts.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listViewPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listViewGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewPictureBox)).BeginInit();
            this.dataGridTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewParts
            // 
            this.listViewParts.Controls.Add(this.tabPage1);
            this.listViewParts.Controls.Add(this.tabPage2);
            this.listViewParts.Controls.Add(this.dataGridTab);
            this.listViewParts.Location = new System.Drawing.Point(12, 12);
            this.listViewParts.Name = "listViewParts";
            this.listViewParts.SelectedIndex = 0;
            this.listViewParts.Size = new System.Drawing.Size(1090, 697);
            this.listViewParts.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.testing);
            this.tabPage1.Controls.Add(this.listViewPictureBox);
            this.tabPage1.Controls.Add(this.listViewGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1082, 671);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "List View Parts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // testing
            // 
            this.testing.AutoSize = true;
            this.testing.Location = new System.Drawing.Point(469, 29);
            this.testing.Name = "testing";
            this.testing.Size = new System.Drawing.Size(35, 13);
            this.testing.TabIndex = 2;
            this.testing.Text = "label1";
            // 
            // listViewPictureBox
            // 
            this.listViewPictureBox.Location = new System.Drawing.Point(417, 90);
            this.listViewPictureBox.Name = "listViewPictureBox";
            this.listViewPictureBox.Size = new System.Drawing.Size(352, 279);
            this.listViewPictureBox.TabIndex = 1;
            this.listViewPictureBox.TabStop = false;
            // 
            // listViewGrid
            // 
            this.listViewGrid.AllowUserToResizeColumns = false;
            this.listViewGrid.AllowUserToResizeRows = false;
            this.listViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listViewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.listViewGrid.Location = new System.Drawing.Point(6, 6);
            this.listViewGrid.Name = "listViewGrid";
            this.listViewGrid.Size = new System.Drawing.Size(293, 448);
            this.listViewGrid.TabIndex = 0;
            this.listViewGrid.CurrentCellChanged += new System.EventHandler(this.listViewGrid_CurrentCellChanged);
            // 
            // id
            // 
            this.id.HeaderText = "Part ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Part Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.treeViewPictureBox);
            this.tabPage2.Controls.Add(this.treeView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1082, 671);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tree View Parts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // treeViewPictureBox
            // 
            this.treeViewPictureBox.Location = new System.Drawing.Point(414, 73);
            this.treeViewPictureBox.Name = "treeViewPictureBox";
            this.treeViewPictureBox.Size = new System.Drawing.Size(335, 312);
            this.treeViewPictureBox.TabIndex = 1;
            this.treeViewPictureBox.TabStop = false;
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(6, 6);
            this.treeView.Name = "treeView";
            treeNode2.Name = "parts";
            treeNode2.Text = "Parts";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView.Size = new System.Drawing.Size(307, 448);
            this.treeView.TabIndex = 0;
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // dataGridTab
            // 
            this.dataGridTab.Controls.Add(this.gridGrid);
            this.dataGridTab.Location = new System.Drawing.Point(4, 22);
            this.dataGridTab.Name = "dataGridTab";
            this.dataGridTab.Padding = new System.Windows.Forms.Padding(3);
            this.dataGridTab.Size = new System.Drawing.Size(1082, 671);
            this.dataGridTab.TabIndex = 2;
            this.dataGridTab.Text = "DataGrid Parts";
            this.dataGridTab.UseVisualStyleBackColor = true;
            // 
            // gridGrid
            // 
            this.gridGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridId,
            this.dataName,
            this.dataCatName,
            this.dataLabor,
            this.dataPrice,
            this.dataDesc});
            this.gridGrid.Location = new System.Drawing.Point(15, 19);
            this.gridGrid.Name = "gridGrid";
            this.gridGrid.Size = new System.Drawing.Size(788, 435);
            this.gridGrid.TabIndex = 0;
            // 
            // gridId
            // 
            this.gridId.HeaderText = "ID";
            this.gridId.Name = "gridId";
            this.gridId.ReadOnly = true;
            this.gridId.Width = 25;
            // 
            // dataName
            // 
            this.dataName.HeaderText = "Name";
            this.dataName.Name = "dataName";
            this.dataName.ReadOnly = true;
            this.dataName.Width = 150;
            // 
            // dataCatName
            // 
            this.dataCatName.HeaderText = "Category";
            this.dataCatName.Name = "dataCatName";
            this.dataCatName.ReadOnly = true;
            // 
            // dataLabor
            // 
            this.dataLabor.HeaderText = "Labor";
            this.dataLabor.Name = "dataLabor";
            this.dataLabor.ReadOnly = true;
            this.dataLabor.Width = 75;
            // 
            // dataPrice
            // 
            this.dataPrice.HeaderText = "Price";
            this.dataPrice.Name = "dataPrice";
            this.dataPrice.ReadOnly = true;
            this.dataPrice.Width = 75;
            // 
            // dataDesc
            // 
            this.dataDesc.HeaderText = "Description";
            this.dataDesc.Name = "dataDesc";
            this.dataDesc.ReadOnly = true;
            this.dataDesc.Width = 325;
            // 
            // Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 500);
            this.Controls.Add(this.listViewParts);
            this.Name = "Parts";
            this.Text = "Form1";
            this.listViewParts.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listViewPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listViewGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeViewPictureBox)).EndInit();
            this.dataGridTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl listViewParts;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage dataGridTab;
        private System.Windows.Forms.DataGridView listViewGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.PictureBox listViewPictureBox;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.PictureBox treeViewPictureBox;
        private System.Windows.Forms.DataGridView gridGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCatName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLabor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDesc;
        private System.Windows.Forms.Label testing;
    }
}

