using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilot_Application
{
    public partial class Menu : Form
    {

        public CRM crm;
        public Parts parts;

        public bool crmShown = false;
        public bool partsShown = false;

        public Menu()
        {
            InitializeComponent();

            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            string imagePath = appPath + @"\..\..\images\1.JPG";
            menuPicBox.Image = Image.FromFile(imagePath);
        }

        private void partsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parts.Show();
        }

        private void cRMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crm.Show();
        }

        private void partsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            parts.Hide();
        }

        private void cRMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            crm.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
