using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    class Database
    {
        //Thuộc tinh
        SqlConnection sqlconn;
        SqlDataAdapter da;
        //Contructor kh i tạo
        public Database()
        {
            string connStr;

            //Đ ng nhập SQL Server s dụng SQL Server Authentication Mode.
            connStr = "Data Source=HOANGNGUYEN\\HOANGNGUYEN;Initial Catalog=QLSV;Persist Security Info=True;User ID=sa; password =123456";
            sqlconn = new SqlConnection(connStr);
        }
        public DataTable Execute(string strQuery)
        {
            //Câu lệnh này tạo mới một đối tượng SqlDataAdapter và
            //cung cấp cho nó câu truy vấn cùng với kết nối hiện hành
            da = new SqlDataAdapter(strQuery, sqlconn);
            //DataTable đại diện cho một bảng dữ liệu
            DataTable dt = new DataTable();
            //Dùng SqlDataAdapter đã tạo ra trên thực thi câu lệnh truy vấn đã cung cấp,
            //và đưa kết quả trả về là dt
            da.Fill(dt);
            //trả dữ liệu đã lấy về cho phương thức
            return dt;
        }
    }
}
