using System;
using System.Data;
using System.Windows.Forms;
using BUS;
namespace GUI
{
    public partial class ChucVu : Form
    {
        ChucVu_BUS bus = new ChucVu_BUS();
        DataTable dtChucVu, dtTimKiem;
        public ChucVu()
        {
            InitializeComponent();
        }

        private void ChucVu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmacv.Text == "")
                    MessageBox.Show("Chưa nhập mã chức vụ");
                else if (txttencv.Text == "")
                    MessageBox.Show("Chưa nhập tên chức vụ");
                else
                {

                    int dem = 0;
                    foreach (DataRow r in dtChucVu.Rows)
                    {
                        var check = r["MaCV"].ToString().Trim();
                        if (txtmacv.Text.Trim() == check)
                        {
                            dem++;
                            break;
                        }
                    }
                    if (dem == 0)
                    {
                        bus.insertChucVu(txtmacv.Text, txttencv.Text);
                        LoadData();
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Mã chức vụ đã tồn tại");
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Không thêm được chức vụ");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtmacv.Text == "")
                    MessageBox.Show("Chưa nhập mã chức vụ");
                else if (txttencv.Text == "")
                    MessageBox.Show("Chưa nhập tên chức vụ");
                else
                {

                    int dem = 0;
                    foreach (DataRow r in dtChucVu.Rows)
                    {
                        var check = r["MaCV"].ToString().Trim();
                        if (txtmacv.Text.Trim() == check)
                        {
                            dem++;
                            break;
                        }
                    }
                    if (dem != 0)
                    {
                        bus.updateChucVu(txtmacv.Text, txttencv.Text);
                        LoadData();
                        MessageBox.Show("Sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Mã chức vụ không tồn tại");
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Không sửa được chức vụ");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                bus.deleteChucVu(txtmacv.Text.Trim());
                MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            dtTimKiem = new DataTable();
            dtTimKiem = bus.selectChucVu(txtmacv.Text.Trim());
            dgvChucVu.DataSource = dtTimKiem;
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            txtmacv.Text = "";
            txttencv.Text = "";
            txtmacv.Focus();
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            txtmacv.Text = dgvChucVu.Rows[r].Cells[0].Value.ToString();
            txttencv.Text = dgvChucVu.Rows[r].Cells[1].Value.ToString();
        }

        public void LoadData()
        {
            dtChucVu = new DataTable();
            dtChucVu = bus.HienThiChucVu();
            dgvChucVu.DataSource = dtChucVu;
        }
    }
}
