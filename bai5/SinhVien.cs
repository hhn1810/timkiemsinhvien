using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    class SinhVien
    {
        Database db;
        public SinhVien()
        {
            db = new Database();
        }
        //Lấy danh sách tất cả nhân viên
        public DataTable LayDSNhanVien()
        {//Trả về thông tin nhân viên và tên bằng cấp của nhân viên đó
            return db.Execute("Select * from SinhVien");
        }
        public DataTable Search(string nhapvao,string column)
        {
            return db.Execute("select * from SinhVien where "+ column+" like N'%" + nhapvao +"%'   order by id");
        }
    }
}
