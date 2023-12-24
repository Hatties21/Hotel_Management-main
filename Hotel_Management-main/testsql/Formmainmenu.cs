using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using testsql.DAO;
using System.Threading.Tasks;
using System.Globalization;

namespace testsql
{
     public partial class Formmainmenu : Form
     {
          public static Formmainmenu instance;
          public FormLogin frmLogin;
          public Formthongtinnhom frmTT;
          public Formdoimatkhauuser frmDoiMK;
          public string musername = null;
          public string mfullname = "";
          public string mchucvu = null;
          public Formmainmenu()
          {
               instance = this;
               mfullname = FormLogin.fullname;
               mchucvu = FormLogin.chucvu;
               InitializeComponent();
               CustomizeDesing();
               LoadAll();
               tatchucnang();
               labelnd.Text = "Hi " + mfullname;
               labeltennd.Text = "( " + mchucvu + " )";
               labelnd.Visible = false;
          }

          private string userName;
          public void tatchucnang()
          {
               mnHethong.Enabled = false;
               mnQuanly.Enabled = false;
               mnKhachhang.Enabled = false;
               mnBaocao.Enabled = false;
               mnTrogiup.Enabled = false;
               mnThoat.Enabled = false;
          }
          public void mochucnang()
          {
               mnHethong.Enabled = true;
               mnQuanly.Enabled = true;
               mnKhachhang.Enabled = true;
               mnBaocao.Enabled = true;
               mnTrogiup.Enabled = true;
               mnThoat.Enabled = true;
          }
          public void LoadAll()
          {
               LoadSDP();
               ThongKe();
               fillchart();
               filldatagridview();
          }
          public Formmainmenu(string userName)
          {
               this.userName = userName;
               InitializeComponent();
          }
          private void BTDONG_Click_1(object sender, EventArgs e)
          {
               Application.Exit();
          }
          public void ThongKe()
          {
               DataTable data = DataProvider.Instance.ExecuteQuery("usp_get_thongkephong");
               foreach (DataRow row in data.Rows)
               {
                    lbpd.Text = row["phongtrong"].ToString();
                    lbpt.Text = row["phongdadat"].ToString();
                    lbpdt.Text = row["phongdanhan"].ToString();
                    sumphong.Text = (int.Parse(lbpt.Text) + int.Parse(lbpd.Text) + int.Parse(lbpdt.Text)).ToString();
               }
          }
          //biểu đồ hình tròn 
          public void fillchart()
          {
               string query0 = "select count(*) from PHONG where TINHTRANG = 0";
               int phongtrong = (int)DataProvider.Instance.ExecuteScalar(query0);
               string query1 = "select count(*) from PHONG where TINHTRANG = 1";
               int phongdat = (int)DataProvider.Instance.ExecuteScalar(query1);
               string query2 = "select count(*) from PHONG where TINHTRANG = 2";
               int phongnhan = (int)DataProvider.Instance.ExecuteScalar(query2);
               refillchart();
               chart1.Series["Series1"].Points.AddXY("Phòng đã nhận", phongnhan);
               chart1.Series["Series1"].Points.AddXY("Phòng trống", phongtrong);
               chart1.Series["Series1"].Points.AddXY("Phòng đã đặt", phongdat);
               chart1.Series["Series1"].Label = "#PERCENT{P2}";
               chart1.Series["Series1"].LegendText = "#VALX";
          }
          public void refillchart()
          {
               chart1.Series["Series1"].Points.Clear();
          }
          //dữ liệu loại phòng trên gridview
          public void filldatagridview()
          {
               CultureInfo cultureInfo = new CultureInfo("vi-vn");
               string query = "select * from loaiphong";
               DataTable data = DataProvider.Instance.ExecuteQuery(query);
               guna2DataGridView1.DataSource = data;
               guna2DataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
               guna2DataGridView1.Columns[2].DefaultCellStyle.Format = "c0";
               guna2DataGridView1.Columns[2].DefaultCellStyle.FormatProvider = cultureInfo;
          }
          //load so do phong
          public void LoadSDP()
          {
               string query = "select * from phong";
               DataTable dt = DataProvider.Instance.ExecuteQuery(query);
               panellistroom.Controls.Clear();
               for(int i = 0; i < dt.Rows.Count ; i++)
               {
                    Bunifu.Framework.UI.BunifuTileButton button = new Bunifu.Framework.UI.BunifuTileButton();
                    button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    button.ForeColor = System.Drawing.Color.Black;
                    button.BackColor = System.Drawing.Color.White;
                    button.color = System.Drawing.Color.White;
                    button.colorActive = System.Drawing.Color.Gray;
                    string dat = dt.Rows[i]["tinhtrang"].ToString();  
                    switch(dat)
                    {
                         case "0":
                              button.Image = global::testsql.Properties.Resources.bedroom_0;
                              break;
                         case "1":
                              button.Image = global::testsql.Properties.Resources.bedroom_1;
                              break;
                         case "2":
                              button.Image = global::testsql.Properties.Resources.bedroom_2;
                              break;
                    }
                    button.ImagePosition = 15;
                    button.ImageZoom = 36;
                    button.LabelPosition = 29;
                    button.Size = new System.Drawing.Size(115,100);
                    button.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
                    button.Tag = dt;
                    button.LabelText =dt.Rows[i]["tenphong"].ToString().Trim();
                    button.Click += Button_click;
                    panellistroom.Controls.Add(button);
               }
          }
          //thao tác click chọn phòng
          private void Button_click(object sender, EventArgs e)
          {
               Bunifu.Framework.UI.BunifuTileButton button = sender as Bunifu.Framework.UI.BunifuTileButton;
               Formtrangthaiphong frmttp = new Formtrangthaiphong();
               string tenphong = button.LabelText.Trim();
               string querry = "select * from phong,loaiphong where tenphong = N'" + tenphong + "' and phong.maloaiphong = loaiphong.maloaiphong";
               DataTable dt = DataProvider.Instance.ExecuteQuery(querry);
               frmttp.abc = dt.Rows[0]["maphong"].ToString();
               string tinhtrang = dt.Rows[0]["tinhtrang"].ToString();
               //frmttp.y = Convert.ToInt32(tinhtrang);
               switch (tinhtrang)
               {
                    case "0": frmttp.y = "Còn trống";break;
                    case "1": frmttp.y = "Đã đặt";break;
                    case "2": frmttp.y = "Đã nhận";break;
               }
               frmttp.x = dt.Rows[0]["tenloaiphong"].ToString();
               frmttp.z = dt.Rows[0]["tenphong"].ToString();
               frmttp.ShowDialog();
          }
          //button x
          private void bunifuImageButton1_Click(object sender, EventArgs e)
          {
               if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Exit();
          }
          private void CustomizeDesing()
          {
               panelHethong.Visible = false;
               panelKhachhang.Visible = false;
               panelQuanly.Visible = false;
               panelBaocao.Visible = false;
               panelTrogiup.Visible = false;
          }
          private void hideSubmenu()
          {
               if (panelHethong.Visible == true)
                    panelHethong.Visible = false;
               if (panelKhachhang.Visible == true)
                    panelKhachhang.Visible = false;
               if (panelQuanly.Visible == true)
                    panelQuanly.Visible = false;
               if (panelBaocao.Visible == true)
                    panelBaocao.Visible = false;
               if (panelTrogiup.Visible == true)
                    panelTrogiup.Visible = false;
          }
          private void ShowSubmenu(Panel subMenu)
          {
               if (subMenu.Visible == false)
               {
                    hideSubmenu();
                    subMenu.Visible = true;
               }
               else
                    subMenu.Visible = false;
          }
          //nút 3 gạch ngang
          private void btnMenu1_Click(object sender, EventArgs e)
          {
               if (panelMenu.Width == 65)
               {
                    mochucnang();
                    labelnd.Visible = true;
                    gunaPictureBox1.Visible = true;
                    gunapictureBox2.Visible = false;
                    panelMenu.Visible = false;
                    panelMenu.Width = 170;
                    paneltransition.ShowSync(panelMenu);
               }
               else
               {
                    tatchucnang();
                    labelnd.Visible = false;
                    gunaPictureBox1.Visible = false;
                    gunapictureBox2.Visible = true;
                    panelMenu.Width = 65;
                    paneltransition.ShowSync(panelMenu);
               }
          }
          //thông tin nhóm
          private void bunifuFlatButton5_Click(object sender, EventArgs e)
          {
               frmTT = new Formthongtinnhom();
               frmTT.Show();
          }
          private void bunifuFlatButton6_Click(object sender, EventArgs e)
          {
               if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Exit();
          }
          private void guna2Button1_Click(object sender, EventArgs e)
          {

          }
          private void guna2Button2_Click(object sender, EventArgs e)
          {

          }

