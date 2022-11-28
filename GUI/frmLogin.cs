using MegaVox.BLL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MegaVox.GUI;
using MegaVox.DAL;

namespace MegaVox.GUI
{
    public partial class frmLogin : Form
    {
        UserDB user = new UserDB();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Please enter your login credentials", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string username = textBox_username.Text;
                string password = textBox_password.Text;

                DataTable table = user.getUserList(new MySqlCommand("SELECT * FROM `user` WHERE `username`= '" + username + "' AND `password`='" + password + "'"));
                if (table.Rows.Count > 0)
                {
                    frmMain main = new frmMain(textBox_username.Text, textBox_password.Text);
                    this.Hide();
                    main.Show();


                }
                else
                {
                    MessageBox.Show("Your user and password do not match our records", "Invalid UserName & Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
