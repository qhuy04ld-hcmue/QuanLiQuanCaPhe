using QuanLiQuanCaPhe.DAO;
using QuanLiQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanCaPhe
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            _Load();
            
        }
        #region methods
        void _Load()
        {

            LoadDateTimePikerBill(); 
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value); 
            LoadListFood();
            AddFoodBinding();
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }
        
        void LoadDateTimePikerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListFood()
        {
            dtgvFood.DataSource = FoodDAO.Instance.GetListFood();
        }
        void AddFoodBinding()
        {
            tbxFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name"));
            tbxFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID"));
            //nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "price"));
            }
        #endregion
        #region events
        private void bttViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        
        private void dateTime1_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void tpFood_Click(object sender, EventArgs e)
        {

        }
        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tcBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void bttShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }
        #endregion

        private void bttAddFood_Click(object sender, EventArgs e)
        {
            /*
            string name = tbxFoodName.Text;
            //int categoryID = (cbCategory.SelectedItem as Category).ID;
            int categoryID = (int)cbCategory;
            float price = (float)nmFoodPrice.Value;
            if (FoodDAO.Instance.InsertFood(name,categoryID,price))
            {
                MessageBox.Show("Thêm món thành công ");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thao tác");
            }
            */
        }

        
    }
}