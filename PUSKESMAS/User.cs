using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PUSKESMAS
{
    public class User
    {
        protected String conString = ConfigurationManager.ConnectionStrings["db_puskesmas"].ConnectionString;
        static MySqlConnection conn;
        static MySqlCommand cmd;

        public int id_admin { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        public User()
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand();
        }
        public bool validasi()
        {
            bool result = false;
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM admin WHERE Username=@username AND Password=md5(@password)";
            cmd.Parameters.AddWithValue("@username", this.username);
            cmd.Parameters.AddWithValue("@password", this.password);
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    id_admin = Convert.ToInt16(rdr["id_admin"]);
                    result = true;
                }
            }
            catch (Exception e)
            {
                String error = e.Message;
            }
            conn.Close();
            return result;
        }
    }
    
}
