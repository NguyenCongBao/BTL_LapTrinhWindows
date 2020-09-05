using BUS;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_GUI.NguyenTrungDuc
{
    public partial class ThongKesolanmuontheoThL : Form
    {
        ReportDataSource rp = new ReportDataSource();
        SoLanMuon bus = new SoLanMuon();
        DataTable dt;
        public ThongKesolanmuontheoThL()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
          
            dt = new DataTable();
            dt = bus.getMaTL(dtNgayM.Value.Date.ToString("yyyy-MM-dd"), dtNgayT.Value.Date.ToString("yyyy-MM-dd"));
            dgvThongKe.DataSource = dt;
           
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            // Kết xuất nguồn dữ liệu cho report
            TKSLtheoThL baocao = new TKSLtheoThL();
            baocao.SetDataSource(bus.getMaTL(dtNgayM.Value.Date.ToString("yyyy-MM-dd"), dtNgayT.Value.Date.ToString("yyyy-MM-dd")));
            //  Hiển Thị Dữ Liệu
            FormHiensltheoThL prf = new FormHiensltheoThL();
            prf.view1.ReportSource = baocao;
            prf.ShowDialog();
        }

        private void ThongKesolanmuontheoThL_Load(object sender, EventArgs e)
        {
            lbnguoidung.Text = dangNhap_GUI.tendn;
        }
    }
}
