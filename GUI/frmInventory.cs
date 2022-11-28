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
using MySql.Data.MySqlClient;
using System.IO;
using Google.Protobuf.WellKnownTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MegaVox.GUI
{
    public partial class frmInventory : Form
    {
        InventoryDB inventory = new InventoryDB();
        UserDB user = new UserDB();

        public frmInventory()
        {
            InitializeComponent();
        }
        String username, password, userType;

        public frmInventory(string un, string pw, string ut)
        {
            InitializeComponent();
            username = un;
            password = pw;
            userType = ut;
        }

        bool verify()
        {
            if ((txtId.Text == "") || (txtName.Text == "") ||
                (txtPrice.Text == "") || (txtDesc.Text == ""))
            {
                return false;
            }
            else
                return true;
        }

        public void showTable()
        {
            grdInventory.DataSource = inventory.getInventory(new MySqlCommand("SELECT * FROM `inventory`"));
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            showTable();
            string userType = "1";
            DataTable table = user.getUser(new MySqlCommand("SELECT `type` FROM `user` WHERE `username`= '" + username + "' AND `password`='" + password + "'"));
            DataRow[] findType = table.Select("type = '" + userType + "'");

            if (findType.Length != 0)
            {
                btnAdd.Enabled = false;
                btnAdd.Visible = false;
                btnUpdate.Enabled = false;
                btnUpdate.Visible = false;
                btnDelete.Enabled = false;
                btnDelete.Visible = false;
                btnClear.Enabled = false;
                btnClear.Visible = false;

            }
            else
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnClear.Enabled = true;

            }

        }

        private void buttonSearchCourse_Click(object sender, EventArgs e)
        {
            dataGridViewInventory.DataSource = inventory.searchInventory(txtSearch.Text);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
        }

        private void grdInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = grdInventory.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = grdInventory.CurrentRow.Cells[1].Value.ToString();
            txtDesc.Text = grdInventory.CurrentRow.Cells[2].Value.ToString();

            txtPrice.Text = grdInventory.CurrentRow.Cells[3].Value.ToString();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtDesc.Clear();
            txtPrice.Clear();
            txtPrice.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            if (MessageBox.Show("Are you sure you want to delete this item", "Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (inventory.deleteInventory(id))
                {
                    showTable();
                    MessageBox.Show("Item has been Successfully deleted", "Warning Deletion : Item Removed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear.PerformClick();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string name = txtName.Text;
            string desc = txtDesc.Text;
            string price = txtPrice.Text;

            if (verify())
            {
                try
                {
                    if (inventory.updateInventory(id, name, price, desc))
                    {
                        showTable();
                        MessageBox.Show("Successfully updated item", "Update item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClear.PerformClick();
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Update item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string name = txtName.Text;
            string desc = txtDesc.Text;
            string price = txtPrice.Text;

            if (verify())
            {
                try
                {
                    if (inventory.insertInventory(name, price, desc))
                    {
                        showTable();
                        MessageBox.Show("Item has been added successfully!", "Item Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Section, Please make sure everything is added.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}