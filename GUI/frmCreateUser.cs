using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

using MegaVox.DAL;
using MegaVox.BLL;
using System.Xml.Linq;
using System.Linq.Expressions;
using System.Data.SqlTypes;


namespace MegaVox.GUI
{
    public partial class frmCreateUser : Form
    {

        UserDB user = new UserDB();
        public frmCreateUser()
        {
            InitializeComponent();
        }
        bool verify()
        {
            if ((txtUserName.Text == "") || (txtPassword.Text == "") || (cboType.Text == ""))
            {
                return false;
            }
            else
                return true;
        }
        public void showTable()
        {
            GrdUser.DataSource = user.getUserList(new MySqlCommand("SELECT * FROM `user`"));

        }
        private void btn_update_Click(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCreateUser_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void btn_saveuser_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            string type = cboType.SelectedIndex.ToString();


            if (password.Length < 7 || password.Length > 25)
            {
                MessageBox.Show("Password must be between 7 and 25", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {

                    if (user.insertUser(userName, password, type))
                    {
                        showTable();
                        MessageBox.Show("Client added successfully!", "Client Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Section, Please make sure everything is added.", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }


        private void btn_New_Click(object sender, EventArgs e)
        {
            txtUserId.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            cboType.SelectedIndex = 0;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(txtUserId.Text);
            if (MessageBox.Show("Are you sure you want to delete this user?", "Remove User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (user.deleteUser(userid))
                {
                    showTable();
                    MessageBox.Show("User Successfully deleted", "Warning Deletion : User Removed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClose.PerformClick();
                }
            }
        }

        private void GrdUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserId.Text = GrdUser.CurrentRow.Cells[0].Value.ToString();
            txtUserName.Text = GrdUser.CurrentRow.Cells[1].Value.ToString();
            txtPassword.Text = GrdUser.CurrentRow.Cells[2].Value.ToString();
            cboType.SelectedItem = GrdUser.CurrentRow.Cells[3].Value.ToString();
        }
    }
}