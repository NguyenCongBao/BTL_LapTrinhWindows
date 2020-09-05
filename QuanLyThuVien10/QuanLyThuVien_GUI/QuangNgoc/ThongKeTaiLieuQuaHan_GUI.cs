using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyThuVien_DAL;
using QuanLyThuVien_BUS;
using QuanLyThuVien_DTO;
using Microsoft.Reporting.WinForms;
using QuanLyThuVien_GUI.QuangNgoc;

namespace QuanLyThuVien_GUI
{
    public partial class ThongKeTaiLieuQuaHan_GUI : Form
    {
        ReportDataSource rp = new ReportDataSource();
        ThongKeQuaHan_BUS bus = new ThongKeQuaHan_BUS();
        DataTable dt;
        public ThongKeTaiLieuQuaHan_GUI()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            /*if (dtNgayM.Value.Equals("2/ 2/1999") || dtNgayT.Value.Equals(DateTime.Now.ToString("yyyy-MM-dd")))
            {
                DateTime dat = DateTime.Parse("02/02/1999");
                MessageBox.Show("Bạn chưa chọn ngày Mượn và ngày Trả! Ứng dụng sẽ xuất tài liệu ra từ đầu đến bây giờ");
                dt = new DataTable();
                dt = bus.SearchThongKe(dat.ToString("yyyy-MM-dd"), DateTime.Now.ToString("yyyy-MM-dd"));
                dgvThongKe.DataSource = dt;
            }
            else
            {*/
                dt = new DataTable();
                dt = bus.TKTLquahan(dtNgayM.Value.Date.ToString("yyyy-MM-dd"), dtNgayT.Value.Date.ToString("yyyy-MM-dd"));
                dgvThongKe.DataSource = dt;
           // }
        }

        private void ThongKeTaiLieuQuaHan_GUI_Load(object sender, EventArgs e)
        {
            lbnguoidung.Text = dangNhap_GUI.tendn;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvThongKe_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvThongKe.Rows.Count; i++)
            {
                dgvThongKe.Rows[i].Cells[0].Value = i + 1;
            }
        }


        ThongKeQuaHan_BUS rppm = new ThongKeQuaHan_BUS();
        private void btnXuat_Click(object sender, EventArgs e)
        {
            // Kết xuất nguồn dữ liệu cho report
            crpTKTLQH baocao = new crpTKTLQH();
            baocao.SetDataSource(rppm.TKTLquahan(dtNgayM.Value.Date.ToString("yyyy-MM-dd"), dtNgayT.Value.Date.ToString("yyyy-MM-dd")));
            //  Hiển Thị Dữ Liệu
            TKTLQH_GUI prf = new TKTLQH_GUI();
            prf.viewTKTLQH.ReportSource = baocao;
            prf.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

    public class ThongKeQuaHan
    {
        string sott, madocgia, tendocgia, tentailieu, ngaymuon,songayQH;

        public string Sott { get => sott; set => sott = value; }
        public string Madocgia { get => madocgia; set => madocgia = value; }
        public string Tendocgia { get => tendocgia; set => tendocgia = value; }
        public string Tentailieu { get => tentailieu; set => tentailieu = value; }
        public string Ngaymuon { get => ngaymuon; set => ngaymuon = value; }
        public string SongayQH { get => songayQH; set => songayQH = value; }
    }
}
