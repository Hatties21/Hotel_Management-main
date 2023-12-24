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

namespace testsql
{
     public partial class Formtrangthaiphong : Form
     {
          #region Constructor & Properties
          private readonly Forminphieuthue forminphieuthue = new Forminphieuthue();
          //public int ttphong;
          public string abc;
          public string x, y, z, t;
          SqlConnection con = new SqlConnection("Data Source=DONG_TRAN\\DONGTRANSQL;Initial Catalog = QUANLIHOTEL;Persist Security Info = True;User ID=sa;Password=141192");
          SqlCommand cmd = new SqlCommand();
          public Formtrangthaiphong()
          {
               InitializeComponent();
          }
          private void Formtrangthaiphong_Load(object sender, EventArgs e)
          {
               lbma.Text = abc;
               ttphong.Text = y;
               lbloai.Text = x;
               lbtenphong.Text = z;
               lbtenkh.Text = t;
               string val;
               try
               {
                    if (ttphong.Text != "Còn trống")
                    {
                         con.Open();
                         string query = "SELECT DISTINCT dbo.f_HienTTKH_MaPhong('" + lbma.Text + "') FROM dbo.CTPHONG";
                         cmd = new SqlCommand(query, con);
                         object obj = cmd.ExecuteScalar();
                         if (obj != DBNull.Value)
                         {
                              val = (string)cmd.ExecuteScalar();
                              lbtenkh.Text = val;
                         }
                         else lbtenkh.Text = "(Chưa có tên)";
                         con.Close();
                    }
                    else
                    {
                         lbtenkh.Text = "(Chưa có khách hàng)";
                         //btnthongtin.BackColor = Color.Gray;
                         btnthongtin.Enabled = false;
                         //btndichvu.BackColor = Color.Gray;
                         btndichvu.Enabled = false;
                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
                    con.Close();
               }
               if(ttphong.Text == "Đã đặt")
               {
                    btndichvu.Enabled = false;
               }
          }
          //btn in phieu thue
          private void btnthongtin_Click(object sender, EventArgs e)
          {
                    string query = "select top 1 MATHUE from CTPHONG where maphong = '" + abc.Trim() + "' order by MATHUE desc  ";
                    DataTable data = DataProvider.Instance.ExecuteQuery(query);
                    string maphieuthue = data.Rows[0]["MATHUE"].ToString();
                    this.Close();
                    Formmainmenu.instance.Hide();
                    forminphieuthue.SetPrintBill(maphieuthue, abc);
                    forminphieuthue.Show();
          }
          public static string tenphong, maphong, tenKH;
          //sudung dich vu
          private void guna2Button3_Click(object sender, EventArgs e)
          {
               tenphong = lbtenphong.Text;
               maphong = lbma.Text;
               tenKH = lbtenkh.Text;
               Formdichvuthanhtoan frmthanhtoan = new Formdichvuthanhtoan();
               frmthanhtoan.Show();
          }
          private void BTNDONG_Click(object sender, EventArgs e)
          {
               this.Close();
          }
          #endregion
     }
}
