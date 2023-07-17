using _1_DAL.Models;
using _2_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI.Views
{
    public partial class FormThi : Form
    {
        List<CuaHang> lstCH;
        CuaHangService bus;
        public FormThi()
        {
            InitializeComponent();
            bus = new CuaHangService();
            lstCH = new List<CuaHang>();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormThi_Load(object sender, EventArgs e)
        {
            Load();
        }
        void Load()
        {
            dtgv_data.Rows.Clear();
            dtgv_data.ColumnCount = 7;
            dtgv_data.Columns[0].HeaderText = "ID";
            dtgv_data.Columns[1].HeaderText = "Mã";
            dtgv_data.Columns[2].HeaderText = "Tên";
            dtgv_data.Columns[3].HeaderText = "Địa chỉ";
            dtgv_data.Columns[4].HeaderText = "Thành Phố";
            dtgv_data.Columns[5].HeaderText = "Quốc Gia";
            dtgv_data.Columns[6].HeaderText = "Addres";
            lstCH = bus.GetAll();
            foreach (var item in lstCH)
            {
                dtgv_data.Rows.Add(item.Id, item.Ma, item.Ten, item.DiaChi, item.ThanhPho, item.QuocGia, item.DiaChi + ", " + item.ThanhPho);
            }
        }

        private void bt_show_Click(object sender, EventArgs e)
        {

            Load();
        }

        bool XacNhan(string str)
        {
            if (MessageBox.Show($"Bạn có muốn {str}", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
        private void bt_create_Click(object sender, EventArgs e)
        {
            try
            {
                if (!XacNhan("thêm"))
                {
                    return;
                }
                CuaHang ch = new CuaHang()
                {
                    Id = Guid.NewGuid(),
                    Ma = tx_ma.Text,
                    Ten = tx_ten.Text,
                    DiaChi = tx_diaChi.Text,
                    ThanhPho = tx_tPho.Text,
                    QuocGia = tx_qGia.Text
                };
                var result = bus.Add(ch);
                if (result)
                {
                    bt_clear_Click(null, null);
                    Load();
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thât bại");
                }
            }
            catch (Exception)
            {


            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!XacNhan("xoá"))
                {
                    return;
                }
                CuaHang ch = new CuaHang()
                {
                    Id = Guid.Parse(tx_id.Text),
                    Ma = bus.CreateName(tx_ten.Text),
                    Ten = tx_ten.Text,
                    DiaChi = tx_diaChi.Text,
                    ThanhPho = tx_tPho.Text,
                    QuocGia = tx_qGia.Text
                };
                var result = bus.Delete(ch);
                if (result)
                {
                    bt_clear_Click(null, null);
                    Load();
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thât bại");
                }
            }
            catch (Exception)
            {


            }
        }

        private void tx_ten_TextChanged(object sender, EventArgs e)
        {
            tx_ma.Text = bus.CreateName(tx_ten.Text);
        }

        private void tx_tim_TextChanged(object sender, EventArgs e)
        {
            if (tx_tim.Text.Trim().Length == 0)
            {
                Load();
            }
            else
            {
                dtgv_data.Rows.Clear();
                lstCH = bus.Search(tx_tim.Text);
                foreach (var item in lstCH)
                {
                    dtgv_data.Rows.Add(item.Id, item.Ma, item.Ten, item.DiaChi, item.ThanhPho, item.QuocGia, item.DiaChi + ", " + item.ThanhPho);
                }
            }
        }

        private void dtgv_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tx_id.Text = dtgv_data.CurrentRow.Cells[0].Value.ToString();
                tx_ma.Text = dtgv_data.CurrentRow.Cells[1].Value.ToString();
                tx_ten.Text = dtgv_data.CurrentRow.Cells[2].Value.ToString();
                tx_diaChi.Text = dtgv_data.CurrentRow.Cells[3].Value.ToString();
                tx_tPho.Text = dtgv_data.CurrentRow.Cells[4].Value.ToString();
                tx_qGia.Text = dtgv_data.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception)
            {


            }
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            tx_id.Text = "";
            tx_ma.Text = "";
            tx_ten.Text = "";
            tx_diaChi.Text = "";
            tx_tPho.Text = "";
            tx_qGia.Text = "";
        }
    }
}
