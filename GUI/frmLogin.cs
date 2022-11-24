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
        ClientDB student = new ClientDB();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            panel_log.BackColor = Color.FromArgb(120, 0, 0, 0);

            button_login.FlatStyle = FlatStyle.Flat;

            lblLogin.BackColor = Color.Transparent;
            label_userName.BackColor = Color.Transparent;
            label_Password.BackColor = Color.Transparent;

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_usrname.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Please enter your login credentials", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string username = textBox_usrname.Text;
                string password = textBox_password.Text;
                DataTable table = student.getList(new MySqlCommand("SELECT * FROM `user` WHERE `username`= '" + username + "' AND `password`='" + password + "'"));
                if (table.Rows.Count > 0)
                {
                    frmMain main = new frmMain();
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
