using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCaPhe
{
    internal class DanhSachTaiKhoan
    {
        private static DanhSachTaiKhoan instance;
        public static  DanhSachTaiKhoan Instance
        {
            get
            {
                if (instance == null)
                    instance = new DanhSachTaiKhoan();
                return instance;
            }
            set => instance = value;
        }
        List<Taikhoan> listTaiKhoan;
        public List<Taikhoan> ListTaiKhoan
        {
            get { return listTaiKhoan; }
            set { listTaiKhoan = value; }
        }
        
    }
}
