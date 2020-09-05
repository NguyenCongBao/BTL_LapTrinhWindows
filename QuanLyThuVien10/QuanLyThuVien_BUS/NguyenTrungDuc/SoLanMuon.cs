using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class SoLanMuon
    {
        Lop_DAL dal = new Lop_DAL();
        public DataTable getMaTL(string ngayM, string ngayT)
        {
            string sql = "select TheLoai10.tenThL,TheLoai10.ghiChu,count(*) as solanmuon from"
    + " TheLoai10 inner join TaiLieu10 on TheLoai10.maThL = TaiLieu10.maThL"
    + " inner join PhieuMuonChiTiet10 on TaiLieu10.maTL = PhieuMuonChiTiet10.maTL"
    + " inner join PhieuMuon10 on PhieuMuon10.maPM = PhieuMuonChiTiet10.maPM"
    + " where ngayMuon>= '" +ngayM+ "' and ngayTra<='" +ngayT+ "'"
    + " group by TheLoai10.tenThL,TheLoai10.ghiChu";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        } 
    }
}
