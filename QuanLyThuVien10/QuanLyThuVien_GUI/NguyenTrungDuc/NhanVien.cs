using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NguyenTrungDuc.BUS;

namespace QuanLyThuVien_GUI.NguyenTrungDuc
{
    public partial class NhanVien : Form
    {
        NhanVien_BUS bus = new NhanVien_BUS();
        DataTable dtNhanVien,dtChucVu, dtTimKiem;
        public NhanVien()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmanv.Text == "")
                    MessageBox.Show("Chưa nhập mã nhân viên");
                else if (txthoten.Text == "")
                    MessageBox.Show("Chưa nhập tên nhân viên");
                else if (cbochucvu.Text == "")
                    MessageBox.Show("Chưa chọn chức vụ");
                else if (txttaikhoan.Text == "")
                    MessageBox.Show("Chưa nhập tên tài khoản");
                else if (txtmatkhau.Text == "")
                    MessageBox.Show("Chưa nhập mật khẩu");
                else if (cboquyen.Text == "")
                    MessageBox.Show("Chưa chọn quyền");
                else
                {

                    int dem = 0;
                    foreach (DataRow r in dtNhanVien.Rows)
                    {
                        var check = r["maNV"].ToString().Trim();
                        if (txtmanv.Text.Trim() == check)
                        {
                            dem++;
                            break;
                        }
                    }
                    if (dem == 0)
                    {
                        bus.insertNhanVien(txtmanv.Text, txthoten.Text, cbochucvu.SelectedValue.ToString(), txttaikhoan.Text, txtmatkhau.Text, cboquyen.Text);
                        LoadData();
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại");
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Không thêm được nhân viên");
            }
        }

        public void LoadData()
        {
            dtNhanVien = new DataTable();
            dtNhanVien = bus.HienThiNhanVien();
            dgvNhanVien.DataSource = dtNhanVien;
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            loadcombobox();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmanv.Text == "")
                    MessageBox.Show("Chưa nhập mã nhân viên");
                else if (txthoten.Text == "")
                    MessageBox.Show("Chưa nhập tên nhân viên");
                else if (cbochucvu.Text == "")
                    MessageBox.Show("Chưa chọn chức vụ");
                else if (txttaikhoan.Text == "")
                    MessageBox.Show("Chưa nhập tên tài khoản");
                else if (txtmatkhau.Text == "")
                    MessageBox.Show("Chưa nhập mật khẩu");
                else if (cboquyen.Text == "")
                    MessageBox.Show("Chưa chọn quyền");
                else
                {
                    int dem = 0;
                    foreach (DataRow r in dtNhanVien.Rows)
                    {
                        var check = r["maNV"].ToString().Trim();
                        if (txtmanv.Text.Trim() == check)
                        {
                            dem++;
                            break;
                        }
                    }
                    if (dem != 0)
                    {
                        bus.updateNhanVien(txtmanv.Text, txthoten.Text, cbochucvu.SelectedValue.ToString(), txttaikhoan.Text, txtmatkhau.Text, cboquyen.Text);
                        LoadData();
                        MessageBox.Show("Sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên không tồn tại");
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Không sửa được nhân viên");
            }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                bus.deleteNhanVien(txtmanv.Text.Trim());
                MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            txtmanv.Text = "";
            txthoten.Text = "";
            txttaikhoan.Text = "";
            txtmatkhau.Text = "";
            txtmanv.Focus();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            dtTimKiem = new DataTable();
            dtTimKiem = bus.selectNhanVien(txtmanv.Text.Trim());
            dgvNhanVien.DataSource = dtTimKiem;
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNhanVien.CurrentCell.RowIndex;
            txtmanv.Text = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
            txthoten.Text = dgvNhanVien.Rows[r].Cells[1].Value.ToString();
            cbochucvu.SelectedValue = dgvNhanVien.Rows[r].Cells[2].Value.ToString();
            txttaikhoan.Text = dgvNhanVien.Rows[r].Cells[3].Value.ToString();
            txtmatkhau.Text = dgvNhanVien.Rows[r].Cells[4].Value.ToString();
            cboquyen.Text = dgvNhanVien.Rows[r].Cells[5].Value.ToString();
        }
        public void loadcombobox()
        {
            dtChucVu = new DataTable();
            dtChucVu = bus.getCombobox();
            cbochucvu.DataSource = dtChucVu;
            cbochucvu.DisplayMember = "tenCV";
            cbochucvu.ValueMember = "maCV";

        }
    }
}
