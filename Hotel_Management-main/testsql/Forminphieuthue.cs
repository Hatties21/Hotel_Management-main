using testsql.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace testsql
{
     public partial class Forminphieuthue : Form
     {
          public Forminphieuthue()
          {
               InitializeComponent();
          }
          public void SetPrintBill(string maphieuthue, string maphong)
          {
               ShowBillPreView(maphieuthue);
               ShowInfo(maphong);         
          }
          public Forminphieuthue(string maphieuthue, string maphong)
          {
               InitializeComponent();
               ShowBillPreView(maphieuthue);
               ShowInfo(maphong);
          }
          int id = 1;
          public void ShowBillPreView(string maphieuthue)
          {
               string query = "SELECT * FROM dbo.PHIEUTHUE,dbo.NHANVIEN WHERE dbo.NHANVIEN.MANV = dbo.PHIEUTHUE.MANV AND dbo.PHIEUTHUE.MATHUE = '" + maphieuthue + "' ";
               DataTable data0 = DataProvider.Instance.ExecuteQuery(query);
               lblStaffSetUp.Text = data0.Rows[0]["tennv"].ToString();
               listViewUseService.Items.Clear();
               string querry = "usp_show_thongtinmathue @mathue";
               DataTable data = DataProvider.Instance.ExecuteQuery(querry, new object[] { maphieuthue });
               foreach (DataRow item in data.Rows)
               {
                    ListViewItem listViewItem = new ListViewItem(id.ToString());
                    id++;

                    ListViewItem.ListViewSubItem subItem1 = new ListViewItem.ListViewSubItem(listViewItem, item["Mã Phòng"].ToString());
                    ListViewItem.ListViewSubItem subItem2 = new ListViewItem.ListViewSubItem(listViewItem, item["Tên Phòng"].ToString());
                    ListViewItem.ListViewSubItem subItem3 = new ListViewItem.ListViewSubItem(listViewItem, item["Loại Phòng"].ToString());
                    ListViewItem.ListViewSubItem subItem4 = new ListViewItem.ListViewSubItem(listViewItem, item["Đơn Giá"].ToString());

                    listViewItem.SubItems.Add(subItem1);
                    listViewItem.SubItems.Add(subItem2);
                    listViewItem.SubItems.Add(subItem3);
                    listViewItem.SubItems.Add(subItem4);

                    listViewUseService.Items.Add(listViewItem);
               }
               id = 1;
          }
          public void ShowInfo(string maphong)
          {
               lblDateCreate.Text = DateTime.Now.ToString("dd/MM/yyyy");
               string query = "usp_get_thongtinphieuthue @maphong";
               DataRow data = DataProvider.Instance.ExecuteQuery(query, new object[] { maphong }).Rows[0];
               lblIDBill.Text = data["MATHUE"].ToString();
               lblCustomerName.Text = data["TENKH"].ToString();
               lblIDCard.Text = data["SOCMND"].ToString();
               lblPhoneNumber.Text = data["SDTKH"].ToString();
               lblAddress.Text = data["DIACHIKH"].ToString();
               lblRoomName.Text = data["TENPHONG"].ToString();
               lblRoomTypeName.Text = data["TENLOAIPHONG"].ToString();
               lblRoomPrice_.Text = data["GIA"].ToString();
               lblDateCheckIn.Text = ((DateTime)data["NGAYTHUE"]).ToString("dd/MM/yyyy").Split(' ')[0];
               DateTime dateCheckIn = (DateTime)data["NGAYTHUE"];
               //DateTime dateCheckOut = (DateTime)data["NGAYDI"];
               //int days = dateCheckOut.Subtract(dateCheckIn).Days;
               //lblDays.Text = days.ToString();
          }
          private void btnClose__Click(object sender, EventArgs e)
          {
               Close();
               Formmainmenu.instance.Show();
          }
          private void btnClose_Click(object sender, EventArgs e)
          {
               this.Close();
               Formmainmenu.instance.Show();
          }
          private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
          {
               Bitmap bitmap = new Bitmap(this.Width, this.Height);
               this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
               e.Graphics.DrawImage(bitmap, 0, 0);
               bitmap.Dispose();
          }
          Bitmap bitmap;
          private void btnPrint_Click(object sender, EventArgs e)
          {
               btnPrint.Visible = false;
               btnClose_.Visible = false;
               btnClose.Visible = false;

               System.Drawing.Printing.PrintDocument PrintDocument2 = new System.Drawing.Printing.PrintDocument();
               PrintDialog printDialog2 = new PrintDialog();
               PrintDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
               printDialog2.Document = PrintDocument2;
               if (printDialog2.ShowDialog() == DialogResult.OK)
                    printDocument1.Print();
          }
     }
}
