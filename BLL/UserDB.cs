using MegaVox.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaVox.BLL
{
    class UserDB
    {
        {
            UtilityDB connect = new UtilityDB();

            public bool insertUser(string InvName, int price, string desc)
            {
                MySqlCommand cmdInsert = new MySqlCommand("INSERT INTO `user`(`userId`, `username`, `password`) VALUES (@ui,@un,@pw)", connect.getconnection);
                cmdInsert.Parameters.Add("@ui", MySqlDbType.VarChar).Value = InvName;
                cmdInsert.Parameters.Add("@un", MySqlDbType.Int32).Value = price;
                cmdInsert.Parameters.Add("@pw", MySqlDbType.VarChar).Value = desc;
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

            public DataTable getUser(MySqlCommand command)
            {
                command.Connection = connect.getconnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }

            public bool updateUser(int id, string userName, string password)
            {
                MySqlCommand cmdUpdate = new MySqlCommand("UPDATE `inventory` SET`InvName`=@in,`Price`=@pc,`Description`=@desc WHERE  `InvId`=@id", connect.getconnection);

                cmdUpdate.Parameters.Add("@ui", MySqlDbType.Int32).Value = id;
                cmdUpdate.Parameters.Add("@un", MySqlDbType.VarChar).Value = userName;
                cmdUpdate.Parameters.Add("@pw", MySqlDbType.Int32).Value = password;
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
}
