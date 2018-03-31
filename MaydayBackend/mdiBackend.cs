using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Author Mohammad Desai//

namespace MaydayBackend
{
    public partial class mdiBackend : Form
    {
        private int childFormNumber = 0;

        public mdiBackend()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        


        private void mdiBackend_Load(object sender, EventArgs e)
        {

        }


        private void newBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creat an object based on frmMaydayMain
            FrmAEBookings BookingsList = new FrmAEBookings(-1);
            //make the object of a child the midi parent
            BookingsList.MdiParent = this;
            //make the form visible
            BookingsList.Visible = true;
        }

        private void displayBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create an object based on frmMaydayMain
            frmBookingMain BookingsList = new frmBookingMain();
            //make the object of a child the midi parent
            BookingsList.MdiParent = this;
            //make the form visible
            BookingsList.Visible = true;
        }

        private void displayCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerMain CustList = new frmCustomerMain();
            CustList.MdiParent = this;
            CustList.Visible = true;
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditCust CList = new frmAddEditCust(-1);
            CList.MdiParent = this;
            CList.Visible = true;
        }
    }
}
