using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyThuVien_DAL;
using QuanLyThuVien_DTO;
using System.Data;
using QuanLyThuVien_DAL.BAO;

namespace QuanLyThuVien_BUS
{
    public class TheLoai_BUS
    {
        Data_DAL da = new Data_DAL();
        

        public DataTable ShowTheLoai()
        {
            string sql = "select *from TheLoai10";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
            
        }
        public void InsertTheLoai(string ma,string ten,string gc)
        {
            string sql = "insert into TheLoai10 values(N'" + ma + "',N'" + ten + "',N'" + gc + "')";
            da.ExcuteNonQuery(sql)
;        }



        //delete the loai
        public void DeleteTheLoai(string ma)
        {
           // da.ExcuteNonQuery("delete PhieuMuonChiTiet10 where maTL in (select maTL from TaiLieu10 where maThL=N'" + ma + "')");
           // string sql1 = "delete TaiLieu10 where maThL=N'" + ma + "'";
            string sql = "delete TheLoai10 where maThL=N'" + ma + "'";
          //  da.ExcuteNonQuery(sql1);
            da.ExcuteNonQuery(sql);
        }




        public DataTable LookTheLoai(string ma)
        { 
            string sql="select *from TheLoai10 where maThL='"+ma+"'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void UpdateTheLoai(string ma,string ten,string gc)
        {
            string sql = "update TheLoai10 set tenThL=N'" + ten + "',ghiChu=N'" + gc + "' where maThL=N'" + ma + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable SearchTheLoai(string ma)
        {
            string sql = "select * from TheLoai10 where maThL='" + ma + "'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}
