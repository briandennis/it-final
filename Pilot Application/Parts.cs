using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;

namespace Pilot_Application
{
    public struct Part
    {
        public int id;
        public string name;
        public string catName;
        public float labor;
        public string price;
        public string desc;
    }
    public partial class Parts : Form
    {
        public SqlConnection conn;
        public List<Part> parts;

        public Parts()
        {
            InitializeComponent();
        }

        public void setParts (List<Part> parts)
        {
            this.parts = parts;

            // fill out grids
            Dictionary<string, TreeNode> treeDict = new Dictionary<string, TreeNode>();
            foreach (var part in parts)
            {
                // list view
                listViewGrid.Rows.Add(part.id, part.name);

                // tree view
                var currNode = new TreeNode(part.name);
                currNode.Tag = part.id;

                try
                {
                    treeDict[part.catName].Nodes.Add(currNode);
                }
                catch (KeyNotFoundException e)
                {
                    var newNode = new TreeNode(part.catName);
                    newNode.Tag = part.id;
                    treeDict.Add(part.catName, newNode);
                    treeView.Nodes[0].Nodes.Add(newNode);
                    treeDict[part.catName].Nodes.Add(currNode);
                }

                // grid view
                gridGrid.Rows.Add(part.id, part.name, part.catName, part.labor, part.price, part.desc);

            }

            // update images
            updateImage(listViewPictureBox, 1);
            updateImage(treeViewPictureBox, 1);
        }

        private void listViewGrid_CellContentClicked(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void updateImage (PictureBox box, int index)
        {
            Debug.WriteLine("Called with ID:: " + index);
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            string imagePath = appPath + @"\..\..\images\" + (index + 1) + ".JPG";
            if (index + 1 <= 17)
            {
                box.Image = Image.FromFile(imagePath);
            }
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag == null)
            {
                return;
            }

            int id = (int) e.Node.Tag;
            updateImage(treeViewPictureBox, id);
        }

        private void listViewGrid_CurrentCellChanged(object sender, EventArgs e)
        {

            // update picture
            int rowIndex = 1;
            if (listViewGrid.CurrentCell != null)
            {
                rowIndex = listViewGrid.CurrentCell.RowIndex;
                testing.Text = rowIndex.ToString();
            }

            updateImage(listViewPictureBox, parts[rowIndex].id);
        }
    }
}
