using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace testsql
{
     public partial class Formdanhsachkhachhang : Form
     {
          SqlConnection con;//Khai báo đối tượng thực hiện kết nối đến cơ sở dữ liệu
          SqlCommand cmd;//Khai báo đối tượng thực hiện các câu lệnh truy vấn
          SqlDataAdapter dap;//Khai báo đối tượng gắn kết DataSource với DataSet
          DataSet ds;//Đối tượng chứa dữ liệu tại local
          public Formdanhsachkhachhang()
          {
               InitializeComponent();
          }

          private void frmKhachhang_Load(object sender, EventArgs e)
          {
               
            con = new SqlConnection();
            
            con.ConnectionString = @"Data Source=DONG_TRAN\DONGTRANSQL;Initial Catalog = QUANLIHOTEL;Persist Security Info = True;User ID=sa;Password=141192";
               //Gọi phương thức Load dự liệu
               LoadDuLieu("Select makh as 'Mã KH', tenkh as 'Tên KH', diachikh as 'Địa chỉ',socmnd as ' Số CMND', sdtkh as 'SĐT'  from Khachhang");

            
            butEdit.Enabled = false;
           
            HienChiTiet(false);
        }
        private void LoadDuLieu(String sql)
        {
            //tạo đối tượng DataSet
            ds = new DataSet();
            //Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng Connection
            dap = new SqlDataAdapter(sql, con);
            //Dùng phương thức Fill của DataAdapter để đổ dữ liệu từ DataSource tới DataSet
            dap.Fill(ds);
            //Gắn dữ liệu từ DataSet lên DataGridView
            dgvSv.DataSource = ds.Tables[0];
            txtSLKH.Text = "Số khách hàng hiện tại là: " + (dgvSv.RowCount ).ToString();
        }
        private void HienChiTiet(Boolean hien)
        {
            txtMaKH.Enabled = hien;
            txtTenKH.Enabled = hien;
            txtDiachi.Enabled = hien;
            txtCMND.Enabled = hien;
            txtSDT.Enabled = hien;
            //Ẩn hiện 2 nút Lưu và Hủy
            butSave.Enabled = hien;
            butHuy.Enabled = hien;
        }
        private void butSearch_Click(object sender, EventArgs e)
        {
            //Cập nhật trên nhãn tiêu đề

            //Cấm nút Sửa và Xóa
            butEdit.Enabled = false;
           
            //Viet cau lenh SQL cho tim kiem
            String sql = "SELECT * FROM Khachhang";
            String dk = "";
            //Tim theo MaSP khac rong
            if (txtTKID.Text.Trim() != "")
            {
                dk += " MaKH like '%" + txtTKID.Text + "%'";
            }
            //kiem tra TenSP va MaSP khac rong
            if (txtTKName.Text.Trim() != "" && dk != "")
            {
                dk += " AND TenKH like N'%" + txtTKName.Text + "%'";
            }
            //Tim kiem theo TenSP khi MaSP la rong
            if (txtTKName.Text.Trim() != "" && dk == "")
            {
                dk += " TenKH like N'%" + txtTKName.Text + "%'";
            }
            //Ket hoi dk
            if (dk != "")
            {
                sql += " WHERE" + dk;
            }
            //Goi phương thức Load dữ liệu kết hợp điều kiện tìm kiếm
            LoadDuLieu(sql);
        }

        private void dgvSv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Hien thi nut sua
            butEdit.Enabled = true;
        
            //Bắt lỗi khi người sử dụng kích linh tinh lên datagrid
            try
            {
                txtMaKH.Text = dgvSv[0, e.RowIndex].Value.ToString();
                txtTenKH.Text = dgvSv[1, e.RowIndex].Value.ToString();
                txtDiachi.Text = dgvSv[2, e.RowIndex].Value.ToString();
                txtCMND.Text = dgvSv[3, e.RowIndex].Value.ToString().Trim();
                txtSDT.Text = dgvSv[4, e.RowIndex].Value.ToString().Trim();
            }
            catch (Exception ex)
            {
            }
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            
            //Hiện gropbox chi tiết
            HienChiTiet(true);
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            string sql = "";
            //Kiếm tra nếu kết nối chưa mở thì thực hiện mở kết nối
            if (con.State != ConnectionState.Open)
                con.Open();
            //Chúng ta sử dụng control ErrorProvider để hiển thị lỗi
            //Kiểm tra tên sản phầm có bị để trống không
            if (txtTenKH.Text.Trim() == "")
            {
                errorChitiet.SetError(txtTenKH, "Bạn không để trống tên khách hàng!");
                return;
            }
            else
            {
                errorChitiet.Clear();
            }
           

            if (txtDiachi.Text.Trim() == "")
            {
                errorChitiet.SetError(txtDiachi, "Bạn không để trống địa chỉ!");
                return;
            }
            else
            {
                errorChitiet.Clear();
            }
           
            //Nếu nút Sửa enable thì thực hiện cập nhật dữ liệu
            if (butEdit.Enabled == true)
            {
                sql = "Update Khachhang SET ";
                sql += "TenKH = N'" + txtTenKH.Text + "',";
                sql += "diachiKH = N'" + txtDiachi.Text + "',";
                sql += "SoCMND = '" + txtCMND.Text + "',";
                sql += "SDTKH = '" + txtSDT.Text+"'";
                sql += "Where MaKH = '" + txtMaKH.Text+"'";
            }
           
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            //Cap nhat lai DataGrid
            sql = "Select * from KHachhang";
            LoadDuLieu(sql);
            //dong ket noi
            con.Close();
            //Ẩn hiện các nút phù hợp chức năng
           
            HienChiTiet(false);         
            butEdit.Enabled = false;
           
        }

        private void butHuy_Click(object sender, EventArgs e)
        {
            //Thiết lập lại các nút như ban đầu
            butEdit.Enabled = false;
           
            //xoa trang
            XoaTrangChiTiet();
            //Cam nhap
            HienChiTiet(false);
        }
        private void XoaTrangChiTiet()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiachi.Text = "";
            txtSDT.Text = "";
            txtCMND.Text = "";
        }
          private void guna2ControlBox1_Click(object sender, EventArgs e)
          {
               this.Close();
               Formmainmenu.instance.Show();
          }
     }
}
