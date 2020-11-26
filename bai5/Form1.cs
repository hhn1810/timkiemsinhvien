using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5
{
    public partial class Form1 : Form
    {
        SinhVien sv;//lớp x lý nghiệp vụ nhân viên
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
            sv = new SinhVien();
            dt = new DataTable();
        }
        public void HienThiAllSV()
        {
            dt = sv.LayDSNhanVien();
            listView1.Items.Clear();
            listView1.View = View.Details;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = listView1.Items.Add(dt.Rows[i]["id"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["mssv"].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTimKiem.Focus();
            HienThiAllSV();
            comboBox1.SelectedIndex = 0;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "MSSV":
                    dt = sv.Search(txtTimKiem.Text,"mssv");
                    break;
                case "Họ Và Tên":
                    dt = sv.Search(txtTimKiem.Text, "hoten");
                    break;
                case "Ngày Sinh":
                    dt = sv.Search(txtTimKiem.Text, "ngaysinh");
                    break;
                case "Giới Tính":
                    dt = sv.Search(txtTimKiem.Text, "gioitinh");
                    break;
                case "Quê Quán":
                    dt = sv.Search(txtTimKiem.Text, "quequan");
                    break;
            }
            listView1.Items.Clear();
            listView1.View = View.Details;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = listView1.Items.Add(dt.Rows[i]["id"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["mssv"].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
            }
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isBackspace = e.KeyChar == '\b';
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !isBackspace && e.KeyChar != '/')
            {
                e.Handled = true;

            }
        }
    }
}
