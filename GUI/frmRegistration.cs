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
using System.Security;
using System.Xml.Linq;
using System.Linq.Expressions;
using System.Data.SqlTypes;

namespace MegaVox.GUI
{
    public partial class frmRegistration : Form
    {
        ClientDB client = new ClientDB();

        public frmRegistration()
        {
            InitializeComponent();
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


        private void RegisterForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        public void showTable()
        {
            GrdClient.DataSource = client.getClientList(new MySqlCommand("SELECT * FROM `client`"));
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)GrdClient.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                imgClient.Image = Image.FromFile(opf.FileName);

        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            radioButton_male.Checked = true;
            datePicker.Value = DateTime.Now;
            imgClient.Image = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime bdate = datePicker.Value;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string gender = radioButton_male.Checked ? "Male" : "Female";

            int year_born = datePicker.Value.Year;
            int current_year = DateTime.Now.Year;
            if ((current_year - year_born) < 21 || (current_year - year_born) > 100)
            {
                MessageBox.Show("Client must be between 21 and 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    // to get photo from picture box
                    MemoryStream ms = new MemoryStream();
                    imgClient.Image.Save(ms, imgClient.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    if (client.insertClient(firstName, lastName, bdate, gender, phone, address, img))
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
    }
}
