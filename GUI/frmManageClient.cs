using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


using MegaVox.DAL;
using MegaVox.BLL;
using System.Xml.Linq;

namespace MegaVox.GUI
{
    public partial class frmManageClient : Form
    {
        ClientDB client = new ClientDB();

        public frmManageClient()
        {
            InitializeComponent();
        }

        public void showTable()
        {
            DataGridView_client.DataSource = client.getClientList(new MySqlCommand("SELECT * FROM `client`"));
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_client.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void DataGridView_client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = DataGridView_client.CurrentRow.Cells[0].Value.ToString();
            txtFirstName.Text = DataGridView_client.CurrentRow.Cells[1].Value.ToString();
            txtLastName.Text = DataGridView_client.CurrentRow.Cells[2].Value.ToString();

            datePicker.Value = (DateTime)DataGridView_client.CurrentRow.Cells[3].Value;
            if (DataGridView_client.CurrentRow.Cells[4].Value.ToString() == "Male")
                radioButton_male.Checked = true;

            txtPhone.Text = DataGridView_client.CurrentRow.Cells[5].Value.ToString();
            txtAddress.Text = DataGridView_client.CurrentRow.Cells[6].Value.ToString();
            byte[] img = (byte[])DataGridView_client.CurrentRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(img);
            imgClient.Image = Image.FromStream(ms);
        }

        bool verify()
        {
            if ((txtFirstName.Text == "") || (txtLastName.Text == "") ||
                (txtPhone.Text == "") || (txtAddress.Text == "") ||
                (imgClient.Image == null))
            {
                return false;
            }
            else
                return true;
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                imgClient.Image = Image.FromFile(opf.FileName);
        }

        private void frmManageClient_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            radioButton_male.Checked = true;
            datePicker.Value = DateTime.Now;
            imgClient.Image = null;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            DateTime bdate = datePicker.Value;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string gender = radioButton_male.Checked ? "Male" : "Female";


            int born_year = datePicker.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 21 || (this_year - born_year) > 100)
            {
                MessageBox.Show("Client must be between 21 and 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    imgClient.Image.Save(ms, imgClient.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    if (client.updateClient(id, fname, lname, bdate, gender, phone, address, img))
                    {
                        showTable();
                        MessageBox.Show("Successfully updated client", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_clear.PerformClick();
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_client.DataSource = client.searchClient(txtSearch.Text);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_client.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            if (MessageBox.Show("Are you sure you want to delete this client?", "Remove Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (client.deleteClient(id))
                {
                    showTable();
                    MessageBox.Show("Client Successfully deleted", "Warning Deletion : Client Removed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button_clear.PerformClick();
                }
            }
        }
    }
}