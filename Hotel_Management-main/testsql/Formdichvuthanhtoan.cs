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
using testsql.DAO;
using System.Globalization;

namespace testsql
{
     public partial class Formdichvuthanhtoan : Form
     {
          public Formdichvuthanhtoan()
          {
               InitializeComponent();
          }
          SqlConnection con = new SqlConnection("Data Source=DONG_TRAN\\DONGTRANSQL;Initial Catalog = QUANLIHOTEL;Persist Security Info = True;User ID=sa;Password=141192");
          SqlCommand cmd = new SqlCommand();
          DataTable table1 = new DataTable();

          public void fillDichvu()
          {
               DataTable DT = (DataTable)dtgvDichvu.DataSource;
               if (DT != null)
                    DT.Clear();
               try
               {
                    con.Open();
                    string query = "Select dbo.CTPHIEUSDDV.MAPHIEU, dbo.CTPHIEUSDDV.madv as N'Mã dịch vụ', tendv as N'Tên dịch vụ', soluong as 'Số lượng', convert(int,dongiahientai) as 'Giá hiện tại', ngaysudung as N'Ngày sử dụng' from dichvu,ctphieusddv,dbo.PHIEUSDDV WHERE dbo.DICHVU.MADV = dbo.CTPHIEUSDDV.MADV AND dbo.PHIEUSDDV.MAPHIEU = dbo.CTPHIEUSDDV.MAPHIEU AND dbo.PHIEUSDDV.MAPHONG = '" + Formtrangthaiphong.maphong + "' and mathue in (select mathue from phieuthue where makh in (select makh from khachhang where tenkh = N'" + txtTenKH.Text + "'))";
                    SqlCommand cmd1 = new SqlCommand(query, con);
                    cmd1.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    adapter.Fill(table1);
                    dtgvDichvu.DataSource = table1;
                    dtgvDichvu.Columns[0].Visible = false;
                    dtgvDichvu.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                    btnXoa.Enabled = false;
                    TinhTien();
                    con.Close();
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
                    con.Close();
               }
          }
          int tien;
          public void TinhTien()
          {
               tien = 0;
               for(int i = 0; i< dtgvDichvu.RowCount; i++)
               {
                    tien += Convert.ToInt32(dtgvDichvu[3, i].Value.ToString()) * Convert.ToInt32(dtgvDichvu[4, i].Value);
               }
               txtTongTien.Text = tien.ToString() + "  VNĐ";
          }
          private void Formdichvuthanhtoan_Load(object sender, EventArgs e)
          {
               // TODO: This line of code loads data into the 'qLKSDataSet2.KHACHHANG' table. You can move, or remove it, as needed.
               //this.kHACHHANGTableAdapter.Fill(this.qLKSDataSet2.KHACHHANG);
               // TODO: This line of code loads data into the 'qLKSDataSet.DICHVU' table. You can move, or remove it, as needed.
               //this.dICHVUTableAdapter.Fill(this.qLKSDataSet.DICHVU);
               labelTenPhong.Text = Formtrangthaiphong.tenphong;
               txtTenKH.Text = Formtrangthaiphong.tenKH;
               fillDichvu();
               loaddichvu();
               btnXoa.Enabled = false;
               dtgvDichvu.AutoGenerateColumns = true;
          }
          public void loaddichvu()
          {
               con.Open();
               string querry = "select TENDV from DICHVU";
               DataTable data = DataProvider.Instance.ExecuteQuery(querry);
               TXTDICHVU.DataSource = data;
               TXTDICHVU.DisplayMember = "TENDV";
               con.Close();
          }
          private void BTDONG_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          private void guna2Button1_Click(object sender, EventArgs e)
          {
               try
               {
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "goidichvu";
                    cmd.Parameters.Add(new SqlParameter("@tenkh", txtTenKH.Text));
                    cmd.Parameters.Add(new SqlParameter("@maphong", Formtrangthaiphong.maphong));
                    cmd.Parameters.Add(new SqlParameter("@tendichvu", TXTDICHVU.Text));
                    cmd.Parameters.Add(new SqlParameter("@soluong", Convert.ToInt32(TXTSOLUONG.Text)));
                    cmd.Parameters.Add(new SqlParameter("@ngaysudung", ngaysd.Value));
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    con.Close();

               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
                    cmd.Parameters.Clear();
                    con.Close();
               }
              
               fillDichvu();
               this.Refresh();
          }

          private void btnXoa_Click(object sender, EventArgs e)
          {
               int index = this.dtgvDichvu.CurrentCell.RowIndex;
               try
               {
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "XoaDVDagoi";
                    cmd.Parameters.Add(new SqlParameter("@maphieu", dtgvDichvu.Rows[index].Cells[0].Value.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@madv", dtgvDichvu.Rows[index].Cells[1].Value.ToString()));

                    if (MessageBox.Show("Bạn có muốn xóa dịch vụ đã gọi này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                         cmd.ExecuteNonQuery();
                    }
                    cmd.Parameters.Clear();
                    con.Close();

               }

               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
                    cmd.Parameters.Clear();
                    con.Close();
               }
               fillDichvu();
          }

          private void dtgvDichvu_CellClick(object sender, DataGridViewCellEventArgs e)
          {
               btnXoa.Enabled = true;
          }
     }
}


