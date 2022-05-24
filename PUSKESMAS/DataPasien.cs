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
    public class DataPasien
    {
        protected String conString = ConfigurationManager.ConnectionStrings["db_puskesmas"].ConnectionString;
        static MySqlConnection conn;
        static MySqlCommand cmd;

        public int Id_pasien { get; set; }
        public string Nama_pasien { get; set; }
        public string Alamat_pasien { get; set; }
        public string Hp_pasien { get; set; }
        public string Tgl_lahir_pasien { get; set; }
        public string Jenis_kelamin_pasien { get; set; }
        public string Obat { get; set; }
        public string R_penyakit_sebelumnya { get; set; }
        public string Dr_perawat { get; set; }

        public DataPasien()
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand();
        }

        public static DataPasien selectId(int Id_pasien)
        {
            DataPasien dataPasien = new DataPasien();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM pasien WHERE Id_pasien=@Id_pasien";
            cmd.Parameters.AddWithValue("@Id_pasien", Id_pasien);
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    dataPasien.Id_pasien = Convert.ToInt16(rdr["Id_pasien"]);
                    dataPasien.Nama_pasien = rdr["Nama_pasien"].ToString();
                    dataPasien.Alamat_pasien = rdr["Alamat_pasien"].ToString();
                    dataPasien.Hp_pasien = rdr["Hp_pasien"].ToString();
                    dataPasien.Tgl_lahir_pasien = rdr["Tgl_lahir_pasien"].ToString();
                    dataPasien.Jenis_kelamin_pasien = rdr["Jenis_kelamin_pasien"].ToString();
                    dataPasien.Obat = rdr["Obat"].ToString();
                    dataPasien.Dr_perawat = Convert.ToString(rdr["Dr_perawat"]);
                    dataPasien.R_penyakit_sebelumnya = Convert.ToString(rdr["R_penyakit_sebelumnya"]);
                }
            }
            catch (Exception e)
            {
                String error = e.Message;
            }
            conn.Close();
            return dataPasien;
        }
        public DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM pasien", conn))
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
            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO pasien (Id_pasien,Nama_pasien,Alamat_pasien,Hp_pasien,Tgl_lahir_pasien,Jenis_kelamin_pasien,Obat,Dr_perawat,R_penyakit_sebelumnya) " +
                "VALUES (@Id_pasien,@Nama_pasien,@Alamat_pasien,@Hp_pasien,@Tgl_lahir_pasien,@Jenis_kelamin_pasien,@Obat,@Dr_perawat,@R_penyakit_sebelumnya)", conn))
            {
                cmd.Parameters.AddWithValue("@Id_pasien", this.Id_pasien);
                cmd.Parameters.AddWithValue("@Nama_pasien", this.Nama_pasien);
                cmd.Parameters.AddWithValue("@Alamat_pasien", this.Alamat_pasien);
                cmd.Parameters.AddWithValue("@Hp_pasien", this.Hp_pasien);
                cmd.Parameters.AddWithValue("@Tgl_lahir_pasien", this.Tgl_lahir_pasien);
                cmd.Parameters.AddWithValue("@Jenis_kelamin_pasien", this.Jenis_kelamin_pasien);
                cmd.Parameters.AddWithValue("@R_penyakit_sebelumnya", this.R_penyakit_sebelumnya);
                cmd.Parameters.AddWithValue("@Obat", this.Obat);
                cmd.Parameters.AddWithValue("@Dr_perawat", this.Dr_perawat);
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
        public DataTable select(String Nama_pasien)
        {
            DataTable dt = new DataTable();
            cmd = conn.CreateCommand();
            if (Nama_pasien != "")
            {
                cmd.CommandText = "SELECT * FROM pasien WHERE Nama_pasien LIKE @Nama_pasien";
                cmd.Parameters.AddWithValue("@Nama_pasien", "%" + Nama_pasien + "%");
            }
            else cmd.CommandText = "SELECT * FROM pasien";
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
            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM pasien WHERE Id_pasien=@Id_pasien ", conn))
            {
                cmd.Parameters.AddWithValue("@Id_pasien", this.Id_pasien);
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
            using (MySqlCommand cmd = new MySqlCommand("UPDATE pasien SET Nama_pasien=@Nama_pasien," +
                "Alamat_pasien=@Alamat_pasien,Hp_pasien=@Hp_pasien,Tgl_lahir_pasien=@Tgl_lahir_pasien,Jenis_kelamin_pasien=@Jenis_kelamin_pasien,Obat=@Obat,Dr_perawat=@Dr_perawat,R_penyakit_sebelumnya=@R_penyakit_sebelumnya WHERE Id_pasien=@Id_pasien", conn))
            {
                cmd.Parameters.AddWithValue("@Id_pasien", this.Id_pasien);
                cmd.Parameters.AddWithValue("@Nama_pasien", this.Nama_pasien);
                cmd.Parameters.AddWithValue("@Alamat_pasien", this.Alamat_pasien);
                cmd.Parameters.AddWithValue("@Hp_pasien", this.Hp_pasien);
                cmd.Parameters.AddWithValue("@Tgl_lahir_pasien", this.Tgl_lahir_pasien);
                cmd.Parameters.AddWithValue("@Jenis_kelamin_pasien", this.Jenis_kelamin_pasien);
                cmd.Parameters.AddWithValue("@Obat", this.Obat);
                cmd.Parameters.AddWithValue("@Dr_perawat", this.Dr_perawat);
                cmd.Parameters.AddWithValue("@R_penyakit_sebelumnya", this.R_penyakit_sebelumnya);
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
