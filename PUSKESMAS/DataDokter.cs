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
    public class DataDokter
    {
        protected String conString = ConfigurationManager.ConnectionStrings["db_puskesmas"].ConnectionString;
        static MySqlConnection conn;
        static MySqlCommand cmd;

        public int Id_dokter { get; set; }
        public string Nama_dokter { get; set; }
        public string Alamat_dokter { get; set; }
        public string Hp_dokter { get; set; }
        public string Email_dokter { get; set; }
        public string Tgl_lahir_dokter { get; set; }
        public string Jenis_kelamin_dokter { get; set; }
        public string Spesialis { get; set; }
        public string Jam_kerja { get; set; }

        public DataDokter()
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand();
        }

        public static DataDokter selectId(int Id_dokter)
        {
            DataDokter dataDokter = new DataDokter();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM dokter WHERE Id_dokter=@Id_dokter";
            cmd.Parameters.AddWithValue("@Id_dokter", Id_dokter);
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    dataDokter.Id_dokter = Convert.ToInt16(rdr["id_dokter"]);
                    dataDokter.Nama_dokter = rdr["Nama_dokter"].ToString();
                    dataDokter.Alamat_dokter = rdr["Alamat_dokter"].ToString();
                    dataDokter.Hp_dokter = rdr["Hp_dokter"].ToString();
                    dataDokter.Email_dokter = rdr["Email_dokter"].ToString();
                    dataDokter.Tgl_lahir_dokter = rdr["Tgl_lahir_dokter"].ToString();
                    dataDokter.Jenis_kelamin_dokter = rdr["Jenis_kelamin_dokter"].ToString();
                    dataDokter.Spesialis = rdr["Spesialis"].ToString();
                    dataDokter.Jam_kerja = rdr["Jam_kerja"].ToString();
                }
            }
            catch (Exception e)
            {
                String error = e.Message;
            }
            conn.Close();
            return dataDokter;
        }
        public DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM dokter", conn))
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
            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO dokter (Id_dokter,Nama_dokter,Alamat_dokter,Hp_dokter,Email_dokter,Tgl_lahir_dokter,Jenis_kelamin_dokter,Spesialis,Jam_kerja) " +
                "VALUES (@Id_dokter,@Nama_dokter,@Alamat_dokter,@Hp_dokter,@Email_dokter,@Tgl_lahir_dokter,@Jenis_kelamin_dokter,@Spesialis,@Jam_kerja)", conn))
            {
                cmd.Parameters.AddWithValue("@Id_dokter", this.Id_dokter);
                cmd.Parameters.AddWithValue("@Nama_dokter", this.Nama_dokter);
                cmd.Parameters.AddWithValue("@Alamat_dokter", this.Alamat_dokter);
                cmd.Parameters.AddWithValue("@Hp_dokter", this.Hp_dokter);
                cmd.Parameters.AddWithValue("@Email_dokter", this.Email_dokter);
                cmd.Parameters.AddWithValue("@Tgl_lahir_dokter", this.Tgl_lahir_dokter);
                cmd.Parameters.AddWithValue("@Jenis_kelamin_dokter", this.Jenis_kelamin_dokter);
                cmd.Parameters.AddWithValue("@Spesialis", this.Spesialis);
                cmd.Parameters.AddWithValue("@Jam_kerja", this.Jam_kerja);
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
        public DataTable select(String Nama_dokter)
        {
            DataTable dt = new DataTable();
            cmd = conn.CreateCommand();
            if (Nama_dokter != "")
            {
                cmd.CommandText = "SELECT * FROM dokter WHERE Nama_dokter LIKE @Nama_dokter";
                cmd.Parameters.AddWithValue("@Nama_dokter", "%" + Nama_dokter + "%");
            }
            else cmd.CommandText = "SELECT * FROM dokter";
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
            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM dokter WHERE Id_dokter=@Id_dokter ", conn))
            {
                cmd.Parameters.AddWithValue("@Id_dokter", this.Id_dokter);
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
            using (MySqlCommand cmd = new MySqlCommand("UPDATE dokter SET Nama_dokter=@Nama_dokter," +
                "Alamat_dokter=@Alamat_dokter,Hp_dokter=@Hp_dokter,Email_dokter=@Email_dokter,Tgl_lahir_dokter=@Tgl_lahir_dokter,Jenis_kelamin_dokter=@Jenis_kelamin_dokter,Spesialis=@Spesialis,Jam_kerja=@Jam_kerja WHERE Id_dokter=@Id_dokter", conn))
            {
                cmd.Parameters.AddWithValue("@Id_dokter", this.Id_dokter);
                cmd.Parameters.AddWithValue("@Nama_dokter", this.Nama_dokter);
                cmd.Parameters.AddWithValue("@Alamat_dokter", this.Alamat_dokter);
                cmd.Parameters.AddWithValue("@Hp_dokter", this.Hp_dokter);
                cmd.Parameters.AddWithValue("@Email_dokter", this.Email_dokter);
                cmd.Parameters.AddWithValue("@Tgl_lahir_dokter", this.Tgl_lahir_dokter);
                cmd.Parameters.AddWithValue("@Jenis_kelamin_dokter", this.Jenis_kelamin_dokter);
                cmd.Parameters.AddWithValue("@Spesialis", this.Spesialis);
                cmd.Parameters.AddWithValue("@Jam_kerja", this.Jam_kerja);
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
