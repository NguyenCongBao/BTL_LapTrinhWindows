using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyThuVien_DAL;
using QuanLyThuVien_DAL.BAO;

namespace QuanLyThuVien_BUS
{
    public class DocGia_BUS
    {
        Data_DAL da = new Data_DAL();
        public DataTable ShowDocGia()
        {
            string sql = "select maDG,hoTenDG,maDT,case when gioiTinh='false' then 'Nu' when gioiTinh='true' then 'Nam' end as gioiTinh,ngaySinh, ngayCap" +
           " ,ngayHetHan from DocGia10";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable getcomboMaDocGia10()
        {
            string sql = "select * from DocGia10";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable getcomboMaDoiTuong()
        {
            string sql = "select * from DoiTuong10";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InsertDocGia(string ma, string ten, Boolean gioiTinh, string ngaySinh, string maDoiTuong, string ngayCap, string ngayHetHan)
        {
            string sql = "insert into DocGia10 values(N'" + ma + "',N'" + ten + "',N'" + gioiTinh + "',N'" + ngaySinh + "',N'" + maDoiTuong + "',N'" + ngayCap + "','" + ngayHetHan + "')";
            da.ExcuteNonQuery(sql);
        }
        public void DeleteDocGia(string ma)
        {
            string sql = "delete DocGia10 where maDG=N'" + ma + "'";
            da.ExcuteNonQuery(sql);

        }
        public void UpdateDocGia(string ma, string ten, Boolean gioiTinh, string ngaySinh, string maDoiTuong, string ngayCap, string ngayHetHan)
        {
            string sql = "update DocGia10 set hoTenDG=N'" + ten + "',gioiTinh=N'" + gioiTinh + "',ngaySinh=N'" + ngaySinh + "',maDT=N'" + maDoiTuong + "',ngayCap=N'" + ngayCap + "',ngayHetHan=N'" + ngayHetHan + "'where maDG=N'" + ma + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable SearchDocGia(string ma)
        {
            string sql = "select *from DocGia10 where maDG ='" + ma + "'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

    }
}
