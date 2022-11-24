using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MegaVox.DAL;
using MegaVox.BLL;

namespace MegaVox.GUI
{
    public partial class frmMain : Form
    {
        ClientDB client = new ClientDB();
        InventoryDB inventory = new InventoryDB();
        public frmMain()
        {
            InitializeComponent();
            customizedDesign();
        }

        private void hideSubmenu()
        {
            if (panel_stdsubmenu.Visible == true)
                panel_stdsubmenu.Visible = false;
            if (panel_courseSubmenu.Visible == true)
                panel_courseSubmenu.Visible = false;
            if (panel_scoreSubmenu.Visible == true)
                panel_scoreSubmenu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void customizedDesign()
        {
            panel_stdsubmenu.Visible = false;
            panel_courseSubmenu.Visible = false;
            panel_scoreSubmenu.Visible = false;
        }

        private void button_registration_Click(object sender, EventArgs e)
        {
            openChildForm(new frmRegistration());
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void comboBox_course_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_main.Controls.Add(panel_cover);
        }

        private void button_std_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_stdsubmenu);
        }

        private void button_course_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_courseSubmenu);
        }

        private void button_score_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_scoreSubmenu);
        }

        private void button_manageClient_Click(object sender, EventArgs e)
        {
            openChildForm(new frmManageClient());
        }

        private void button_newInventory_Click(object sender, EventArgs e)
        {
            openChildForm(new frmInventory());
        }

        private void button_newScore_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCreateUser());
        }
    }
}
