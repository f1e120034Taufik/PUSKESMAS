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
    public class DataObat
    {
        protected String conString = ConfigurationManager.ConnectionStrings["db_puskesmas"].ConnectionString;
        static MySqlConnection conn;
        static MySqlCommand cmd;

        public int Id_obat { get; set; }
        public string Nama_obat { get; set; }
        public string Jenis_obat { get; set; }
        public string Kuantitas { get; set; }
        public string Kandungan { get; set; }

        public DataObat()
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand();
        }

        public static DataObat selectId(int Id_obat)
        {
            DataObat dataObat = new DataObat();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM obat WHERE Id_obat=@Id_obat";
            cmd.Parameters.AddWithValue("@Id_obat", Id_obat);
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    dataObat.Id_obat = Convert.ToInt16(rdr["Id_obat"]);
                    dataObat.Nama_obat = rdr["Nama_obat"].ToString();
                    dataObat.Jenis_obat = rdr["Jenis_obat"].ToString();
                    dataObat.Kuantitas = rdr["Kuantitas"].ToString();
                    dataObat.Kandungan = rdr["Kandungan"].ToString();
                }
            }
            catch (Exception e)
            {
                String error = e.Message;
            }
            conn.Close();
            return dataObat;
        }
        public DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM obat", conn))
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
            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO obat (Id_obat,Nama_obat,Jenis_obat,Kuantitas,Kandungan) " +
                "VALUES (@Id_obat,@Nama_obat,@Jenis_obat,@Kuantitas,@Kandungan)", conn))
            {
                cmd.Parameters.AddWithValue("@Id_obat", this.Id_obat);
                cmd.Parameters.AddWithValue("@Nama_obat", this.Nama_obat);
                cmd.Parameters.AddWithValue("@Jenis_obat", this.Jenis_obat);
                cmd.Parameters.AddWithValue("@Kuantitas", this.Kuantitas);
                cmd.Parameters.AddWithValue("@Kandungan", this.Kandungan);
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
        public DataTable select(String Nama_obat)
        {
            DataTable dt = new DataTable();
            cmd = conn.CreateCommand();
            if (Nama_obat != "")
            {
                cmd.CommandText = "SELECT * FROM obat WHERE Nama_obat LIKE @Nama_obat";
                cmd.Parameters.AddWithValue("@Nama_obat", "%" + Nama_obat + "%");
            }
            else cmd.CommandText = "SELECT * FROM obat";
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
            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM obat WHERE Id_obat=@Id_obat ", conn))
            {
                cmd.Parameters.AddWithValue("@Id_obat", this.Id_obat);
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
            using (MySqlCommand cmd = new MySqlCommand("UPDATE obat SET Nama_obat=@Nama_obat," +
                "Jenis_obat=@Jenis_obat,Kuantitas=@Kuantitas,Kandungan=@Kandungan WHERE Id_obat=@Id_obat", conn))
            {
                cmd.Parameters.AddWithValue("@Id_obat", this.Id_obat);
                cmd.Parameters.AddWithValue("@Nama_obat", this.Nama_obat);
                cmd.Parameters.AddWithValue("@Jenis_obat", this.Jenis_obat);
                cmd.Parameters.AddWithValue("@Kuantitas", this.Kuantitas);
                cmd.Parameters.AddWithValue("@Kandungan", this.Kandungan);
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
