
namespace testsql
{
    partial class Formtrangthaiphong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formtrangthaiphong));
               this.btndichvu = new Guna.UI2.WinForms.Guna2Button();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
               this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
               this.lbtenkh = new Guna.UI.WinForms.GunaLabel();
               this.ttphong = new Guna.UI.WinForms.GunaLabel();
               this.lbloai = new Guna.UI.WinForms.GunaLabel();
               this.lbtenphong = new Guna.UI.WinForms.GunaLabel();
               this.lbma = new Guna.UI.WinForms.GunaLabel();
               this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
               this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
               this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
               this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
               this.btnthongtin = new Guna.UI2.WinForms.Guna2Button();
               this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
               this.BTNDONG = new Bunifu.Framework.UI.BunifuImageButton();
               this.groupBox1.SuspendLayout();
               this.gunaLinePanel1.SuspendLayout();
               this.gunaPanel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.BTNDONG)).BeginInit();
               this.SuspendLayout();
               // 
               // btndichvu
               // 
               this.btndichvu.AutoRoundedCorners = true;
               this.btndichvu.BorderRadius = 21;
               this.btndichvu.CheckedState.Parent = this.btndichvu;
               this.btndichvu.CustomImages.Parent = this.btndichvu;
               this.btndichvu.Font = new System.Drawing.Font("Segoe UI", 9F);
               this.btndichvu.ForeColor = System.Drawing.Color.White;
               this.btndichvu.HoverState.Parent = this.btndichvu;
               this.btndichvu.Location = new System.Drawing.Point(282, 264);
               this.btndichvu.Name = "btndichvu";
               this.btndichvu.ShadowDecoration.Parent = this.btndichvu;
               this.btndichvu.Size = new System.Drawing.Size(171, 45);
               this.btndichvu.TabIndex = 15;
               this.btndichvu.Text = "Gọi dịch vụ";
               this.btndichvu.Click += new System.EventHandler(this.guna2Button3_Click);
               // 
               // groupBox1
               // 
               this.groupBox1.BackColor = System.Drawing.Color.White;
               this.groupBox1.Controls.Add(this.gunaLabel3);
               this.groupBox1.Controls.Add(this.gunaLabel4);
               this.groupBox1.Controls.Add(this.lbtenkh);
               this.groupBox1.Controls.Add(this.ttphong);
               this.groupBox1.Controls.Add(this.lbloai);
               this.groupBox1.Controls.Add(this.lbtenphong);
               this.groupBox1.Controls.Add(this.lbma);
               this.groupBox1.Controls.Add(this.gunaLabel2);
               this.groupBox1.Controls.Add(this.gunaLabel1);
               this.groupBox1.Controls.Add(this.gunaLabel5);
               this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
               this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
               this.groupBox1.Location = new System.Drawing.Point(50, 57);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Size = new System.Drawing.Size(431, 201);
               this.groupBox1.TabIndex = 16;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "THÔNG TIN PHÒNG";
               // 
               // gunaLabel3
               // 
               this.gunaLabel3.AutoSize = true;
               this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
               this.gunaLabel3.Location = new System.Drawing.Point(18, 166);
               this.gunaLabel3.Name = "gunaLabel3";
               this.gunaLabel3.Size = new System.Drawing.Size(118, 20);
               this.gunaLabel3.TabIndex = 21;
               this.gunaLabel3.Text = "Tên khách hàng: ";
               // 
               // gunaLabel4
               // 
               this.gunaLabel4.AutoSize = true;
               this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
               this.gunaLabel4.Location = new System.Drawing.Point(18, 135);
               this.gunaLabel4.Name = "gunaLabel4";
               this.gunaLabel4.Size = new System.Drawing.Size(79, 20);
               this.gunaLabel4.TabIndex = 21;
               this.gunaLabel4.Text = "Tình trạng:";
               // 
               // lbtenkh
               // 
               this.lbtenkh.AutoSize = true;
               this.lbtenkh.Font = new System.Drawing.Font("Segoe UI", 9F);
               this.lbtenkh.Location = new System.Drawing.Point(176, 166);
               this.lbtenkh.Name = "lbtenkh";
               this.lbtenkh.Size = new System.Drawing.Size(101, 20);
               this.lbtenkh.TabIndex = 20;
               this.lbtenkh.Text = "tenkhachhang";
               // 
               // ttphong
               // 
               this.ttphong.AutoSize = true;
               this.ttphong.Font = new System.Drawing.Font("Segoe UI", 9F);
               this.ttphong.Location = new System.Drawing.Point(176, 135);
               this.ttphong.Name = "ttphong";
               this.ttphong.Size = new System.Drawing.Size(69, 20);
               this.ttphong.TabIndex = 20;
               this.ttphong.Text = "tinhtrang";
               // 
               // lbloai
               // 
               this.lbloai.AutoSize = true;
               this.lbloai.Font = new System.Drawing.Font("Segoe UI", 9F);
               this.lbloai.Location = new System.Drawing.Point(176, 101);
               this.lbloai.Name = "lbloai";
               this.lbloai.Size = new System.Drawing.Size(77, 20);
               this.lbloai.TabIndex = 19;
               this.lbloai.Text = "loaiphong";
               // 
               // lbtenphong
               // 
               this.lbtenphong.AutoSize = true;
               this.lbtenphong.Font = new System.Drawing.Font("Segoe UI", 9F);
               this.lbtenphong.Location = new System.Drawing.Point(176, 38);
               this.lbtenphong.Name = "lbtenphong";
               this.lbtenphong.Size = new System.Drawing.Size(73, 20);
               this.lbtenphong.TabIndex = 18;
               this.lbtenphong.Text = "tenphong";
               // 
               // lbma
               // 
               this.lbma.AutoSize = true;
               this.lbma.Font = new System.Drawing.Font("Segoe UI", 9F);
               this.lbma.Location = new System.Drawing.Point(176, 70);
               this.lbma.Name = "lbma";
               this.lbma.Size = new System.Drawing.Size(73, 20);
               this.lbma.TabIndex = 17;
               this.lbma.Text = "maphong";
               // 
               // gunaLabel2
               // 
               this.gunaLabel2.AutoSize = true;
               this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
               this.gunaLabel2.Location = new System.Drawing.Point(18, 101);
               this.gunaLabel2.Name = "gunaLabel2";
               this.gunaLabel2.Size = new System.Drawing.Size(111, 20);
               this.gunaLabel2.TabIndex = 16;
               this.gunaLabel2.Text = "Tên loại phòng:";
               // 
               // gunaLabel1
               // 
               this.gunaLabel1.AutoSize = true;
               this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
               this.gunaLabel1.Location = new System.Drawing.Point(18, 70);
               this.gunaLabel1.Name = "gunaLabel1";
               this.gunaLabel1.Size = new System.Drawing.Size(80, 20);
               this.gunaLabel1.TabIndex = 15;
               this.gunaLabel1.Text = "Mã phòng:";
               // 
               // gunaLabel5
               // 
               this.gunaLabel5.AutoSize = true;
               this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
               this.gunaLabel5.Location = new System.Drawing.Point(18, 38);
               this.gunaLabel5.Name = "gunaLabel5";
               this.gunaLabel5.Size = new System.Drawing.Size(82, 20);
               this.gunaLabel5.TabIndex = 14;
               this.gunaLabel5.Text = "Tên phòng:";
               // 
               // gunaLinePanel1
               // 
               this.gunaLinePanel1.BackColor = System.Drawing.Color.White;
               this.gunaLinePanel1.Controls.Add(this.btnthongtin);
               this.gunaLinePanel1.Controls.Add(this.groupBox1);
               this.gunaLinePanel1.Controls.Add(this.gunaPanel1);
               this.gunaLinePanel1.Controls.Add(this.btndichvu);
               this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.gunaLinePanel1.LineBottom = 5;
               this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.gunaLinePanel1.LineLeft = 5;
               this.gunaLinePanel1.LineRight = 5;
               this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
               this.gunaLinePanel1.LineTop = 5;
               this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
               this.gunaLinePanel1.Name = "gunaLinePanel1";
               this.gunaLinePanel1.Size = new System.Drawing.Size(531, 323);
               this.gunaLinePanel1.TabIndex = 18;
               // 
               // btnthongtin
               // 
               this.btnthongtin.AutoRoundedCorners = true;
               this.btnthongtin.BorderRadius = 21;
               this.btnthongtin.CheckedState.Parent = this.btnthongtin;
               this.btnthongtin.CustomImages.Parent = this.btnthongtin;
               this.btnthongtin.Font = new System.Drawing.Font("Segoe UI", 9F);
               this.btnthongtin.ForeColor = System.Drawing.Color.White;
               this.btnthongtin.HoverState.Parent = this.btnthongtin;
               this.btnthongtin.Location = new System.Drawing.Point(72, 264);
               this.btnthongtin.Name = "btnthongtin";
               this.btnthongtin.ShadowDecoration.Parent = this.btnthongtin;
               this.btnthongtin.Size = new System.Drawing.Size(171, 45);
               this.btnthongtin.TabIndex = 17;
               this.btnthongtin.Text = "Thông tin phiếu thuê";
               this.btnthongtin.Click += new System.EventHandler(this.btnthongtin_Click);
               // 
               // gunaPanel1
               // 
               this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.gunaPanel1.Controls.Add(this.BTNDONG);
               this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
               this.gunaPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
               this.gunaPanel1.Name = "gunaPanel1";
               this.gunaPanel1.Size = new System.Drawing.Size(531, 40);
               this.gunaPanel1.TabIndex = 12;
               // 
               // BTNDONG
               // 
               this.BTNDONG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.BTNDONG.Image = ((System.Drawing.Image)(resources.GetObject("BTNDONG.Image")));
               this.BTNDONG.ImageActive = null;
               this.BTNDONG.Location = new System.Drawing.Point(498, 3);
               this.BTNDONG.Name = "BTNDONG";
               this.BTNDONG.Size = new System.Drawing.Size(30, 30);
               this.BTNDONG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.BTNDONG.TabIndex = 37;
               this.BTNDONG.TabStop = false;
               this.BTNDONG.Zoom = 10;
               this.BTNDONG.Click += new System.EventHandler(this.BTNDONG_Click);
               // 
               // Formtrangthaiphong
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
               this.AutoSize = true;
               this.BackColor = System.Drawing.Color.GhostWhite;
               this.ClientSize = new System.Drawing.Size(531, 323);
               this.Controls.Add(this.gunaLinePanel1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "Formtrangthaiphong";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "FormPhong";
               this.Load += new System.EventHandler(this.Formtrangthaiphong_Load);
               this.groupBox1.ResumeLayout(false);
               this.groupBox1.PerformLayout();
               this.gunaLinePanel1.ResumeLayout(false);
               this.gunaPanel1.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.BTNDONG)).EndInit();
               this.ResumeLayout(false);

        }

        #endregion
          private Guna.UI2.WinForms.Guna2Button btndichvu;
          private System.Windows.Forms.GroupBox groupBox1;
          private Guna.UI.WinForms.GunaLabel gunaLabel2;
          private Guna.UI.WinForms.GunaLabel gunaLabel1;
          private Guna.UI.WinForms.GunaLabel gunaLabel5;
          private Guna.UI.WinForms.GunaLabel lbtenphong;
          private Guna.UI.WinForms.GunaLabel lbma;
          private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
          private Guna.UI.WinForms.GunaPanel gunaPanel1;
          private Bunifu.Framework.UI.BunifuImageButton BTNDONG;
          private Guna.UI.WinForms.GunaLabel lbloai;
          private Guna.UI.WinForms.GunaLabel gunaLabel4;
          private Guna.UI.WinForms.GunaLabel ttphong;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel tenkh;
        private Guna.UI.WinForms.GunaLabel lbtenkh;
          private Guna.UI2.WinForms.Guna2Button btnthongtin;
     }
}