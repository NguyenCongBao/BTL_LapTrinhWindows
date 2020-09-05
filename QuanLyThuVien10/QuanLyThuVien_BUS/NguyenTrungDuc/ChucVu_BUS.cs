using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChucVu_BUS
    {
        DAL.Lop_DAL dal = new DAL.Lop_DAL();
        public DataTable HienThiChucVu()
        {
            string sql = "SELECT * FROM ChucVu10";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
        public void insertChucVu(string macv, string tencv)
        {
            string sql = "insert into ChucVu10 values ('" + macv + "',N'" + tencv + "')";
            dal.ExecuteNoneQuery(sql);
        }
        public void updateChucVu(string macv, string tencv)
        {
            string sql = "update ChucVu10 set tenCV=N'" + tencv + "' where maCV='" + macv + "'";
            dal.ExecuteNoneQuery(sql);
        }
        public void deleteChucVu(string macv)
        {
            string sql = "delete ChucVu10 where maCV='" + macv + "'";
            //dal.ExecuteNoneQuery("delete NhanVien10 where maCV='" + macv + "'");
            dal.ExecuteNoneQuery(sql);
        }
        public DataTable selectChucVu(string macv)
        {
            string sql = "SELECT * FROM ChucVu10 where maCV='" + macv + "'";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
    }
}
