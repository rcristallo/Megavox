using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

using MegaVox.DAL;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using MySqlX.XDevAPI.Relational;
using Microsoft.EntityFrameworkCore.Storage;

namespace MegaVox.BLL
{
    class ClientDB
    {
        UtilityDB connect = new UtilityDB();

        public bool insertClient(string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] img)
        {
            MySqlCommand cmdInsert = new MySqlCommand("INSERT INTO `client`(`CFirstName`, `CLastName`, `Birthdate`, `Gender`, `Phone`, `Address`, `Photo`) VALUES(@fn, @ln, @bd, @gd, @ph, @adr, @img)", connect.getconnection);

            cmdInsert.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            cmdInsert.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            cmdInsert.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            cmdInsert.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            cmdInsert.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            cmdInsert.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            cmdInsert.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

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

        public DataTable getClientList(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable searchClient(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `client` WHERE CONCAT(`CFirstName`,`CLastName`,`Address`) LIKE '%" + searchdata + "%'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool updateClient(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] img)
        {
            MySqlCommand cmdUpdate = new MySqlCommand("UPDATE `client` SET `CFirstName`=@fn,`CLastName`=@ln,`Birthdate`=@bd,`Gender`=@gd,`Phone`=@ph,`Address`=@adr,`Photo`=@img WHERE  `StdId`= @id", connect.getconnection);
            cmdUpdate.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            cmdUpdate.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            cmdUpdate.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            cmdUpdate.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            cmdUpdate.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            cmdUpdate.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            cmdUpdate.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            cmdUpdate.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            connect.openConnect();
            if (cmdUpdate.ExecuteNonQuery()==1)
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
                
        public bool deleteClient(int id)
        {
            MySqlCommand cmdDelete = new MySqlCommand("DELETE FROM `client` WHERE `CId`=@id", connect.getconnection);
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

        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }




    }
}
