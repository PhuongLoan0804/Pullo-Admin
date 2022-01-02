using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Pullo_Admin.Models
{
    public class StoreContext
    {
        public string ConnectionString { get; set; }//biến thành viên 

        public StoreContext(string connectionString) //phuong thuc khoi tao
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection() //lấy connection 
        {
            return new MySqlConnection(ConnectionString);
        }

        //-----[DANH MỤC SẢN PHẨM]-----
        public List<DanhMuc> GetDanhMucs()
        {
            List<DanhMuc> list = new List<DanhMuc>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from DANHMUC";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new DanhMuc()
                        {
                            MADM = Convert.ToInt32(reader["MADM"]),
                            TENDM = reader["TENDM"].ToString(),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        internal int UpdateDM(DanhMuc dm)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update DANHMUC set tendm = @tendm where madm=@madm";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("tendm", dm.TENDM);
                cmd.Parameters.AddWithValue("madm", dm.MADM);
                return (cmd.ExecuteNonQuery());
            }
        }

        public int ThemDM(DanhMuc dm)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into DANHMUC(tendm) values(@tendm)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("tendm", dm.TENDM);

                return (cmd.ExecuteNonQuery());

            }
        }
        public DanhMuc ViewDM(int madm)
        {
            DanhMuc dm = new DanhMuc();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from DANHMUC where madm=@madm";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("madm", madm);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    dm.MADM = madm;
                    dm.TENDM = reader["tendm"].ToString();
                }
            }
            return (dm);
        }
        public int XoaDM(int madm)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from DANHMUC where madm=@madm";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("madm", madm);
                return (cmd.ExecuteNonQuery());
            }
        }

        //-----[DANH MỤC SÁCH]-----
        public List<Sach> GetSachs()
        {
            List<Sach> list = new List<Sach>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from SACH";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Sach()
                        {
                            ISBN = Convert.ToInt32(reader["ISBN"]),
                            TENSACH = reader["TENSACH"].ToString(),
                            MADM = Convert.ToInt32(reader["MADM"]),
                            TACGIA = reader["TACGIA"].ToString(),
                            MOTA = reader["MOTA"].ToString(),
                            GIATIEN = Convert.ToDouble(reader["GIATIEN"]),
                            URL = reader["URL"].ToString(),
                            SOLUONG = Convert.ToInt32(reader["SOLUONG"]),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        internal int UpdateSach(Sach sach)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update SACH set tensach = @tensach, tacgia= @tacgia, mota=@mota, giatien=@giatien, soluong=@soluong where isbn=@isbn";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("tensach", sach.TENSACH);
                cmd.Parameters.AddWithValue("tacgia", sach.TACGIA);
                cmd.Parameters.AddWithValue("mota", sach.MOTA);
                cmd.Parameters.AddWithValue("giatien", sach.GIATIEN);
                cmd.Parameters.AddWithValue("soluong", sach.SOLUONG);
                cmd.Parameters.AddWithValue("isbn", sach.ISBN);
                //cmd.Parameters.AddWithValue("madm", sach.MADM);
                return (cmd.ExecuteNonQuery());
            }
        }

        public int ThemSach(Sach sach)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "INSERT INTO sach(madm, tensach, tacgia, mota, soluong, giatien, url) VALUES (@madm, @tensach, @tacgia, @mota, @soluong, @giatien, @url)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("tensach", sach.TENSACH);
                cmd.Parameters.AddWithValue("tacgia", sach.TACGIA);
                cmd.Parameters.AddWithValue("mota", sach.MOTA);
                cmd.Parameters.AddWithValue("giatien", sach.GIATIEN);
                cmd.Parameters.AddWithValue("url", sach.URL);
                cmd.Parameters.AddWithValue("soluong", sach.SOLUONG);
                cmd.Parameters.AddWithValue("madm", sach.MADM);
                return (cmd.ExecuteNonQuery());

            }
        }
        public Sach ViewSach(int isbn)
        {
            Sach sach = new Sach();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from SACH where isbn=@isbn";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("isbn", isbn);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    sach.ISBN = isbn;
                    sach.TENSACH = reader["TENSACH"].ToString();
                    sach.MADM = Convert.ToInt32(reader["MADM"]);
                    sach.TACGIA = reader["TACGIA"].ToString();
                    sach.MOTA = reader["MOTA"].ToString();
                    sach.GIATIEN = Convert.ToDouble(reader["GIATIEN"]);
                    sach.URL = reader["URL"].ToString();
                    sach.SOLUONG = Convert.ToInt32(reader["SOLUONG"]);
                }
            }
            return (sach);
        }
        public int XoaSach(int isbn)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from SACH where isbn=@isbn";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("isbn", isbn);
                return (cmd.ExecuteNonQuery());
            }
        }
    }
}
