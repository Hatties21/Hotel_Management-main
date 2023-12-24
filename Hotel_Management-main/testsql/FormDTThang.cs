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
using System.Windows.Forms.DataVisualization.Charting;

namespace testsql
{
     public partial class FormDTThang : Form
     {
          public FormDTThang()
          {
               InitializeComponent();
          }
          SqlConnection con = new SqlConnection("Data Source=DONG_TRAN\\DONGTRANSQL;Initial Catalog = QUANLIHOTEL;Persist Security Info = True;User ID=sa;Password=141192");
          DataTable table1 = new DataTable();
          Point? prevPosition = null;
          ToolTip tooltip = new ToolTip();
          private void Form3_Load(object sender, EventArgs e)
          {
               datepick1.CustomFormat = "MM/yyyy";
               datepick2.CustomFormat = "MM/yyyy";
               datepick1.ShowUpDown = true;
          }

          private void btnTimkiem_Click(object sender, EventArgs e)
          {
               try
               {
                    con.Open();
                    DataTable DT = (DataTable)dtgvThang.DataSource;
                    if (DT != null)
                         DT.Clear();
                    //dtgvNgay.Rows.Clear();
                    DateTime date1 = datepick1.Value;
                    DateTime date2 = datepick2.Value;
                    int result = DateTime.Compare(date1, date2);
                    if (result <= 0)
                    {
                         string query = "SELECT * FROM f_ThongKeDT_thang('" + date1 + "','" + date2 + "')";
                         SqlCommand cmd1 = new SqlCommand(query, con);
                         cmd1.ExecuteNonQuery();
                         SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                         adapter.Fill(table1);
                    }
                    else if (result > 0)
                    {
                         MessageBox.Show("Hãy chọn lại khoảng thời gian muốn xem!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dtgvThang.DataSource = table1;
                    dtgvThang.Columns[0].DefaultCellStyle.Format = "MM/yyyy";
                    con.Close();
               }
               catch (Exception ex)
               {
                    //MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại!");
                    MessageBox.Show(ex.Message);
                    con.Close();
               }
          }

          private void btnXembieudo_Click(object sender, EventArgs e)
          {
               try
               {
                    con.Open();
                    //DateTime date1 = datepick1.Value;
                    //DateTime date2 = datepick2.Value;

                    DateTime date1 = new DateTime(datepick1.Value.Year, datepick1.Value.Month, 1);
                    int d2 = datepick2.Value.Month;
                    DateTime date2;

                    if (d2 == 1 || d2 == 3 || d2 == 5 || d2 == 7 || d2 == 8 || d2 == 10 || d2 == 12)
                    {
                         date2 = new DateTime(datepick2.Value.Year, datepick2.Value.Month, 31);
                    }
                    else if (d2 == 2)
                    {
                         date2 = new DateTime(datepick2.Value.Year, datepick2.Value.Month, 28);
                    }
                    else date2 = new DateTime(datepick2.Value.Year, datepick2.Value.Month, 30);
                    SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM f_ThongKeDT_thang('" + date1 + "','" + date2 + "')", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    DTThang.DataSource = dt;
                    DTThang.ChartAreas["theothang"].AxisX.Title = "Tháng";
                    DTThang.ChartAreas["theothang"].AxisX.TitleFont = new Font("Segoe UI", 12, FontStyle.Bold);
                    DTThang.ChartAreas["theothang"].AxisX.TitleForeColor = Color.Red;
                    DTThang.ChartAreas["theothang"].AxisY.Title = "Doanh thu (VNĐ) ";
                    DTThang.ChartAreas["theothang"].AxisY.TitleFont = new Font("Segoe UI", 12, FontStyle.Bold);
                    DTThang.ChartAreas["theothang"].AxisY.TitleForeColor = Color.Red;
                    //DTThang.ChartAreas["theothang"].AxisX.Interval = 1;
                    DTThang.ChartAreas["theothang"].Position = new ElementPosition(0, 0, 95, 100);
                    DTThang.Series["theothang"].XValueMember = "Tháng";
                    DTThang.Series["theothang"].YValueMembers = "Doanh thu (VNĐ)";
                    //DTThang.Series["theothang"].XValueType = ChartValueType.DateTime;
                    DTThang.ChartAreas["theothang"].AxisX.LabelStyle.Format = "MM/yyyy";
                    DTThang.Series["theothang"].IsValueShownAsLabel = true; // hiện dữ liệu trên đỉnh cột
                    DTThang.ChartAreas[0].AxisX.LabelStyle.Angle = -60;
                    DTThang.ChartAreas["theothang"].AxisX.MajorGrid.Enabled = false;
                    //BDC.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
                    con.Close();
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
                    //MessageBox.Show("Đã xẩy ra lỗi! \nVui lòng thử lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
               }

          }
          private void DTThang_MouseMove(object sender, MouseEventArgs e)
          {
               var pos = e.Location;
               if (prevPosition.HasValue && pos == prevPosition.Value)
                    return;
               tooltip.RemoveAll();
               prevPosition = pos;
               var results = DTThang.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint);
               foreach (var result in results)
               {
                    if (result.ChartElementType == ChartElementType.DataPoint)
                    {
                         var prop = result.Object as DataPoint;
                         if (prop != null)
                         {
                              var pointXPixel = result.ChartArea.AxisX.ValueToPixelPosition(prop.XValue);
                              var pointYPixel = result.ChartArea.AxisY.ValueToPixelPosition(prop.YValues[0]);

                              // kiểm tra xem con trỏ có nằm trên cột đó không 
                              if (Math.Abs(pos.X - pointXPixel) < 500 && Math.Abs(pos.Y - pointYPixel) < 500)
                              {
                                   tooltip.Show("Doanh thu:" + prop.YValues[0], this.DTThang, pos.X + 2, pos.Y - 30);
                              }
                         }
                    }
               }

          }

          private void datepick1_ValueChanged(object sender, EventArgs e)
          {

          }
          private void datepick1_ValueChanged_1(object sender, EventArgs e)
          {

          }

          private void bunifuImageButton1_Click(object sender, EventArgs e)
          {
               this.Close();
               Formmainmenu.instance.Show();
          }
     }
}