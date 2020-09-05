using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien_DAL;
using QuanLyThuVien_DAL.NguyentrungDuc;

namespace NguyenTrungDuc.BUS
{
    public class NhanVien_BUS
    {
        Lop_DAL dal = new Lop_DAL();
        public DataTable HienThiNhanVien()
        {
            string sql = "SELECT * FROM NhanVien10";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
        public DataTable getCombobox()
        {
            string sql = "SELECT * FROM ChucVu10";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
        public void insertNhanVien(string manv, string ten, string cv, string tk, string mk, string quyen)
        {
            string sql = "insert into NhanVien10 values ('" + manv + "',N'" + ten + "',N'" + cv + "','" + tk + "','" + mk + "',N'" + quyen + "')";
            dal.ExecuteNoneQuery(sql);
        }
        public void updateNhanVien(string manv, string ten, string cv, string tk, string mk, string quyen)
        {
            string sql = "update NhanVien10 set hoTenNV=N'" + ten + "',maCV='" + cv + "',taiKhoan='" + tk + "',matKhau='" + mk + "',quyen=N'" + quyen + "' where maNV=N'" + manv + "'";
            dal.ExecuteNoneQuery(sql);
        }

        //xóa nhân viên
        public void deleteNhanVien(string manv)
        {
            //dal.ExecuteNoneQuery("delete PhieuMuonChiTiet10 where maPM in (select maPM from PhieuMuon10)'" + manv + "'");
           // dal.ExecuteNoneQuery("delete PhieuMuon10 where maNV = '" + manv + "'");
            string sql = "delete NhanVien10 where maNV='" + manv + "'";
            dal.ExecuteNoneQuery(sql);
        }
        public DataTable selectNhanVien(string manv)
        {
            string sql = "SELECT * FROM NhanVien10 where maNV='" + manv + "'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
    }

}
