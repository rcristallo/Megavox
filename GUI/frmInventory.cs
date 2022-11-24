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

namespace MegaVox.GUI
{
    public partial class frmInventory : Form
    {
        InventoryDB inventory = new InventoryDB();

        public frmInventory()
        {
            InitializeComponent();
        }

        public void showTable()
        {
            grdInventory.DataSource = inventory.getInventory(new MySqlCommand("SELECT * FROM `inventory`"));
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            showTable();
        }

    }
}