          private void guna2Button3_Click(object sender, EventArgs e)
          {

          }
          //quản lí khách hàng
          private void bunifuFlatButton1_Click(object sender, EventArgs e)
          {
               Formdanhsachkhachhang frmkhachhang = new Formdanhsachkhachhang();
               this.Hide();
               frmkhachhang.ShowDialog();
          }
          //quản lí nhân viên
          private void bunifuFlatButton3_Click(object sender, EventArgs e)
          {
               Formdanhsachnhanvien frmnhanvien = new Formdanhsachnhanvien();
               this.Hide();
               frmnhanvien.ShowDialog();
          }
          //quản lí thống kê
          private void bunifuFlatButton4_Click(object sender, EventArgs e)
          {

          }
          //quản lí đặt phòng
          private void guna2Button2_Click_1(object sender, EventArgs e)
          {
               Formdatphong1 frmdatphong1 = new Formdatphong1();
               this.Hide();
               frmdatphong1.ShowDialog();
          }

          private void guna2Button4_Click(object sender, EventArgs e)
          {
               Formdichvuthanhtoan1 frmthanhtoan1 = new Formdichvuthanhtoan1();
               this.Hide();
               frmthanhtoan1.ShowDialog();
          }
          public void reloadSDP()
          {
               panellistroom.Controls.Clear();
               LoadSDP();
          }

