using MySqlConnector;
using MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;

namespace PCC.BLL
{
    public class DbContext
    {


        string ConnectionString = "";
        MySqlConnection con;

        public void OpenConection()
        {
            con = new MySqlConnection(ConnectionString);
            con.Open();
        }


        public void CloseConnection()
        {
            con.Close();
        }


        public void ExecuteQueries(string Query_)
        {
            MySqlCommand cmd = new MySqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }


        public MySqlDataReader DataReader(string Query_)
        {
            MySqlCommand cmd = new MySqlCommand(Query_, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }


        public object ShowDataInGridView(string Query_)
        {
            MySqlDataAdapter dr = new MySqlDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }

        public void Connect()
        {
            try
            {
                var ConnectionString = "server=localhost;uid=root;pwd=asdf1234;database=pcc-db";
                var conn = new MySqlConnection(ConnectionString);
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("Nema");
            }
        }

    }

   

}
