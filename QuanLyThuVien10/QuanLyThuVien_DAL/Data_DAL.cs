﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_DAL.NguyentrungDuc
{
    public class Lop_DAL
    {
        public SqlConnection getConnection()
        {

            return new SqlConnection(@"Data Source=DESKTOP-9O7NFIJ\SQLEXPRESS;Initial Catalog=Quan_Ly_Thu_Vien;Integrated Security=True");
        }

        public DataTable getTable(string sql)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public void ExecuteNoneQuery(string sql)
        {
            SqlConnection conn = getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
        }
    }
}
