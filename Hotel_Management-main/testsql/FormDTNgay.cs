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
     public partial class FormDTNgay : Form
     {
          public FormDTNgay()
          {
               InitializeComponent();
          }
          public static string ngay;
          SqlConnection con = new SqlConnection("Data Source=DONG_TRAN\\DONGTRANSQL;Initial Catalog = QUANLIHOTEL;Persist Security Info = True;User ID=sa;Password=141192");

          DataTable table1 = new DataTable();
          Point? prevPosition = null;
          ToolTip tooltip = new ToolTip();
          private void Form2_Load(object sender, EventArgs e)
          {
               datepick1.CustomFormat = "dd/MM/yyyy";
               datepick2.CustomFormat = "dd/MM/yyyy";
               textBox1.Enabled = false;
               datepick1.Enabled = false;
               datepick2.Enabled = false;
          }
          public void loadFind(DateTime date1, DateTime date2)
          {
               try
               {
                    con.Open();
                    DataTable DT = (DataTable)dtgvNgay.DataSource;
                    if (DT != null)
                         DT.Clear();
                    int result = DateTime.Compare(date1, date2);
                    if (result <= 0)
                    {
                         string query = "SELECT * FROM f_ThongKeDT_ngay('" + date1.ToString() + "','" + date2.ToString() + "')";
                         SqlCommand cmd1 = new SqlCommand(query, con);
                         cmd1.ExecuteNonQuery();
                         SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                         adapter.Fill(table1);
                    }
                    else if (result > 0)
                    {
                         MessageBox.Show("Hãy chọn lại khoảng thời gian muốn xem!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dtgvNgay.DataSource = table1;
                    dtgvNgay.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                    con.Close();
               }
               catch
               {
                    con.Close();
               }
          }
          private void btnTimKiem_Click(object sender, EventArgs e)
          {
               DateTime date1;
               DateTime date2;
               if (radioButton1.Checked == true && textBox1.Text != "")
               {
                    date2 = DateTime.Now;
                    date1 = date2.AddDays(-int.Parse(textBox1.Text));
                    loadFind(date1, date2);
               }
               else if (radioButton2.Checked == true)
               {
                    date1 = datepick1.Value;
                    date2 = datepick2.Value;
                    loadFind(date1, date2);
               }

          }
          public void loadChart(DateTime date1, DateTime date2)
          {
               con.Open();
               int result = DateTime.Compare(date1, date2);
               if (result <= 0)
               {
                    SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM f_ThongKeDT_ngay('" + date1.ToString() + "','" + date2.ToString() + "')", con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    BDC.DataSource = dt;
                    BDC.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
                    BDC.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Segoe UI", 12, FontStyle.Bold);
                    BDC.ChartAreas["ChartArea1"].AxisX.TitleForeColor = Color.Red;
                    BDC.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu (VNĐ) ";
                    BDC.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Segoe UI", 12, FontStyle.Bold);
                    BDC.ChartAreas["ChartArea1"].AxisY.TitleForeColor = Color.Red;
                    BDC.ChartAreas["ChartArea1"].AxisX.Interval = 5;
                    BDC.Series["bdc"].IsVisibleInLegend = false;
                    BDC.ChartAreas["ChartArea1"].Position = new ElementPosition(0, 0, 95, 100);
                    BDC.Series["bdc"].XValueMember = "Ngày";
                    BDC.Series["bdc"].YValueMembers = "Doanh thu (VNĐ)";
                    BDC.Series["bdc"].XValueType = ChartValueType.DateTime;
                    BDC.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "dd/MM/yyyy";
                    //BDC.Series["bdc"].IsValueShownAsLabel = true; // hiện dữ liệu trên đỉnh cột
                    BDC.ChartAreas[0].AxisX.LabelStyle.Angle = -60;
                    BDC.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
                    //BDC.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
               }
               else if (result > 0)
               {
                    MessageBox.Show("Hãy chọn lại khoảng thời gian muốn xem!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }

               con.Close();
          }


          private void btnXembieudo_Click(object sender, EventArgs e)
          {

               DateTime date1 = datepick1.Value.Date;
               DateTime date2 = datepick2.Value.Date;
               //SqlDataAdapter ad = new SqlDataAdapter("select ngaythanhtoan,doanhthu =sum(tongtiendv) from hoadon group by ngaythanhtoan ", con);
               if (radioButton1.Checked == true && textBox1.Text != "")
               {
                    date2 = DateTime.Now;
                    date1 = date2.AddDays(-int.Parse(textBox1.Text));
                    loadChart(date1, date2);
               }
               else if (radioButton2.Checked == true)
               {
                    date1 = datepick1.Value;
                    date2 = datepick2.Value;
                    loadChart(date1, date2);
               }
          }
          private void datepick1_ValueChanged(object sender, EventArgs e)
          {
               datepick1.CustomFormat = "dd/MM/yyyy";
          }

          private void datepick2_ValueChanged(object sender, EventArgs e)
          {
               datepick2.CustomFormat = "dd/MM/yyyy";
          }
          private void BDC_MouseMove(object sender, MouseEventArgs e)
          {
               var pos = e.Location;
               if (prevPosition.HasValue && pos == prevPosition.Value)
                    return;
               tooltip.RemoveAll();
               prevPosition = pos;
               var results = BDC.HitTest(pos.X, pos.Y, false,
               ChartElementType.DataPoint);
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
                                   DateTime Xvalue = DateTime.FromOADate(prop.XValue);
                                   tooltip.Show("Ngày: " + Xvalue.ToString("dd/MM/yyyy") + "\n Doanh thu: " + prop.YValues[0], this.BDC, pos.X + 2, pos.Y - 30);
                              }
                         }
                    }
               }
          }

          private void radioButton1_CheckedChanged(object sender, EventArgs e)
          {
               textBox1.Enabled = true;
               datepick1.Enabled = false;
               datepick2.Enabled = false;
               textBox1.Text = "";
               textBox1.Focus();
          }

          private void radioButton2_CheckedChanged(object sender, EventArgs e)
          {
               datepick1.Enabled = true;
               datepick2.Enabled = true;
               textBox1.Enabled = false;
               textBox1.Text = "";
          }

          private void dtgvNgay_CellClick(object sender, DataGridViewCellEventArgs e)
          {
               
               int index = e.RowIndex;
               if (MessageBox.Show("Bạn có muốn xem danh sách hóa đơn vào ngày này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
               {
                    this.Close();
                    if (index >= 0)
                    {
                         ngay = dtgvNgay.Rows[index].Cells["Ngày"].Value.ToString();
                         this.Close();
                         Form6 frm = new Form6();
                         frm.Show();
                    }
               }
          }
          private void guna2ControlBox1_Click(object sender, EventArgs e)
          {
               this.Close();
               Formmainmenu.instance.Show();
          }
     }
}

