using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PUSKESMAS
{
    public class DataRuang
    {
        protected String conString = ConfigurationManager.ConnectionStrings["db_puskesmas"].ConnectionString;
        static MySqlConnection conn;
        static MySqlCommand cmd;

        public int Id_ruang { get; set; }
        public string No_ruangan { get; set; }
        public string Pasien { get; set; }
        public string Dokter { get; set; }

        public DataRuang()
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand();
        }

        public static DataRuang selectId(int Id_ruang)
        {
            DataRuang dataRuang = new DataRuang();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM ruang WHERE Id_ruang=@Id_ruang";
            cmd.Parameters.AddWithValue("@Id_ruang", Id_ruang);
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    dataRuang.Id_ruang = Convert.ToInt16(rdr["Id_ruang"]);
                    dataRuang.Pasien = rdr["Pasien"].ToString();
                    dataRuang.Dokter = rdr["Dokter"].ToString();
                }
            }
            catch (Exception e)
            {
                String error = e.Message;
            }
            conn.Close();
            return dataRuang;
        }
        public DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM ruang", conn))
            {
                try
                {
                    //conn = new MySqlConnection(conString);
                    conn.Open();
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                    conn.Close();
                }
                catch (Exception e)
                {
                    String error = e.Message;
                } 
            }
            return dt;
        }
        public string insert()
        {
            string result = null;
            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO ruang (Id_ruang,No_ruangan,Pasien,Dokter) " +
                "VALUES (@Id_ruang,@No_ruangan,@Pasien,@Dokter)", conn))
            {
                cmd.Parameters.AddWithValue("@Id_ruang", this.Id_ruang);
                cmd.Parameters.AddWithValue("@No_ruangan", this.No_ruangan);
                cmd.Parameters.AddWithValue("@Pasien", this.Pasien);
                cmd.Parameters.AddWithValue("@Dokter", this.Dokter);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
            return result;
        }
        public DataTable select(String No_ruangan)
        {
            DataTable dt = new DataTable();
            cmd = conn.CreateCommand();
            if (Pasien != "")
            {
                cmd.CommandText = "SELECT * FROM ruang WHERE No_ruangan=@No_ruangan";
                cmd.Parameters.AddWithValue("@No_ruangan", No_ruangan);
            }
            else cmd.CommandText = "SELECT * FROM ruang";
            try
            {
                conn.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                conn.Close();
            }
            catch (Exception e)
            {
                String error = e.Message;
            }
            return dt;
        }
        public string delete()
        {
            string result = null;
            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM ruang WHERE Id_ruang=@Id_ruang ", conn))
            {
                cmd.Parameters.AddWithValue("@Id_ruang", this.Id_ruang);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
            return result;
        }
        public string update()
        {
            string result = null;
            using (MySqlCommand cmd = new MySqlCommand("UPDATE ruang SET No_ruangan=@No_ruangan,Pasien=@Pasien," +
                "Dokter=@Dokter, WHERE Id_ruang=@Id_ruang", conn))
            {
                cmd.Parameters.AddWithValue("@Id_ruang", this.Id_ruang);
                cmd.Parameters.AddWithValue("@No_ruangan", this.No_ruangan);
                cmd.Parameters.AddWithValue("@Pasien", this.Pasien);
                cmd.Parameters.AddWithValue("@Dokter", this.Dokter);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
            return result;
        }
    }
}
