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
     public partial class Formdanhsachnhanvien : Form
     {
          SqlConnection con;
          SqlCommand cmd;
          SqlDataAdapter dap;
          DataSet ds;
          public Formdanhsachnhanvien()
          {
               InitializeComponent();
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
               txtSLNV.Text = "Số lượng nhân viên hiện tại: " + (dgvSv.RowCount - 1).ToString();
               dgvSv.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
          }
          private void HienChiTiet(Boolean hien)
          {
               txtMaNV.Enabled = hien;
               txtTenNV.Enabled = hien;
               dtpNS.Enabled = hien;
               txtGioitinh.Enabled = hien;
               txtSDT.Enabled = hien;
               txtDiachi.Enabled = hien;
               txtLuong.Enabled = hien;
               txtChucvu.Enabled = hien;
               //Ẩn hiện 2 nút Lưu và Hủy
               butSave.Enabled = hien;
               butHuy.Enabled = hien;
          }

          private void butAdd_Click(object sender, EventArgs e)
          {
               //Xoa trang GroupBox chi tiết sản phẩm
               XoaTrangChiTiet();
               //Cam nut sua xoa
               butEdit.Enabled = false;
               butDelete.Enabled = false;
               //Hiện GroupBox Chi tiết
               HienChiTiet(true);
          }

          private void butSearch_Click(object sender, EventArgs e)
          {
               
          }



          private void butEdit_Click(object sender, EventArgs e)
          {
              
          }

          private void butDelete_Click(object sender, EventArgs e)
          {
               
          }

          private void butSave_Click(object sender, EventArgs e)
          {
               
          }

          private void butHuy_Click(object sender, EventArgs e)
          {
              
          }
          private void XoaTrangChiTiet()
          {
               txtMaNV.Text = "";
               txtTenNV.Text = "";
               dtpNS.Value = DateTime.Now;
               txtGioitinh.Text = "";
               txtSDT.Text = "";
               txtDiachi.Text = "";
               txtLuong.Text = "";
               txtChucvu.Text = "";

          }

          private void Form3_Load_1(object sender, EventArgs e)
          {
               con = new SqlConnection();
               //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
               //Gọi Application.StartupPath để lấy đường dẫn tới thư mục chứa file chạy chương trình 
               con.ConnectionString = @"Data Source=DONG_TRAN\DONGTRANSQL;Initial Catalog = QUANLIHOTEL;Persist Security Info = True;User ID=sa;Password=141192";
               //Gọi phương thức Load dự liệu
               LoadDuLieu("Select manv as N'Mã NV', tennv as 'Tên',ngaysinh as 'Ngày sinh', gioitinh as 'Giới tính', SDTNV as 'SĐT', diachinv as 'Địa chỉ', luong as 'Lương', bophan as 'Bộ phận' from Nhanvien");

               //Khi Form mới Load lên thì ẩn các bút Sửa và Xóa
               butEdit.Enabled = false;
               butDelete.Enabled = false;
               //An groupbox chi tiet
               HienChiTiet(false);
          }

          private void dgvSv_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {
               //Hien thi nut sua
               butEdit.Enabled = true;
               butDelete.Enabled = true;
               butAdd.Enabled = false;
               //Bắt lỗi khi người sử dụng kích linh tinh lên datagrid
               try
               {
                    txtMaNV.Text = dgvSv[0, e.RowIndex].Value.ToString();
                    txtTenNV.Text = dgvSv[1, e.RowIndex].Value.ToString();
                    dtpNS.Value = Convert.ToDateTime(dgvSv[2, e.RowIndex].Value.ToString());
                    txtGioitinh.Text = dgvSv[3, e.RowIndex].Value.ToString();
                    txtSDT.Text = dgvSv[4, e.RowIndex].Value.ToString();
                    txtDiachi.Text = dgvSv[5, e.RowIndex].Value.ToString();
                    txtLuong.Text = dgvSv[6, e.RowIndex].Value.ToString();
                    txtChucvu.Text = dgvSv[7, e.RowIndex].Value.ToString();
               }
               catch (Exception ex)
               {
               }
          }
          private void guna2ControlBox4_Click(object sender, EventArgs e)
          {
               this.Close();
               Formmainmenu.instance.Show();
          }

          private void butEdit_Click_1(object sender, EventArgs e)
          {
               butAdd.Enabled = false;
               butDelete.Enabled = false;
               //Hiện gropbox chi tiết
               HienChiTiet(true);
          }

          private void butDelete_Click_1(object sender, EventArgs e)
          {
               if (MessageBox.Show("Bạn có chắc chắn xóa mã nhân viên " + txtMaNV.Text + " không? Nếu có ấn nút Lưu, không thì ấn nút Hủy", "Xóa sản phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
               {

                    butAdd.Enabled = false;
                    butEdit.Enabled = false;
                    //Hiện gropbox chi tiết
                    HienChiTiet(true);
               }
          }

          private void butSave_Click_1(object sender, EventArgs e)
          {
               string sql = "";
               //Kiếm tra nếu kết nối chưa mở thì thực hiện mở kết nối
               if (con.State != ConnectionState.Open)
                    con.Open();
               //Chúng ta sử dụng control ErrorProvider để hiển thị lỗi
               //Kiểm tra tên sản phầm có bị để trống không
               if (txtTenNV.Text.Trim() == "")
               {
                    errorChitiet.SetError(txtTenNV, "Bạn không để trống tên nhân viên!");
                    return;
               }
               else
               {
                    errorChitiet.Clear();
               }
               //Kiểm tra ngày sản xuất, lỗi nếu người sử dụng nhập vào ngày sản xuất lớn hơn ngày hiện tại
               if (dtpNS.Value > DateTime.Now)
               {
                    errorChitiet.SetError(dtpNS, "Ngày sinh không hợp lệ!");
                    return;
               }
               else
               {
                    errorChitiet.Clear();
               }

               if (txtGioitinh.Text.Trim() == "")
               {
                    errorChitiet.SetError(txtGioitinh, "Bạn không để trống giới tính!");
                    return;
               }
               else
               {
                    errorChitiet.Clear();
               }
               if (txtSDT.Text.Trim() == "")
               {
                    errorChitiet.SetError(txtTenNV, "Bạn không để trống SĐT nhân viên!");
                    return;
               }
               else
               {
                    errorChitiet.Clear();
               }
               if (txtDiachi.Text.Trim() == "")
               {
                    errorChitiet.SetError(txtTenNV, "Bạn không để trống địa chỉ!");
                    return;
               }
               else
               {
                    errorChitiet.Clear();
               }
               if (txtLuong.Text.Trim() == "")
               {
                    errorChitiet.SetError(txtTenNV, "Bạn không để trống lương nhân viên!");
                    return;
               }
               else
               {
                    errorChitiet.Clear();
               }
               if (txtChucvu.Text.Trim() == "")
               {
                    errorChitiet.SetError(txtTenNV, "Bạn không để trống chức vụ nhân viên!");
                    return;
               }
               else
               {
                    errorChitiet.Clear();
               }

               //Nếu nút Thêm enable thì thực hiện thêm mới 
               //Dùng ký tự N' trước mỗi giá trị kiểu text để insert giá trị có dấu tiếng việt vào CSDL được đúng 
               if (butAdd.Enabled == true)
               {
                    //Kiểm tra xem ô nhập MaSP có bị trống không 
                    if (txtMaNV.Text.Trim() == "")
                    {
                         errorChitiet.SetError(txtMaNV, "Bạn không để trống mã sinh viên!");
                         return;
                    }
                    else
                    {
                         //Kiểm tra xem mã sản phẩm đã tồn tại chưa đẻ tránh việc insert mới bị lỗi 
                         sql = "Select Count(*) From nhanvien Where Manv =" + txtMaNV.Text;
                         cmd = new SqlCommand(sql, con);
                         int val = (int)cmd.ExecuteScalar();
                         if (val > 0)
                         {
                              errorChitiet.SetError(txtMaNV, "Mã nhân viên trùng trong cơ sở dữ liệu");
                              return;
                         }
                         errorChitiet.Clear();
                    }
                    //Insert vao CSDL
                    sql = "INSERT INTO nhanvien VALUES ('";
                    sql += txtMaNV.Text + "',N'" + txtTenNV.Text + "','" + dtpNS.Value + "',N'" + txtGioitinh.Text + "','" + txtSDT.Text + "',N'" + txtDiachi.Text + "','" + txtLuong.Text + "',N'" + txtChucvu.Text + "')";
               }
               //Nếu nút Sửa enable thì thực hiện cập nhật dữ liệu
               if (butEdit.Enabled == true)
               {
                    sql = "Update nhanvien SET ";
                    sql += "TenNV = N'" + txtTenNV.Text + "',";
                    sql += "NgaySinh = '" + dtpNS.Value.Date + "',";
                    sql += "gioitinh = N'" + txtGioitinh.Text + "',";
                    sql += "SDTNV = '" + txtSDT.Text + "',";
                    sql += "DIACHINV = N'" + txtDiachi.Text + "',";
                    sql += "LUONG = '" + txtLuong.Text + "',";
                    sql += "bophan = N'" + txtChucvu.Text + "'";
                    sql += "Where MaNV = '" + txtMaNV.Text+"'";
               }
               //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
               if (butDelete.Enabled == true)
               {
                    sql = "Delete From Nhanvien Where MaNV =" + txtMaNV.Text;
               }
               //Thuc thi cau lenh sql
               cmd = new SqlCommand(sql, con);
               cmd.ExecuteNonQuery();
               //Cap nhat lai DataGrid
               sql = "Select * from NHANVIEN";
               LoadDuLieu(sql);
               //dong ket noi
               con.Close();
               //Ẩn hiện các nút phù hợp chức năng
               txtSLNV.Text = (dgvSv.RowCount - 1).ToString();
               HienChiTiet(false);
               butAdd.Enabled = true;
               butEdit.Enabled = false;
               butDelete.Enabled = false;
          }

          private void butHuy_Click_1(object sender, EventArgs e)
          {
               butEdit.Enabled = false;
               butDelete.Enabled = false;
               butAdd.Enabled = true;
               //xoa trang
               XoaTrangChiTiet();
               //Cam nhap
               HienChiTiet(false);
          }

          private void butSearch_Click_1(object sender, EventArgs e)
          {
               //Cập nhật trên nhãn tiêu đề

               //Cấm nút Sửa và Xóa
               butEdit.Enabled = false;
               butDelete.Enabled = false;
               //Viet cau lenh SQL cho tim kiem
               String sql = "SELECT * FROM Nhanvien";
               String dk = "";
               //Tim theo MaSP khac rong
               if (txtTKID.Text.Trim() != "")
               {
                    dk += " MaNV like '%" + txtTKID.Text + "%'";
               }
               //kiem tra TenSP va MaSP khac rong
               if (txtTKName.Text.Trim() != "" && dk != "")
               {
                    dk += " AND TenNV like N'%" + txtTKName.Text + "%'";
               }
               //Tim kiem theo TenSP khi MaSP la rong
               if (txtTKName.Text.Trim() != "" && dk == "")
               {
                    dk += " TenNV like N'%" + txtTKName.Text + "%'";
               }
               //Ket hoi dk
               if (dk != "")
               {
                    sql += " WHERE" + dk;
               }
               //Goi phương thức Load dữ liệu kết hợp điều kiện tìm kiếm
               LoadDuLieu(sql);
          }

          private void bunifuImageButton1_Click(object sender, EventArgs e)
          {

          }
     }
}

