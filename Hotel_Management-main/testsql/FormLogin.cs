using testsql.DAO;
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
namespace testsql
{
     public partial class FormLogin : Form
     {
          //public Formmainmenu frmMain;
          public static string fullname = "";
          public static string chucvu = "";
          public static string username = "";
          public FormLogin()
          {
               InitializeComponent();
          }
          SqlConnection con4 = new SqlConnection(@"Data Source=HATTIES;Initial Catalog=QLKS;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
          private void FormLogin_Load(object sender, EventArgs e)
          {
               if (txtMatKhau.PasswordChar == '\0')
               {
                    btnShow.BringToFront();
                    txtMatKhau.PasswordChar = '*';
               }
          }
          private void btnShow_Click(object sender, EventArgs e)
          {
               if (txtMatKhau.PasswordChar == '*')
               {
                    btnHide.BringToFront();
                    txtMatKhau.PasswordChar = '\0';
               }
               txtMatKhau.UseSystemPasswordChar = false;
          }
          private void btnHide_Click(object sender, EventArgs e)
          {
               if (txtMatKhau.PasswordChar == '\0')
               {
                    btnShow.BringToFront();
                    txtMatKhau.PasswordChar = '*';
               }
          }
          private void btnExit_Click(object sender, EventArgs e)
          {
               Application.Exit();
          }
          private bool passw()
          {
               if (txtMatKhau.Text == "")
               {
                    MessageBox.Show("Mật khẩu không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
               }
               return true;
          }
          private bool tendn()
          {
               if (txttenDangnhap.Text == "")
               {
                    MessageBox.Show("Tên đăng nhập không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
               }
               return true;
          }
          private bool kiemtra()
          {
               if (tendn() && passw())
               {
                    return true;
               }
               return false;
          }
          private void btnLogin_Click(object sender, EventArgs e)
          {
               DANGNHAP();
          }
          private void bunifuImageButton2_Click(object sender, EventArgs e)
          {
               Application.Exit();
          }
          private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
          {
               if (e.KeyChar == 13)
                    DANGNHAP();
          }
          //fuction dang nhap form
          public void DANGNHAP()
          {
               if (kiemtra())
               {
                    try
                    {
                         //     string tk = txttenDangnhap.Text;
                         //     string mk = txtMatKhau.Text;
                         //     string query = "select * from user1 where username1 = N'" + tk + "' and password1 = N'" + mk + "'   ";
                         //     DataTable data = DataProvider.Instance.ExecuteQuery(query);
                         //     if (data.Rows.Count > 0)
                         //     {
                         //          this.Hide();
                         //          Formmainmenu f = new Formmainmenu();
                         //          f.ShowDialog();
                         //     }
                         //     else
                         //     {
                         //          MessageBox.Show("      Đăng nhập thất bại");
                         //     }
                         //SqlConnection con = DataBase.GetConnection();
                         con4.Open();
                         SqlCommand cmd4 = new SqlCommand("CheckLogin", con4);
                         cmd4.CommandType = CommandType.StoredProcedure;
                         cmd4.Parameters.Add(new SqlParameter("@username", txttenDangnhap.Text));
                         cmd4.Parameters.Add(new SqlParameter("@password", txtMatKhau.Text));
                         using (SqlDataReader reader = cmd4.ExecuteReader())
                         {
                              reader.Read();
                              if (reader != null)
                              {
                                   fullname = (String)reader["fullname"];
                                   chucvu = (String)reader["chucvu"];
                                   username = (String)reader["username1"];
                                   //frmMain.mchucvu = (String)reader["chucvu"];
                                   //frmMain.musername = (String)reader["username1"];
                                   MessageBox.Show("Đăng nhập thành công!\nXin chào " + fullname, "Đăng nhập thành công !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                   Hide();
                              }
                              con4.Close();
                              Formmainmenu frm = new Formmainmenu();
                              frm.Show();
                         }
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Đăng nhập thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         con4.Close();
                    }
               }
          }
     }
}
