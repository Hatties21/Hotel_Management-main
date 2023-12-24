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
using System.Globalization;
using testsql.DAO;

namespace testsql
{
     public partial class Formdichvuthanhtoan1 : Form
     {

          #region Constructor & Properties
          private readonly Forminhoadon forminhoadon = new Forminhoadon();
          SqlConnection con;
          SqlCommand cmd;
          SqlDataAdapter dap;
          DataSet ds;
          DataRelation myDataRelation;
          BindingSource masterBindingSource = new BindingSource();
          BindingSource detailsBindingSource = new BindingSource();
          string sql = "";
          string sql1 = "";
          string mathuephong = "";
          CultureInfo cultureInfo = new CultureInfo("vi-vn");
          public Formdichvuthanhtoan1()
          {
               InitializeComponent();
          }
          private void Form1_Load(object sender, EventArgs e)
          {
               BTNINHOADON.Enabled = false;
               con = new SqlConnection();
               //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
               //Gọi Application.StartupPath để lấy đường dẫn tới thư mục chứa file chạy chương trình 
               con.ConnectionString = @"Data Source=DONG_TRAN\DONGTRANSQL;Initial Catalog = QUANLIHOTEL;Persist Security Info = True;User ID=sa;Password=141192";
               //Gọi phương thức Load dự liệu
               con.Open();
               //dgvctphong.Columns[2].DefaultCellStyle.Format = "c0";
               //dgvctphong.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vi-vn");
               //dgvdichvu.Columns[2].DefaultCellStyle.Format = "c0";
               //dgvdichvu.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vi-vn");
               dgvctphong.DataSource = masterBindingSource;
               dgvdichvu.DataSource = detailsBindingSource;
               loadcombobox();
          }
          private void LoadDuLieu(string sql, string sql1)
          {
               ds = new DataSet();
               ds.Locale = System.Globalization.CultureInfo.InvariantCulture;
               SqlDataAdapter masterDataAdapter = new
               SqlDataAdapter(sql, con);
               masterDataAdapter.Fill(ds, "ctphong");
               SqlDataAdapter detailsDataAdapter = new
               SqlDataAdapter(sql1, con);
               detailsDataAdapter.Fill(ds, "phieudv");
               DataRelation relation = new DataRelation("phong",
               ds.Tables["ctphong"].Columns["Mã phòng"],
               ds.Tables["phieudv"].Columns["Mã phòng"]);
               ds.Relations.Add(relation);
               masterBindingSource.DataSource = ds;
               masterBindingSource.DataMember = "ctphong";
               detailsBindingSource.DataSource = masterBindingSource;
               detailsBindingSource.DataMember = "phong";
               dgvctphong.Columns[3].DefaultCellStyle.Format = "c0";
               dgvctphong.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vi-vn");
               dgvdichvu.Columns[3].DefaultCellStyle.Format = "c0";
               dgvdichvu.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vi-vn");
          }
          void loadcombobox()
          {
               cbmathue.DataSource = null;
               cbmathue.Items.Clear();
               cmd = new SqlCommand("select distinct mathue from ctphong n where MAPHONG not in ( select MAPHONG from HOADON where MATHUE= n.Mathue)", con);
               var dr = cmd.ExecuteReader();
               var dt = new DataTable();
               dt.Load(dr);
               dr.Dispose();
               cbmathue.DisplayMember = "mathue";
               cbmathue.DataSource = dt;
          }
          void loadlistbox()
          {
               cmd = new SqlCommand("select tenphong from phong where maphong in (select maphong from ctphong where mathue = '" + cbmathue.Text + "' and maphong not in (select maphong from hoadon where mathue = '" + cbmathue.Text + "'))", con);
               SqlDataAdapter da = new SqlDataAdapter(cmd);
               DataTable kq = new DataTable();
               da.Fill(kq);
               lbmaphong.DataSource = kq;
               lbmaphong.DisplayMember = "tenphong";
               //lbmaphong.
          }
          private void BTDONG_Click(object sender, EventArgs e)
          {
               con.Close();
               this.Close();
               Formmainmenu.instance.Show();
               Formmainmenu.instance.LoadAll();
          }
          private void cbmathue_SelectedIndexChanged(object sender, EventArgs e)
          {
               lbmaphong.DataSource = null;
               lbmaphong.Items.Clear();
               loadlistbox();
          }
          private void lbmaphong_SelectedIndexChanged(object sender, EventArgs e)
          {
               string maphong = "";
               for (int i = 0; i < lbmaphong.SelectedItems.Count; i++)
               {
                    DataRowView ht = (DataRowView)lbmaphong.SelectedItems[i];
                    maphong += "'" + ht.Row["tenphong"].ToString() + "',";
                    if (i == lbmaphong.SelectedItems.Count - 1)
                    {
                         maphong += "'" + ht.Row["tenphong"].ToString() + "'";
                    }
               }
               sql = "select phong.maphong as 'Mã phòng',phong.tenphong as 'Tên phòng',loaiphong.tenloaiphong as 'Loại',loaiphong.gia as 'Giá',(CASE DATEDIFF(DAY,PHIEUTHUE.NGAYTHUE,GETDATE()) when 0 then 1 end) as 'Số ngày' from phong,loaiphong,phieuthue where phong.maloaiphong = loaiphong.maloaiphong and phong.tenphong in (" + maphong + ") and  phieuthue.mathue = '" + cbmathue.Text + "'";
               sql1 = "SELECT MAPHONG as 'Mã phòng',TENDV as 'Dịch vụ', SUM(SOLUONG) AS 'Số lượng', DONGIA AS ' Đơn Giá' FROM PHIEUSDDV, CTPHIEUSDDV, DICHVU WHERE PHIEUSDDV.MAPHIEU = CTPHIEUSDDV.MAPHIEU AND CTPHIEUSDDV.MADV = DICHVU.MADV and maphong in (select maphong from phong where tenphong in (" + maphong + ")) and phieusddv.mathue = '" + cbmathue.Text + "' GROUP BY MAPHONG,TENDV,DONGIA";
          }
       
