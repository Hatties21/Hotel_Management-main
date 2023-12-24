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
     public partial class formQLDV : Form
     {
          public formQLDV()
          {
               InitializeComponent();
          }
          CultureInfo cultureInfo = new CultureInfo("vi-vn");
          SqlConnection con = new SqlConnection("Data Source=DONG_TRAN\\DONGTRANSQL;Initial Catalog = QUANLIHOTEL;Persist Security Info = True;User ID=sa;Password=141192");
          SqlCommand cmd = new SqlCommand();
          DataTable table1 = new DataTable();
          public void fillDichvu()
          {
               try
               {
                    DataTable DT = (DataTable)dtgvDV.DataSource;
                    if (DT != null)
                         DT.Clear();
                    con.Open();
                    string query2 = "SELECT madv as N'Mã dịch vụ', tendv as N'Tên dịch vụ', convert(int,dongiahientai) as N'Đơn giá' FROM DICHVU";
                    SqlCommand sqlDa = new SqlCommand(query2, con);
                    sqlDa.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(query2, con);
                    adapter.Fill(table1);
                    dtgvDV.DataSource = table1;
                    dtgvDV.Columns[2].DefaultCellStyle.Format = "c0";
                    dtgvDV.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vi-vn");
                    string query = "SELECT count(*) FROM dichvu";
                    cmd = new SqlCommand(query, con);
                    int sldv = (int)cmd.ExecuteScalar();
                    txtSLDV.Text = sldv.ToString();
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
          public void clear()
          {
               txtMaDV.Text = "";
               txtDongia.Text = "";
               txtTenDV.Text = "";
               txtFind.Text = "";
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
          public bool checkNull()
          {
               if (string.IsNullOrEmpty(txtMaDV.Text))
               {
                    MessageBox.Show("Hãy nhập mã dịch vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaDV.Focus();
                    return false;
               }
               if (string.IsNullOrEmpty(txtTenDV.Text))
               {
                    MessageBox.Show("Hãy nhập tên dịch vụ này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenDV.Focus();
                    return false;
               }
               if (string.IsNullOrEmpty(txtDongia.Text))
               {
                    MessageBox.Show("Hãy nhập đơn giá dịch vụ này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDongia.Focus();
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
                         string query = "INSERT INTO DICHVU(MADV,TENDV,DONGIAHIENTAI) VALUES ('" + txtMaDV.Text + "',N'" + txtTenDV.Text + "','" + txtDongia.Text + "')";
                         SqlCommand sqlDa = new SqlCommand(query, con);
                         sqlDa.ExecuteNonQuery();
                         con.Close();
                         MessageBox.Show("Thêm dịch vụ thành công!");
                         fillDichvu();

                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("Mã dịch vụ không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         //MessageBox.Show(ex.Message);
                         txtMaDV.Focus();
                         con.Close();
                    }
               }
          }
          private void btnSua_Click(object sender, EventArgs e)
          {
               try
               {
                    con.Open();
                    string query = "UPDATE DICHVU SET TENDV = N'" + txtTenDV.Text + "', DONGIAHIENTAI = '" + Convert.ToString(txtDongia.Text) + "' WHERE MADV = '" + txtMaDV.Text + "'";
                    cmd = new SqlCommand(query, con);
                    if (MessageBox.Show("Bạn có muốn sửa thông tin dịch vụ này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                         cmd.ExecuteNonQuery();
                         MessageBox.Show("Cập nhật dịch vụ thành công!");
                    }
                    con.Close();
                    fillDichvu();
               }
               catch
               {
                    MessageBox.Show("Đã xẩy ra lỗi!");
                    //MessageBox.Show(ex.Message);
                    con.Close();
               }
          }
          private void btnXoa_Click(object sender, EventArgs e)
          {
               try
               {
                    con.Open();
                    if (MessageBox.Show("Bạn có muốn xóa dịch vụ này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                         SqlCommand sqlDa = new SqlCommand("DELETE from dichvu WHERE madv ='" + txtMaDV.Text + "'", con);
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
               fillDichvu();
          }

          private void dtgvDV_CellClick(object sender, DataGridViewCellEventArgs e)
          {
               show(1);
               int index = e.RowIndex;
               if (index >= 0)
               {
                    txtMaDV.Text = dtgvDV.Rows[index].Cells[0].Value.ToString();
                    txtTenDV.Text = dtgvDV.Rows[index].Cells[1].Value.ToString();
                    txtDongia.Text = dtgvDV.Rows[index].Cells[2].Value.ToString();
               }
          }

          private void formQLDV_Load(object sender, EventArgs e)
          {
               show(0);
               fillDichvu();

          }

          private void txtFind_TextChanged(object sender, EventArgs e)
          {
               string query = "";
               if (cbChon.Text == "Mã dịch vụ")
               {
                    query = "select madv as N'Mã dịch vụ', tendv as N'Tên dịch vụ', convert(int,dongiahientai) as N'Đơn giá' from dichvu where madv like N'%" + txtFind.Text + "%'";
               }
               else if (cbChon.Text == "Tên dịch vụ")
               {
                    query = "select madv as N'Mã dịch vụ', tendv as N'Tên dịch vụ', convert(int,dongiahientai) as N'Đơn giá' from dichvu where tendv like N'%" + txtFind.Text + "%'";
               }
               if (txtFind.Text != "")
               {
                    try
                    {
                         DataTable DT = (DataTable)dtgvDV.DataSource;
                         if (DT != null)
                              DT.Clear();
                         con.Open();
                         SqlCommand sqlDa = new SqlCommand(query, con);
                         sqlDa.ExecuteNonQuery();
                         SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                         adapter.Fill(table1);
                         dtgvDV.DataSource = table1;
                         con.Close();
                    }
                    catch
                    {
                         MessageBox.Show("Đã xẩy ra lỗi!");
                         con.Close();
                    }
               }
               else fillDichvu();
          }
          private void btnHuy_Click(object sender, EventArgs e)
          {
               show(0);
               fillDichvu();
          }
          private void bunifuImageButton1_Click(object sender, EventArgs e)
          {
               this.Close();
          }
     }

}
