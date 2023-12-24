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
    public partial class Formdoimatkhauuser : Form
    {
        public Formmainmenu frmMain;
        public Formdoimatkhauuser()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormDoiMk_Load(object sender, EventArgs e)
        {

            lblUser.Text = FormLogin.username;
            btnXacnhan.Enabled = true;
        }
        SqlConnection con = new SqlConnection(@"Data Source=DONG_TRAN\DONGTRANSQL;Initial Catalog = QUANLIHOTEL;Persist Security Info = True;User ID=sa;Password=141192");
          private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
               try
               {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("CheckLogin", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@username", FormLogin.username));
                    cmd.Parameters.Add(new SqlParameter("@password", txtMkc.Text));
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                         if (reader.Read())
                         {
                              reader.Close();
                              SqlCommand cmd2 = new SqlCommand("ChangePass", con);
                              cmd2.CommandType = CommandType.StoredProcedure;
                              cmd2.Parameters.Add(new SqlParameter("@username", FormLogin.username));
                              cmd2.Parameters.Add(new SqlParameter("@password", txtMkm2.Text));
                              try
                              {
                                   SqlDataReader reader2 = cmd2.ExecuteReader();
                                   MessageBox.Show("Đổi mật khẩu thành công!", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                   reader2.Close();
                              }
                              catch (Exception ex)
                              {
                                   MessageBox.Show("" + ex, "Lỗi");
                              }
                              con.Close();
                         }
                         else
                              MessageBox.Show("Mật khẩu cũ không chính xác", "Đổi mật khẩu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         reader.Close();
                    }
          }
          catch (Exception ex)
          {

               MessageBox.Show("Bạn chưa đổi mật khẩu!", "Đổi mật khẩu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
               con.Close();

          }

}
     private void txtMkm2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtMkm.Text != txtMkm2.Text || txtMkm.Text == "")
            {
                btnXacnhan.Enabled = false;
                batloi.SetError(txtMkm2, "Mật khẩu không khớp!");
            }
            else
            {
                btnXacnhan.Enabled = true;
                batloi.SetError(txtMkm2, "");
            }
        }

        private void txtMkm_KeyUp(object sender, KeyEventArgs e)
        {
            txtMkm2_KeyUp(sender, e);
        }

          private void gunaLabel3_Click(object sender, EventArgs e)
          {

          }

          private void btnHuy_Click_1(object sender, EventArgs e)
          {
               this.Close();
          }

          private void bunifuImageButton1_Click(object sender, EventArgs e)
          {
               this.Close();
               //Formmainmenu.instance.ShowDialog();
          }
     }
}