          private void mnHethong_Click(object sender, EventArgs e)
          {
               ShowSubmenu(panelHethong);
          }

          private void mnKhachhang_Click(object sender, EventArgs e)
          {
               ShowSubmenu(panelKhachhang);
          }

          private void mnQuanly_Click(object sender, EventArgs e)
          {
               if (mchucvu == "Admin" || mchucvu == "Quản Lý")
               {
                    ShowSubmenu(panelQuanly);
               }
               else
               {
                    MessageBox.Show("Bạn không có quyền này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
          }

          private void mnBaocao_Click(object sender, EventArgs e)
          {
               if (mchucvu == "Admin" || mchucvu == "Quản Lý")
               {
                    ShowSubmenu(panelBaocao);
               }
               else
               {
                    MessageBox.Show("Bạn không có quyền này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
               

          }

          private void mnTrogiup_Click(object sender, EventArgs e)
          {
               ShowSubmenu(panelTrogiup);

          }
          //button dang xuat
          private void gunaGradientButton2_Click(object sender, EventArgs e)
          {
               this.Close();
               FormLogin frm = new FormLogin();
               frm.Show();
               hideSubmenu();
          }
          //button doi mat khau nguoi dung
          private void gunaGradientButton3_Click(object sender, EventArgs e)
          {
               hideSubmenu();
               frmDoiMK = new Formdoimatkhauuser();
               frmDoiMK.frmMain = this;
               frmDoiMK.ShowDialog();
          }
          //button quan li khach hang
          private void gunaGradientButton5_Click(object sender, EventArgs e)
          {
               hideSubmenu();
               Formdanhsachkhachhang frmkhachhang = new Formdanhsachkhachhang();
               this.Hide();
               frmkhachhang.ShowDialog();
          }
          //button quan li nhan vien
          private void gunaGradientButton7_Click(object sender, EventArgs e)
          {
               hideSubmenu();
               Formdanhsachnhanvien frmnhanvien = new Formdanhsachnhanvien();
               this.Hide();
               frmnhanvien.ShowDialog();
          }
          private void gunaGradientButton9_Click(object sender, EventArgs e)
          {

               //doanh thu theo ngày
               hideSubmenu();
               this.Hide();
               FormDTNgay dTNgay = new FormDTNgay();
               dTNgay.ShowDialog();
               
          }
          private void gunaGradientButton10_Click(object sender, EventArgs e)
          {
               //DOANH THU THANG
               hideSubmenu();
               this.Hide();
               FormDTThang dTThang = new FormDTThang();
               dTThang.ShowDialog();

          }
          //button thong tin nhom
          private void gunaGradientButton12_Click(object sender, EventArgs e)
          {
               this.Hide();
               hideSubmenu();
               frmTT = new Formthongtinnhom();
               frmTT.Show();
          }
          private void bunifuFlatButton2_Click(object sender, EventArgs e)
          {

          }
          private void panel2_Paint(object sender, PaintEventArgs e)
          {

          }
          private void mnThoat_Click(object sender, EventArgs e)
          {
               if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Exit();
          }

          private void gunaGradientButton4_Click(object sender, EventArgs e)
          {
               hideSubmenu();
               FormQLLP qllp = new FormQLLP();
               qllp.ShowDialog();
          }

          private void gunaGradientButton6_Click(object sender, EventArgs e)
          {
               hideSubmenu();
               formQLDV qldv = new formQLDV();
               qldv.ShowDialog();
          }

          private void gunaGradientButton1_Click(object sender, EventArgs e)
          {
               //quan ly phong
               hideSubmenu();
               FormQLPhong qLPhong = new FormQLPhong();
               qLPhong.ShowDialog();
          }
     }
}
