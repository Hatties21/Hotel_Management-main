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

namespace testsql
{
     public partial class Forminhoadon : Form
     {
          string mathue;
          public int trangthaiform;
          //1 thi thuoc ve form thanh toan
          //2 thi thuoc ve form danh sach hoa don
          public Forminhoadon()
          {
               InitializeComponent();
          }
          public void SetPrintBill(string mathue)
          {
               ShowBillPreView(mathue);
               ShowInfo(mathue);
          }
          public Forminhoadon(string mathue)
          {
               InitializeComponent();
               ShowBillPreView(mathue);
               ShowInfo(mathue);
          }
          int id = 1;
          int id2 = 1;
          int _totalPrice = 0;
          int _totalPrice2 = 0;
          CultureInfo cultureInfo = new CultureInfo("vi-vn");
          public void ShowBillPreView(string mathue)
          {
               //show thong tin len datagridview ve thong tin phong thue
               listViewUseRoom.Items.Clear();
               DataTable dataTable = DataProvider.Instance.ExecuteQuery("select ctphong.maphong,phong.tenphong,loaiphong.tenloaiphong,convert(int,loaiphong.gia) as gia, (CASE DATEDIFF(DAY,dbo.PHIEUTHUE.NGAYTHUE,GETDATE()) WHEN 0 THEN 1 END) AS songay from ctphong, phong, loaiphong, phieuthue WHERE dbo.PHIEUTHUE.MATHUE = dbo.CTPHONG.MATHUE AND dbo.CTPHONG.MAPHONG = dbo.PHONG.MAPHONG AND dbo.PHONG.MALOAIPHONG = dbo.LOAIPHONG.MALOAIPHONG AND CTPHONG.MATHUE = '" + mathue + "' ");


               foreach (DataRow item in dataTable.Rows)
               {
                    ListViewItem listViewItem = new ListViewItem(id.ToString());
                    id++;

                    ListViewItem.ListViewSubItem subItem1 = new ListViewItem.ListViewSubItem(listViewItem, item["maphong"].ToString());
                    ListViewItem.ListViewSubItem subItem2 = new ListViewItem.ListViewSubItem(listViewItem, item["tenphong"].ToString());
                    ListViewItem.ListViewSubItem subItem3 = new ListViewItem.ListViewSubItem(listViewItem, item["tenloaiphong"].ToString());
                    ListViewItem.ListViewSubItem subItem4 = new ListViewItem.ListViewSubItem(listViewItem, ((int)item["gia"]).ToString("c0", cultureInfo));
                    ListViewItem.ListViewSubItem subitem5 = new ListViewItem.ListViewSubItem(listViewItem, item["songay"].ToString());


                    _totalPrice += (int)item["GIA"];

                    listViewItem.SubItems.Add(subItem1);
                    listViewItem.SubItems.Add(subItem2);
                    listViewItem.SubItems.Add(subItem3);
                    listViewItem.SubItems.Add(subItem4);
                    listViewItem.SubItems.Add(subitem5);

                    listViewUseRoom.Items.Add(listViewItem);
               }

               //show thong tin len datagridview ve thong tin dichvu
               listViewUseService.Items.Clear();
               DataTable dataTable2 = DataProvider.Instance.ExecuteQuery("SELECT phong.TENPHONG , dbo.DICHVU.TENDV, dbo.CTPHIEUSDDV.SOLUONG,convert(int,dbo.DICHVU.DONGIAHIENTAI) as dongiahientai FROM  dbo.PHONG, dbo.PHIEUSDDV, dbo.DICHVU, dbo.CTPHIEUSDDV WHERE dbo.PHIEUSDDV.MAPHIEU = dbo.CTPHIEUSDDV.MAPHIEU AND dbo.CTPHIEUSDDV.MADV = dbo.DICHVU.MADV AND dbo.PHIEUSDDV.MAPHONG = dbo.PHONG.MAPHONG AND dbo.PHIEUSDDV.MATHUE = '" + mathue + "'");
               foreach (DataRow item in dataTable2.Rows)
               {
                    ListViewItem listViewItem = new ListViewItem(id2.ToString());
                    id2++;

                    ListViewItem.ListViewSubItem subItem1 = new ListViewItem.ListViewSubItem(listViewItem, item["tenphong"].ToString());
                    ListViewItem.ListViewSubItem subItem2 = new ListViewItem.ListViewSubItem(listViewItem, item["tendv"].ToString());
                    ListViewItem.ListViewSubItem subItem3 = new ListViewItem.ListViewSubItem(listViewItem, item["soluong"].ToString());
                    ListViewItem.ListViewSubItem subItem4 = new ListViewItem.ListViewSubItem(listViewItem, ((int)item["dongiahientai"]).ToString("c0", cultureInfo));


                    _totalPrice2 += (int)item["dongiahientai"];

                    listViewItem.SubItems.Add(subItem1);
                    listViewItem.SubItems.Add(subItem2);
                    listViewItem.SubItems.Add(subItem3);
                    listViewItem.SubItems.Add(subItem4);

                    listViewUseService.Items.Add(listViewItem);
               }

          }
          public void ShowInfo(string mathue)
          {
               string query0 = "SELECT * FROM dbo.PHIEUTHUE,dbo.NHANVIEN WHERE dbo.NHANVIEN.MANV = dbo.PHIEUTHUE.MANV AND dbo.PHIEUTHUE.MATHUE = '" + mathue + "' ";
               DataTable data0 = DataProvider.Instance.ExecuteQuery(query0);
               lblStaffSetUp.Text = data0.Rows[0]["tennv"].ToString();

               lblTotalPrice.Text = (Int32.Parse(lblRoomPrice.Text) + Int32.Parse(lblServicePrice.Text)).ToString();
               string query = "select * from phieuthue,khachhang,hoadon where hoadon.mathue = phieuthue.mathue and phieuthue.makh = khachhang.makh and phieuthue.mathue = '" + mathue + "' ";
               DataTable data = DataProvider.Instance.ExecuteQuery(query);
               lblIDBill.Text = mathue;
               //lblDateCreate.Text = Convert.ToDateTime(data.Rows[0]["NGAYTHANHTOAN"]).ToString("dd/MM/yyyy");
               lblCustomerName.Text = data.Rows[0]["tenkh"].ToString();
               lblIDCard.Text = data.Rows[0]["SOCMND"].ToString();
               lblPhoneNumber.Text = data.Rows[0]["SDTKH"].ToString();
               //lblDateCheckIn.Text = data.Rows[0]["ngaythue"].ToString();
               lblAddress.Text = data.Rows[0]["DIACHIKH"].ToString();
               DateTime ngayden = (DateTime)data.Rows[0]["NGAYTHUE"];
               DateTime ngaydi = (DateTime)data.Rows[0]["NGAYTHANHTOAN"];
               int day = ngaydi.Subtract(ngayden).Days;
               if(day == 0)
               {
                    day = 1;
               }
               lblDays.Text = day.ToString();
               lblDateCheckIn.Text = ngayden.ToString("dd/MM/yyyy");
               lblDateCreate.Text = ngaydi.ToString("dd/MM/yyyy");
               lblServicePrice.Text = _totalPrice2.ToString("c0", cultureInfo).ToString();
               lblRoomPrice.Text = _totalPrice.ToString("c0", cultureInfo).ToString();
               lblTotalPrice.Text = (_totalPrice + _totalPrice2).ToString("c0", cultureInfo).ToString();
               //string query = "USP_ShowBillInfo @idBill";
               //DataRow data = DataProvider.Instance.ExecuteQuery(query, new object[] { idBill }).Rows[0];
               //CultureInfo cultureInfo = new CultureInfo("vi-vn");
               //lblCustomerName.Text = data["HoTen"].ToString();
               //lblIDCard.Text = data["CMND"].ToString();
               //lblPhoneNumber.Text = ((int)data["SDT"]).ToString();
               //lblCustomerTypeName.Text = data["LoaiKH"].ToString();
               //lblAddress.Text = data["DiaChi"].ToString();
               //lblRoomPrice_.Text=((int)data["DonGia"]).ToString("c0",cultureInfo);
               //lblDateCheckIn.Text=((DateTime)data["NgayDen"]).ToString().Split(' ')[0];
               //DateTime dateCheckIn= (DateTime)data["NgayDen"];
               //DateTime dateCheckOut = (DateTime)data["NgayDi"];
               //int days = dateCheckOut.Subtract(dateCheckIn).Days;
               //lblDays.Text = days.ToString();
               //lblPeoples.Text = RoomDAO.Instance.GetPeoples(idBill).ToString();
               //lblSurcharge.Text= ((int)data["PhuThu"]).ToString("c0", cultureInfo);
               //lblServicePrice.Text= ((int)data["TienDichVu"]).ToString("c0", cultureInfo);
               //lblRoomPrice.Text= ((int)data["TienPhong"]).ToString("c0", cultureInfo);
               //lblTotalPrice.Text= ((int)data["ThanhTien"]).ToString("c0", cultureInfo);
               //lblFinalPrice.Text= ((int)data["ThanhTien"]*((100-(int)data["GiamGia"])/100.0)).ToString("c0", cultureInfo);
               //lblDiscount.Text= ((int)data["GiamGia"]).ToString()+" %";
          }
          private void btnClose_Click(object sender, EventArgs e)
          {
               Close();
               if(trangthaiform == 1)
               {
                    Formdichvuthanhtoan1 frmthanhtoan = new Formdichvuthanhtoan1();
                    frmthanhtoan.Show();
               }
               else if(trangthaiform == 2)
               {
                    Form6 frmthongkehoadon = new Form6();
                    frmthongkehoadon.Show();
               }
          }
          private void btnClose__Click(object sender, EventArgs e)
          {
               Close();
          }
          //in form ra pdf
          private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
          {
               Bitmap bitmap = new Bitmap(this.Width, this.Height);
               this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
               e.Graphics.DrawImage(bitmap, 0, 0);
               bitmap.Dispose();
          }
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
               this.Close();
          }
     }
}
