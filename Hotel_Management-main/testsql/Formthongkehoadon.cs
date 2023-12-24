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
     public partial class Form6 : Form
     {
          #region Constructor & Properties
          private readonly Forminhoadon forminhoadon = new Forminhoadon();
          SqlConnection connection;
          SqlCommand command1;
          string str = @"Data Source=DONG_TRAN\DONGTRANSQL;Initial Catalog = QUANLIHOTEL;Persist Security Info = True;User ID=sa;Password=141192";


          SqlDataAdapter adapter = new SqlDataAdapter();

          DataTable table1 = new DataTable();


          bool IsTheSameCellValue(int column, int row)
          {
               DataGridViewCell cell1 = dgv6[column, row];
               DataGridViewCell cell2 = dgv6[column, row - 1];
               if (cell1.Value == null || cell2.Value == null)
               {
                    return false;
               }
               return cell1.Value.ToString() == cell2.Value.ToString();
          }

          public Form6()
          {
               InitializeComponent();

               table1.Clear();
               dgv6.DataSource = table1;

               connection = new SqlConnection(str);
               command1 = connection.CreateCommand();

               DateTime ngay1 = new DateTime();
               ngay1 = Convert.ToDateTime(FormDTNgay.ngay);
               lb.Text = ngay1.ToString("dd/MM/yyyy");
               //string ngayhienthi = ngay1.ToString();
               //ngayhienthi.
               command1.CommandText = " select distinct mahd as 'Mã hóa đơn' ,  nhanvien.tennv as 'Tên nhân viên', tenkh as 'Tên khách hàng', hoadon.maphong as 'Mã phòng',dbo.thongketiendv(hoadon.mathue, hoadon.maphong) as 'Tiền dịch vụ', dbo.thongketieno(hoadon.mathue, hoadon.maphong) as 'Tiền phòng', dbo.thongketientong(hoadon.mathue, hoadon.maphong) as 'Tổng tiền' " +
                   "from hoadon,phieuthue, khachhang, ctphong, nhanvien" +
                   " where ngaythanhtoan='" + ngay1.ToString("yyyy/MM/dd") + "' and  hoadon.mathue=ctphong.mathue and ctphong.mathue=phieuthue.mathue and khachhang.makh=phieuthue.makh and phieuthue.manv=nhanvien.manv ";
               adapter.SelectCommand = command1;
               adapter.Fill(table1);
               dgv6.DataSource = table1;

          }

          private void Form6_Load(object sender, EventArgs e)
          {
               connection = new SqlConnection(str);
          }

          private void txtMAHD_TextChanged(object sender, EventArgs e)
          {

          }

          private void dgv6_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
          {
               if (e.RowIndex == 0)
                    return;
               //if (e.ColumnIndex != 4 && e.ColumnIndex !=5 && e.ColumnIndex != 6 && e.ColumnIndex != 7)
               //     if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
               //     {
               //          e.Value = "";
               //          e.FormattingApplied = true;
               //     }
          }

          private void dgv6_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
          {
               e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
               if (e.RowIndex < 1 || e.ColumnIndex < 0)
                    return;
               if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
               {
                    e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
               }
               else
               {
                    e.AdvancedBorderStyle.Top = dgv6.AdvancedCellBorderStyle.Top;
               }
          }

          private void lb_Click(object sender, EventArgs e)
          {

          }

          private void bunifuImageButton1_Click(object sender, EventArgs e)
          {
               this.Close();
               //Formmainmenu.instance.Show();
               //Formmainmenu.instance.LoadAll();
               FormDTNgay frmdtngay = new FormDTNgay();
               frmdtngay.Show();
          }

          private void dgv6_CellClick(object sender, DataGridViewCellEventArgs e)
          {
               int index = e.RowIndex;
               string mahoadon = dgv6.Rows[index].Cells["mahd"].Value.ToString();
               string query = "select mathue from hoadon where mahd = '" + mahoadon + "'  ";
               DataTable data = DataProvider.Instance.ExecuteQuery(query);
               string mathue = data.Rows[0]["mathue"].ToString().Trim();
               Forminhoadon frminhoadon = new Forminhoadon();
               forminhoadon.SetPrintBill(mathue);
               forminhoadon.trangthaiform = 2;
               forminhoadon.Show();
               index = 0;
               this.Close();
          }
     }
     #endregion
}
