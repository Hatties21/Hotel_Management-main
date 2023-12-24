using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace testsql
{
     public partial class FormQLLP : Form
     {
          public FormQLLP()
          {
               InitializeComponent();
          }
          SqlConnection con = new SqlConnection("Data Source=DONG_TRAN\\DONGTRANSQL;Initial Catalog = QUANLIHOTEL;Persist Security Info = True;User ID=sa;Password=141192");
          SqlCommand cmd = new SqlCommand();
          DataTable table1 = new DataTable();
          CultureInfo cultureInfo = new CultureInfo("vi-vn");
          public void fillLoaiPhong()
          {
               try
               {
                    DataTable DT = (DataTable)dtgvLoaiPhong.DataSource;
                    if (DT != null)
                         DT.Clear();
                    con.Open();
                    string query2 = "SELECT maloaiphong as 'Mã Loại phòng', tenloaiphong as 'Tên Loại phòng', convert(int,gia) as 'Giá' from loaiphong";
                    SqlCommand sqlDa = new SqlCommand(query2, con);
                    sqlDa.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(query2, con);
                    adapter.Fill(table1);
                    dtgvLoaiPhong.DataSource = table1;
                    dtgvLoaiPhong.Columns[2].DefaultCellStyle.Format = "c0";
                    dtgvLoaiPhong.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vi-vn");
                    string query = "SELECT count(*) FROM loaiphong";
                    cmd = new SqlCommand(query, con);
                    int sldv = (int)cmd.ExecuteScalar();
                    txtSLLP.Text = sldv.ToString();
                    con.Close();
                    clear();
               }
               catch (Exception ex)
               {
                    //MessageBox.Show("Đã có lỗi xẩy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show(ex.Message);
                    con.Close();
               }
          }
          public void show(int a)
          {
               if (a == 0)
               {
                    //butThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
               }
               else
               {
                    //butThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
               }
          }
          public void clear()
          {
               txtTenP.Text = "";
               txtMP.Text = "";
               txtGia.Text = "";
               txtFind.Text = "";
          }
          private void btnSua_Click(object sender, EventArgs e)
          {
               try
               {
                    con.Open();
                    string query = "UPDATE loaiphong SET tenloaiphong = N'" + txtTenP.Text + "', gia = '" + Convert.ToString(txtGia.Text) + "' WHERE maloaiphong = '" + txtMP.Text + "'";
                    cmd = new SqlCommand(query, con);
                    if (MessageBox.Show("Bạn có muốn sửa loại phòng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                         cmd.ExecuteNonQuery();
                         MessageBox.Show("Cập nhật loại phòng thành công!");
                    }
                    con.Close();
                    fillLoaiPhong();
               }
               catch
               {
                    MessageBox.Show("Đã xẩy ra lỗi!");
                    //MessageBox.Show(ex.Message);
                    con.Close();
               }
          }
          private void FormQLLP_Load(object sender, EventArgs e)
          {
               show(0);
               fillLoaiPhong();
          }
          private void dtgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
          {
               show(1);
               int index = e.RowIndex;
               if (index >= 0)
               {
                    txtMP.Text = dtgvLoaiPhong.Rows[index].Cells[0].Value.ToString();
                    txtTenP.Text = dtgvLoaiPhong.Rows[index].Cells[1].Value.ToString();
                    txtGia.Text = dtgvLoaiPhong.Rows[index].Cells[2].Value.ToString();
               }
          }
          private void btnHuy_Click(object sender, EventArgs e)
          {
               show(0);
               fillLoaiPhong();
          }
          private void txtFind_TextChanged(object sender, EventArgs e)
          {
               try
               {
                    con.Open();
                    DataTable DT = (DataTable)dtgvLoaiPhong.DataSource;
                    if (DT != null)
                         DT.Clear();
                    string query = "select  maloaiphong as 'Mã Loại phòng', tenloaiphong as 'Tên Loại phòng', convert(int,gia) as 'Giá' from loaiphong where tenloaiphong like N'%" + txtFind.Text + "%'";
                    SqlCommand sqlDa = new SqlCommand(query, con);
                    sqlDa.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    adapter.Fill(table1);
                    dtgvLoaiPhong.DataSource = table1;
                    con.Close();
               }
               catch
               {
                    MessageBox.Show("Đã xẩy ra lỗi!");
                    con.Close();
               }
          }
          public bool checkNull()
          {
               if (string.IsNullOrEmpty(txtMP.Text))
               {
                    MessageBox.Show("Hãy nhập mã loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMP.Focus();
                    return false;
               }
               if (string.IsNullOrEmpty(txtTenP.Text))
               {
                    MessageBox.Show("Hãy nhập tên loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenP.Focus();
                    return false;
               }
               if (string.IsNullOrEmpty(txtGia.Text))
               {
                    MessageBox.Show("Hãy nhập giá loại phòng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGia.Focus();
                    return false;
               }
               return true;
          }
          private void butThem_Click(object sender, EventArgs e)
          {
               if (checkNull())
               {
                    try
                    {
                         con.Open();
                         string query = "INSERT INTO LoaiPHONG(MALOAIPHONG,TENLOAIPHONG,GIA) VALUES ('" + txtMP.Text + "',N'" + txtTenP.Text + "','" + txtGia.Text + "')";
                         SqlCommand sqlDa = new SqlCommand(query, con);
                         sqlDa.ExecuteNonQuery();
                         con.Close();
                         MessageBox.Show("Thêm dịch vụ thành công!");
                         fillLoaiPhong();
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("Mã dịch vụ không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         //MessageBox.Show(ex.Message);
                         txtMP.Focus();
                         con.Close();
                    }
               }
          }
          private void btnXoa_Click(object sender, EventArgs e)
          {
               try
               {
                    con.Open();
                    if (MessageBox.Show("Bạn có muốn xóa loại phòng này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                         SqlCommand sqlDa = new SqlCommand("DELETE from LOAIPHONG WHERE MALOAIPHONG ='" + txtMP.Text + "'", con);
                         sqlDa.ExecuteNonQuery();
                         MessageBox.Show("Bạn đã xóa thành công!");
                    }
                    con.Close();
               }
               catch
               {
                    MessageBox.Show("Dã xẩy ra lỗi!");
                    con.Close();
               }
               fillLoaiPhong();
          }
          private void bunifuImageButton1_Click(object sender, EventArgs e)
          {

          }
          private void bunifuImageButton1_Click_1(object sender, EventArgs e)
          {
               this.Close();
          }
     }
}