          private void BTTHANHTOAN_Click(object sender, EventArgs e)
          {
               mathuephong = cbmathue.Text;
               try
               {
                    BTNINHOADON.Enabled = true;
                    int tieno, tiendv, tienhd;
                    tieno = 0;
                    tiendv = 0;
                    tienhd = 0;
                    if (txtManv.Text.Trim() == "")
                    {
                         errChiTiet.SetError(txtManv, "Bạn không để trống mã nhân viên!");
                         return;
                    }
                    else
                    {
                         LoadDuLieu(sql, sql1);
                         string maphong = "";
                         string mahd = "0";
                         sql = "SELECT COUNT(*) FROM HOADON";
                         cmd = new SqlCommand(sql, con);
                         mahd += ((int)cmd.ExecuteScalar() + 1).ToString();
                         for (int i = 0; i < lbmaphong.SelectedItems.Count; i++)
                         {
                              DataRowView ht = (DataRowView)lbmaphong.SelectedItems[i];
                              maphong = ht.Row["tenphong"].ToString();
                              sql = "SELECT maphong from phong where tenphong ='" + maphong + "'";
                              cmd = new SqlCommand(sql, con);
                              maphong = (string)cmd.ExecuteScalar();
                              sql = "SELECT dbo.TINHTIENDICHVU('" + cbmathue.Text + "', '" + maphong + "')";
                              cmd = new SqlCommand(sql, con);
                              tiendv += (int)cmd.ExecuteScalar();
                              sql = "SELECT dbo.TIENO('" + cbmathue.Text + "', '" + maphong + "')";
                              cmd = new SqlCommand(sql, con);
                              tieno += (int)cmd.ExecuteScalar();
                              sql = "EXEC HD '" + mahd + "','" + cbmathue.Text + "', '" + maphong + "'," + tiendv + ",'" + txtManv.Text + "'";
                              cmd = new SqlCommand(sql, con);
                              cmd.ExecuteNonQuery();
                         }
                         TXTTONGTIENDICHVU.Text = tiendv.ToString() + "VND";
                         TXTTONGTIENPHONG.Text =  tieno.ToString() + "VND";
                         tienhd = tiendv + tieno;
                         txttongtien.Text = tienhd.ToString() + "VND";
                         loadlistbox();
                         loadcombobox();
                    }
               }
               catch(Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
          }
          //btn in hoa don
          private void guna2Button1_Click(object sender, EventArgs e)
          {
               this.Close();
               forminhoadon.SetPrintBill(mathuephong);
               forminhoadon.Show();
          }
          #endregion
     }
}
