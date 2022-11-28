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

        UtilityDB connect = new UtilityDB();

        public bool insertUser(string userName, string password, string type)
        {
            MySqlCommand cmdInsert = new MySqlCommand("INSERT INTO `user`(`username`, `password`, `type`) VALUES (@un,@pw,@ty)", connect.getconnection);
            cmdInsert.Parameters.Add("@un", MySqlDbType.VarChar).Value = userName;
            cmdInsert.Parameters.Add("@pw", MySqlDbType.VarChar).Value = password;
            cmdInsert.Parameters.Add("@ty", MySqlDbType.VarChar).Value = type;

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

        public bool updateUser(int userid, string userName, string password, string type)
        {
            MySqlCommand cmdUpdate = new MySqlCommand("UPDATE `user` SET`username`=@un,`password`=@pw,`type`=@ty WHERE  `userId`=@ui", connect.getconnection);

            cmdUpdate.Parameters.Add("@ui", MySqlDbType.Int32).Value = userid;
            cmdUpdate.Parameters.Add("@un", MySqlDbType.VarChar).Value = userName;
            cmdUpdate.Parameters.Add("@pw", MySqlDbType.VarChar).Value = password;
            cmdUpdate.Parameters.Add("@ty", MySqlDbType.VarChar).Value = type;

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

        public bool deleteUser(int id)
        {
            MySqlCommand cmdDelete = new MySqlCommand("DELETE FROM `user` WHERE `userId`=@ui", connect.getconnection);
            cmdDelete.Parameters.Add("@ui", MySqlDbType.Int32).Value = id;
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
        public DataTable getUserList(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
