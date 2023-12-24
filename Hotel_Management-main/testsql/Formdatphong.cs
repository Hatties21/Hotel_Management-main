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
     public partial class Formdatphong : Form
     {
          #region Constructor & Properties
          private readonly Forminphieuthue forminphieuthue = new Forminphieuthue();

          public string abc;
          public int ttphong;
          public Formdatphong()
          {
               InitializeComponent();
          }
          private void Form1_Load(object sender, EventArgs e)
          {
               if (ttphong == 2)
               {
                    TXTTRANGTHAI.Text = "Đã nhận";
                    TXTTRANGTHAI.Enabled = false;
                    BTNDATPHONG.Enabled = false;
                    BTNNHANPHONG.Enabled = false;
                    BTNINPHIEUTHUE.Enabled = true;
                    CHECKBOXNHANPHONG.Enabled = false;
                    Hienchitiet();
               }
               else if (ttphong == 1)
               {
                    TXTTRANGTHAI.Text = "Đã đặt";
                    TXTTRANGTHAI.Enabled = false;
                    BTNDATPHONG.Enabled = false;
                    BTNNHANPHONG.Enabled = true;
                    BTNINPHIEUTHUE.Enabled = true;
                    CHECKBOXNHANPHONG.Enabled = true;
                    Hienchitiet();
               }
               else
               {
                    Loaddata();
                    string querry1 = "select * from phieuthue ";
                    string querry2 = "select * from phong , loaiphong where phong.maphong = N'"+ abc +"' and phong.maloaiphong = loaiphong.maloaiphong";
                    DataTable data1 = DataProvider.Instance.ExecuteQuery(querry1);
                    DataTable data2 = DataProvider.Instance.ExecuteQuery(querry2);
                    TXTTRANGTHAI.Text = "Còn trống";
                    TXTMAPHONG.Text = abc;
                    TXTMATHUE.Text = "0" + Convert.ToString(data1.Rows.Count + 1);
                    TXTTENLOAIPHONG.Text = data2.Rows[0]["tenloaiphong"].ToString();
                    TXTGIATIEN.Text = data2.Rows[0]["gia"].ToString();
                    TXTTRANGTHAI.Enabled = false;
                    TXTMAPHONG.Enabled = false;
                    TXTMATHUE.Enabled = false;
                    TXTTENLOAIPHONG.Enabled = false;
                    TXTGIATIEN.Enabled = false;
                    BTNDATPHONG.Enabled = true;
                    BTNNHANPHONG.Enabled = false;
                    BTNINPHIEUTHUE.Enabled = false;
                    CHECKBOXNHANPHONG.Enabled = true;
               }
          }
          private void XoaTrangChiTiet()
          {
               TXTTENKH.Text = "";
               TXTSDT.Text = "";
               TXTDIACHI.Text = "";
               TXTCMND.Text = "";
          }
          public void Hienchitiet()
          {
               string querry1 = "usp_get_thongtinphieuthue @maphong";
               DataTable data1 = DataProvider.Instance.ExecuteQuery(querry1, new object[] { abc });
               foreach (DataRow row in data1.Rows)
               {
                    TXTTENKH.Text = row["tenkh"].ToString();
                    TXTDIACHI.Text = row["diachikh"].ToString();
                    TXTCMND.Text = row["socmnd"].ToString();
                    TXTSDT.Text = row["sdtkh"].ToString();
                    TXTMAPHONG.Text = row["maphong"].ToString();
                    TXTTENLOAIPHONG.Text = row["tenloaiphong"].ToString();
                    TXTGIATIEN.Text = row["gia"].ToString();
                    TXTMATHUE.Text = row["mathue"].ToString();
                    DTPNGAYTHUE.Value = Convert.ToDateTime(row["ngaythue"]);
                    DTPNGAYTRA.Value = Convert.ToDateTime(row["ngaydi"]);
                    Loaddays();
                    TXTTENKH.Enabled = false;
                    TXTDIACHI.Enabled = false;
                    TXTCMND.Enabled = false;
                    TXTSDT.Enabled = false;
                    TXTMAPHONG.Enabled = false;
                    TXTTENLOAIPHONG.Enabled = false;
                    TXTGIATIEN.Enabled = false;
                    TXTMATHUE.Enabled = false;
               }
          }
          public void Loaddata()
          {
               LoadDate();
               Loaddays();
          }
          public void LoadDate()
          {
               DTPNGAYTHUE.Value = DateTime.Now;
               DTPNGAYTRA.Value = DateTime.Now.AddDays(1);
          }
          public void Loaddays()
          {
               TXTSODEM.Text = (DTPNGAYTRA.Value.Date - DTPNGAYTHUE.Value.Date).Days.ToString();
          }
          private void DTPNGAYTHUE_onValueChanged(object sender, EventArgs e)
          {
               if(ttphong == 0)
               {
                    if (DTPNGAYTHUE.Value < DateTime.Now)
                         LoadDate();
                    if (DTPNGAYTRA.Value <= DTPNGAYTHUE.Value)
                         LoadDate();
                    Loaddays();
               }
          }
          private void DTPNGAYTRA_onValueChanged(object sender, EventArgs e)
          {
               if(ttphong == 0)
               {
                    if (DTPNGAYTRA.Value <= DateTime.Now)
                         LoadDate();
                    if (DTPNGAYTRA.Value <= DTPNGAYTHUE.Value)
                         LoadDate();
                    Loaddays();
               }
          }
          private void TXTSODEM_KeyPress(object sender, KeyPressEventArgs e)
          {
               if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                    e.Handled = true;
          }
          //dat phong
          private void BTNDATPHONG_Click(object sender, EventArgs e)
          {
               string querry1 = "usp_insert_khachhang_phieuthue_ctphieuthue @tenkh , @diachi , @socmnd , @sdtkh , @ngaythue , @manv , @maphong , @ngaydi";
               string querry2 = "usp_update_tinhtrangphong @maphong , @tinhtrang";
               if ( CHECKBOXNHANPHONG.Checked == true && ttphong == 0)
               {
                    DataProvider.Instance.ExecuteNoneQuery(querry1, new object[] { TXTTENKH.Text, TXTDIACHI.Text, TXTCMND.Text, TXTSDT.Text, DTPNGAYTHUE.Value, "001", abc, DTPNGAYTRA.Value });
                    DataProvider.Instance.ExecuteNoneQuery(querry2, new object[] { abc,2});
                    this.Hide();
                    Formmainmenu.instance.Show();
                    Formmainmenu.instance.LoadAll();
               }
               else if ( CHECKBOXNHANPHONG.Checked == false && ttphong ==0)
               {
                    DataProvider.Instance.ExecuteNoneQuery(querry1, new object[] { TXTTENKH.Text, TXTDIACHI.Text, TXTCMND.Text, TXTSDT.Text, DTPNGAYTHUE.Value, "001", abc, DTPNGAYTRA.Value });
                    DataProvider.Instance.ExecuteNoneQuery(querry2, new object[] { abc,1});
                    this.Hide();
                    Formmainmenu.instance.Show();
                    Formmainmenu.instance.LoadAll();
               }
               else
               {
                    DataProvider.Instance.ExecuteNoneQuery(querry2, new object[] { abc,2});
               }
          }
          //nhận phòng
          private void BTNNHANPHONG_Click(object sender, EventArgs e)
          {
               if (CHECKBOXNHANPHONG.Checked == false)
               {
                    errChiTiet.SetError(CHECKBOXNHANPHONG, "Phải tích vào ô nhận phòng");
               }
               else if (CHECKBOXNHANPHONG.Checked == true)
               {
                    string query = "usp_update_tinhtrangphong @maphong , @tinhtrangphong ";
                    DataProvider.Instance.ExecuteNoneQuery(query, new object[] { abc, 2 });
                    this.Close();
                    Formmainmenu.instance.Show();
                    Formmainmenu.instance.LoadAll();
               }
          }
          private void XUATPHIEUTHUE_Click_1(object sender, EventArgs e)
          {
               string query = "select MATHUE from CTPHONG where maphong = '" + abc.Trim() + "'   ";
               DataTable data = DataProvider.Instance.ExecuteQuery(query);
               string maphieuthue = data.Rows[0]["MATHUE"].ToString();
               this.Close();
               forminphieuthue.SetPrintBill(maphieuthue, abc);
               forminphieuthue.Show();
          }
          //button huy
          private void BTHUY_Click(object sender, EventArgs e)
          {
               this.Close();
               Formmainmenu.instance.Show();
          }
          //button x
          private void bunifuImageButton1_Click(object sender, EventArgs e)
          {
               this.Close();
               Formmainmenu.instance.Show();
          }
          #endregion
     }
}
