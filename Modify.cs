using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLiQuanCaPhe
{
    internal class Modify
    {
        public Modify(){}
        SqlCommand command; //dùng để truy vấn các câu lệnh insert, update, delete...
        SqlDataReader dataReader;//dùng để đọc dữ liệu trong bảng database
        public List<Taikhoan> Taikhoan(string query)
        {
            List<Taikhoan> taikhoan = new List<Taikhoan>();
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                command = new SqlCommand(query, conn);
                dataReader = command.ExecuteReader();//tiến hành đọc dữ liệu
                while (dataReader.Read())
                {
                    taikhoan.Add(new Taikhoan(dataReader.GetString(0), dataReader.GetString(1)));//add tài khoản và mật khẩu
                }

                conn.Close();
            }
            return taikhoan;
        }

        public void Command(string query)//dùng để đăng kí tài khoản
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();//thực thi câu truy vấn
                connection.Close();
            }
        }
    }
}

