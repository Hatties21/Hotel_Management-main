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
using Microsoft.Reporting.WinForms;
using testsql.DAO;

namespace testsql
{
     public partial class Formdatphong1 : Form
     {
          #region Constructor & Properties
          private readonly Forminphieuthue forminphieuthue = new Forminphieuthue();
          //public int ttphong;
          public string abc;
          //Khai báo các biến toàn cục
          SqlConnection con;//Khai báo đối tượng thực hiện kết nối đến cơ sở dữ liệu
          SqlCommand cmd;//Khai báo đối tượng thực hiện các câu lệnh truy vấn
          SqlDataAdapter dap;//Khai báo đối tượng gắn kết DataSource với DataSet
          DataSet ds;//Đối tượng chứa dữ liệu tại local
          string mathue="";
          public Formdatphong1()
          {
               InitializeComponent();
          }
          private void Form1_Load(object sender, EventArgs e)
          {
               
               string sql = "";
               con = new SqlConnection();
               con.ConnectionString = @"Data Source=DONG_TRAN\DONGTRANSQL;Initial Catalog = QUANLIHOTEL;Persist Security Info = True;User ID=sa;Password=141192";
               con.Open();
               loadlistbox();
               TXTNGAYTHUE.Value = DateTime.Now;
               butcheckin.Enabled = false;
          }
          void loadlistbox()
          {
               cmd = new SqlCommand("select tenphong from phong where tinhtrang = 0 ",con);
               SqlDataAdapter da = new SqlDataAdapter(cmd);
               DataTable kq = new DataTable();
               da.Fill(kq);
               lbmaphong.DataSource = kq;
               lbmaphong.DisplayMember = "tenphong";
          }
          private void BTLUU_Click_1(object sender, EventArgs e)
          {
               if (txtManv.Text.Trim() == "")
               {
                    errChiTiet.SetError(txtManv, "Bạn không để trống mã nhân viên!");
                    return;
               }
               else
               {
                    errChiTiet.Clear();
                    cmd = new SqlCommand("select count(*) from phieuthue", con);
                    int val = (int)cmd.ExecuteScalar()+1;
                    mathue = "0" + val.ToString().Trim();
                    string tenphong = "";
                    for (int i = 0; i < lbmaphong.SelectedItems.Count; i++)
                    {
                         DataRowView ht = (DataRowView)lbmaphong.SelectedItems[i];
                         tenphong = ht.Row["tenphong"].ToString();
                         cmd = new SqlCommand("EXEC DATPHONG N'" + TXTTENKHACHHANG.Text + "',N'" + TXTDIACHI.Text + "','" + TXTCMND.Text + "','" + TXTSDT.Text + "','" + tenphong + "','" + txtManv.Text + "','" + mathue.Trim() + "','" + TXTNGAYTHUE.Value.Date + "'", con);
                         cmd.ExecuteNonQuery();
                    }
                    lbmaphong.DataSource = null;
                    lbmaphong.Items.Clear();               
                    loadlistbox();
               }

          }
          private void BTHUY_Click(object sender, EventArgs e)
          {
               TXTTENKHACHHANG.Text = "";
               TXTSDT.Text = "";
               TXTDIACHI.Text = "";
               TXTCMND.Text = "";
          }
          private void XUATPHIEUTHUE_Click_1(object sender, EventArgs e)
          {
               //Form2 frm = new Form2();
               //frm.Message = TXTMAKHACHHANG.Text;
               //frm.Show(); frm.Activate();
          }
          private void bunifuImageButton1_Click(object sender, EventArgs e)
          {
               con.Close();
               this.Close();
               Formmainmenu.instance.Show();
               Formmainmenu.instance.LoadAll();
          }
          private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
          {

          }
          private void guna2Button1_Click(object sender, EventArgs e)
          {
               for (int i = 0; i < lbmaphong.Items.Count; i++)
               {
                    DataRowView ht = (DataRowView)lbmaphong.Items[i];
                    string tenphong = ht.Row["tenphong"].ToString();
                    cmd = new SqlCommand("update phong set tinhtrang = 2 where tenphong = '" + tenphong + "'", con);
                    cmd.ExecuteNonQuery();
               }
               MessageBox.Show("Checkin thành công!");
          }
          //button tim kiem khach hang
          private void guna2Button1_Click_1(object sender, EventArgs e)
          {
               string sql = "select tenkh from khachhang where SOCMND= '" + TXTTIMKIEMCMND.Text + "' and  MAKH in ( select makh from PHIEUTHUE where NGAYTHUE = '" + TXTNGAYTHUE.Value.Date + "')";
               cmd = new SqlCommand(sql, con);
               TXTTENKHACHHANG.Text = (string)cmd.ExecuteScalar();
               sql = "select diachikh from khachhang where SOCMND= '" + TXTTIMKIEMCMND.Text + "' and  MAKH in ( select makh from PHIEUTHUE where NGAYTHUE = '" + TXTNGAYTHUE.Value.Date + "')";
               cmd = new SqlCommand(sql, con);
               TXTDIACHI.Text = (string)cmd.ExecuteScalar();
               sql = "select socmnd from khachhang where SOCMND= '" + TXTTIMKIEMCMND.Text + "' and  MAKH in ( select makh from PHIEUTHUE where NGAYTHUE = '" + TXTNGAYTHUE.Value.Date + "')";
               cmd = new SqlCommand(sql, con);
               TXTCMND.Text = (string)cmd.ExecuteScalar();
               sql = "select sdtkh from khachhang where SOCMND= '" + TXTTIMKIEMCMND.Text + "' and  MAKH in ( select makh from PHIEUTHUE where NGAYTHUE = '" + TXTNGAYTHUE.Value.Date + "')";
               cmd = new SqlCommand(sql, con);
               TXTSDT.Text = (string)cmd.ExecuteScalar();
               lbmaphong.DataSource = null;
               lbmaphong.Items.Clear();
               cmd = new SqlCommand("select tenphong from phong where MAPHONG in ( select MAPHONG from CTPHONG where MATHUE in (select MATHUE from PHIEUTHUE where NGAYTHUE = '" + TXTNGAYTHUE.Value.Date + "' and MAKH in (select MAKH from KHACHHANG where SOCMND ='" + TXTTIMKIEMCMND.Text + "'))) ", con);
               SqlDataAdapter da = new SqlDataAdapter(cmd);
               DataTable kq = new DataTable();
               da.Fill(kq);
               lbmaphong.DataSource = kq;
               lbmaphong.DisplayMember = "tenphong";
               butcheckin.Enabled = true;
          }
          //btn xuat phieu thue
          private void btnxuatphieuthue_Click(object sender, EventArgs e)
          {
               string query = "select CTPHONG.MATHUE from CTPHONG,PHIEUTHUE,KHACHHANG where CTPHONG.MATHUE = PHIEUTHUE.MATHUE and PHIEUTHUE.MAKH = KHACHHANG.MAKH and KHACHHANG.SOCMND = '" + TXTTIMKIEMCMND.Text + "' and PHIEUTHUE.NGAYTHUE = '" + TXTNGAYTHUE.Value.Date + "' ";
               DataTable data = DataProvider.Instance.ExecuteQuery(query);
               string maphieuthue = data.Rows[0]["MATHUE"].ToString();
               this.Close();
               Formmainmenu.instance.Hide();
               forminphieuthue.SetPrintBill(maphieuthue,"001");
               forminphieuthue.Show();
          }
          #endregion
     }
}
