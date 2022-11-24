using MegaVox.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MegaVox.BLL
{
    class InventoryDB
    {
        UtilityDB connect = new UtilityDB();

        public bool insertInventory(string InvName, int price, string desc)
        {
            MySqlCommand cmdInsert = new MySqlCommand("INSERT INTO `inventory`(`InvName`, `Price`, `Description`) VALUES (@in,@pc,@desc)", connect.getconnection);
            cmdInsert.Parameters.Add("@in", MySqlDbType.VarChar).Value = InvName;
            cmdInsert.Parameters.Add("@pc", MySqlDbType.Int32).Value = price;
            cmdInsert.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;
            connect.openConnect();
            if (cmdInsert.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        public DataTable getInventory(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool updateInventory(int id, string InvName, int price, string desc)
        {
            MySqlCommand cmdUpdate = new MySqlCommand("UPDATE `inventory` SET`InvName`=@in,`Price`=@pc,`Description`=@desc WHERE  `InvId`=@id", connect.getconnection);

            cmdUpdate.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            cmdUpdate.Parameters.Add("@in", MySqlDbType.VarChar).Value = InvName;
            cmdUpdate.Parameters.Add("@pc", MySqlDbType.Int32).Value = price;
            cmdUpdate.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;
            connect.openConnect();
            if (cmdUpdate.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        public bool deleteInventory(int id)
        {
            MySqlCommand cmdDelete = new MySqlCommand("DELETE FROM `inventory` WHERE `InvId`=@id", connect.getconnection);
            cmdDelete.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            connect.openConnect();
            if (cmdDelete.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

    }
}
