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

namespace testsql
{
    public partial class FormQLPhong : Form
    {
        public FormQLPhong()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DONG_TRAN\\DONGTRANSQL;Initial Catalog = QUANLIHOTEL;Persist Security Info = True;User ID=sa;Password=141192");
        SqlCommand cmd = new SqlCommand();
        DataTable table1 = new DataTable();
        private void FormQLPhong_Load(object sender, EventArgs e)
        {

            show(0);
            fillPhong();
        }
        public void fillPhong()
        {
            try
            {
                DataTable DT = (DataTable)dtgvPhong.DataSource;
                if (DT != null)
                    DT.Clear();
                con.Open();
                string query2 = "SELECT maphong as 'Mã phòng', tenphong as 'Tên phòng', tenloaiphong as 'Loại phòng', convert(int,gia) as 'Giá' from phong,loaiphong where phong.maloaiphong = loaiphong.maloaiphong";
                SqlCommand sqlDa = new SqlCommand(query2, con);
                sqlDa.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(query2, con);
                adapter.Fill(table1);
                dtgvPhong.DataSource = table1;
                string query = "SELECT count(*) FROM phong";
                cmd = new SqlCommand(query, con);
                int sldv = (int)cmd.ExecuteScalar();
                txtSLP.Text = sldv.ToString();
                con.Close();
                clear();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Đã có lỗi xẩy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }
        public void tudien()
        {

            if (txtLP.Text != "")
            {
                try
                {
                    con.Open();
                    string query = "Select gia from loaiphong where tenloaiphong = N'" + txtLP.Text + "'";
                    cmd = new SqlCommand(query, con);
                    decimal gia = (decimal)cmd.ExecuteScalar();
                    txtGia.Text = gia.ToString();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
            else txtGia.Text = null;

        }
        public void show(int a)
        {
            if(a ==0)
            {
                btnSua.Enabled = false;
                txtGia.Enabled = false;
                txtLP.Enabled = false; 
                txtMP.Enabled = false;
                txtTenP.Enabled = false;
            }
            else
            {
                btnSua.Enabled = true;
                txtGia.Enabled = true;
                txtLP.Enabled = true;
                txtMP.Enabled = true;
                txtTenP.Enabled = true;
            }
        }
        public void clear()
        {
            txtTenP.Text = "";
            txtMP.Text = "";
            txtGia.Text = "";
            txtFind.Text = "";
            txtLP.Text = null;
        }
        public bool checkNull()
        {
            if (string.IsNullOrEmpty(txtMP.Text))
            {
                MessageBox.Show("Hãy nhập mã phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMP.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenP.Text))
            {
                MessageBox.Show("Hãy nhập tên phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenP.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtLP.Text))
            {
                MessageBox.Show("Hãy nhập tên loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLP.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtGia.Text))
            {
                MessageBox.Show("Hãy nhập giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGia.Focus();
                return false;
            }
            return true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_SuaPhong";
                cmd.Parameters.Add(new SqlParameter("@maphong", txtMP.Text));
                cmd.Parameters.Add(new SqlParameter("@tenphong", txtTenP.Text));
                cmd.Parameters.Add(new SqlParameter("@tenlp", txtLP.Text));
                if (MessageBox.Show("Bạn có muốn sửa thông tin phòng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật phòng thành công!");
                }
                con.Close();
                fillPhong();
            }
            catch
            {
                MessageBox.Show("Đã xẩy ra lỗi!");
                //MessageBox.Show(ex.Message);
                con.Close();
            }

        }


        private void dtgvDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            show(1);
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMP.Text = dtgvPhong.Rows[index].Cells[0].Value.ToString();
                txtTenP.Text = dtgvPhong.Rows[index].Cells[1].Value.ToString();
                txtLP.Text = dtgvPhong.Rows[index].Cells[2].Value.ToString();
                txtGia.Text = dtgvPhong.Rows[index].Cells[3].Value.ToString();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            show(0);
            fillPhong();

        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            string query="";
            if(cbChon.Text == "Tên phòng")
            {
               query = "select maphong as 'Mã phòng', tenphong as 'Tên phòng', tenloaiphong as 'Loại phòng', gia as 'Giá' from phong,loaiphong where  tenphong like N'%" + txtFind.Text + "%' and phong.maloaiphong = loaiphong.maloaiphong";
            }
            else if(cbChon.Text == "Loại phòng"){
               query = "select maphong as 'Mã phòng', tenphong as 'Tên phòng', tenloaiphong as 'Loại phòng', gia as 'Giá' from phong,loaiphong where  tenloaiphong like N'%" + txtFind.Text + "%' and phong.maloaiphong = loaiphong.maloaiphong";
            }
            if (txtFind.Text != "")
            {
                try
                {
                    DataTable DT = (DataTable)dtgvPhong.DataSource;
                    if (DT != null)
                        DT.Clear();
                    con.Open();
                    SqlCommand sqlDa = new SqlCommand(query, con);
                    sqlDa.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    adapter.Fill(table1);
                    dtgvPhong.DataSource = table1;
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Đã xẩy ra lỗi!");
                    con.Close();
                }
            }
            else fillPhong();
            
        }
        private void txtLP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtLP_SelectedValueChanged(object sender, EventArgs e)
        {
           tudien();
            //txtSLP.Text = txtLP.Text;
        }


    }
}