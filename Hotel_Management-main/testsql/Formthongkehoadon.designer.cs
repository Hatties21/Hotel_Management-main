
namespace testsql
{
     partial class Form6
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
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
               this.label1 = new System.Windows.Forms.Label();
               this.dgv6 = new Guna.UI2.WinForms.Guna2DataGridView();
               this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Map = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.lb = new Guna.UI2.WinForms.Guna2HtmlLabel();
               this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
               this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
               this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
               ((System.ComponentModel.ISupportInitialize)(this.dgv6)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
               this.gunaLinePanel1.SuspendLayout();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(344, 50);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(676, 69);
               this.label1.TabIndex = 1;
               this.label1.Text = "DANH SÁCH HÓA ĐƠN";
               // 
               // dgv6
               // 
               dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
               this.dgv6.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
               this.dgv6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dgv6.BackgroundColor = System.Drawing.Color.White;
               this.dgv6.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.dgv6.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
               this.dgv6.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
               dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
               dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
               dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
               dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.dgv6.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
               this.dgv6.ColumnHeadersHeight = 35;
               this.dgv6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahd,
            this.manv,
            this.tenkh,
            this.Map,
            this.Column1,
            this.Column2,
            this.tongtien});
               dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
               dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
               dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
               dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
               dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
               dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
               this.dgv6.DefaultCellStyle = dataGridViewCellStyle3;
               this.dgv6.EnableHeadersVisualStyles = false;
               this.dgv6.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
               this.dgv6.Location = new System.Drawing.Point(12, 164);
               this.dgv6.Name = "dgv6";
               this.dgv6.RowHeadersVisible = false;
               this.dgv6.RowHeadersWidth = 51;
               this.dgv6.RowTemplate.Height = 24;
               this.dgv6.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.dgv6.Size = new System.Drawing.Size(1286, 614);
               this.dgv6.TabIndex = 3;
               this.dgv6.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
               this.dgv6.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
               this.dgv6.ThemeStyle.AlternatingRowsStyle.Font = null;
               this.dgv6.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
               this.dgv6.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
               this.dgv6.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
               this.dgv6.ThemeStyle.BackColor = System.Drawing.Color.White;
               this.dgv6.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
               this.dgv6.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
               this.dgv6.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
               this.dgv6.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
               this.dgv6.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
               this.dgv6.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
               this.dgv6.ThemeStyle.HeaderStyle.Height = 35;
               this.dgv6.ThemeStyle.ReadOnly = false;
               this.dgv6.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
               this.dgv6.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
               this.dgv6.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
               this.dgv6.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
               this.dgv6.ThemeStyle.RowsStyle.Height = 24;
               this.dgv6.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
               this.dgv6.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
               this.dgv6.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv6_CellClick);
               this.dgv6.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv6_CellFormatting);
               this.dgv6.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv6_CellPainting);
               // 
               // mahd
               // 
               this.mahd.DataPropertyName = "Mã hóa đơn";
               this.mahd.HeaderText = "Mã hóa đơn";
               this.mahd.MinimumWidth = 6;
               this.mahd.Name = "mahd";
               // 
               // manv
               // 
               this.manv.DataPropertyName = "Tên nhân viên";
               this.manv.FillWeight = 120F;
               this.manv.HeaderText = "Nhân viên lập hóa đơn";
               this.manv.MinimumWidth = 6;
               this.manv.Name = "manv";
               // 
               // tenkh
               // 
               this.tenkh.DataPropertyName = "Tên khách hàng";
               this.tenkh.HeaderText = "Tên khách hàng";
               this.tenkh.MinimumWidth = 6;
               this.tenkh.Name = "tenkh";
               // 
               // Map
               // 
               this.Map.DataPropertyName = "Mã phòng";
               this.Map.HeaderText = "Mã phòng";
               this.Map.MinimumWidth = 6;
               this.Map.Name = "Map";
               // 
               // Column1
               // 
               this.Column1.DataPropertyName = "Tiền dịch vụ";
               this.Column1.HeaderText = "Tiền dịch vụ";
               this.Column1.MinimumWidth = 6;
               this.Column1.Name = "Column1";
               // 
               // Column2
               // 
               this.Column2.DataPropertyName = "Tiền phòng";
               this.Column2.HeaderText = "Tiền phòng";
               this.Column2.MinimumWidth = 6;
               this.Column2.Name = "Column2";
               // 
               // tongtien
               // 
               this.tongtien.DataPropertyName = "Tổng tiền";
               this.tongtien.HeaderText = "Tổng tiền";
               this.tongtien.MinimumWidth = 6;
               this.tongtien.Name = "tongtien";
               // 
               // lb
               // 
               this.lb.BackColor = System.Drawing.Color.Transparent;
               this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lb.Location = new System.Drawing.Point(675, 131);
               this.lb.Name = "lb";
               this.lb.Size = new System.Drawing.Size(156, 27);
               this.lb.TabIndex = 4;
               this.lb.Text = "guna2HtmlLabel1";
               this.lb.Click += new System.EventHandler(this.lb_Click);
               // 
               // guna2HtmlLabel1
               // 
               this.guna2HtmlLabel1.AutoSize = false;
               this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
               this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.guna2HtmlLabel1.Location = new System.Drawing.Point(509, 131);
               this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
               this.guna2HtmlLabel1.Size = new System.Drawing.Size(163, 27);
               this.guna2HtmlLabel1.TabIndex = 5;
               this.guna2HtmlLabel1.Text = "Ngày khảo sát:                         ";
               // 
               // bunifuImageButton1
               // 
               this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
               this.bunifuImageButton1.ImageActive = null;
               this.bunifuImageButton1.Location = new System.Drawing.Point(1277, 3);
               this.bunifuImageButton1.Name = "bunifuImageButton1";
               this.bunifuImageButton1.Size = new System.Drawing.Size(30, 30);
               this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.bunifuImageButton1.TabIndex = 38;
               this.bunifuImageButton1.TabStop = false;
               this.bunifuImageButton1.Zoom = 10;
               this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
               // 
               // gunaLinePanel1
               // 
               this.gunaLinePanel1.Controls.Add(this.bunifuImageButton1);
               this.gunaLinePanel1.Controls.Add(this.dgv6);
               this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
               this.gunaLinePanel1.LineTop = 40;
               this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
               this.gunaLinePanel1.Name = "gunaLinePanel1";
               this.gunaLinePanel1.Size = new System.Drawing.Size(1310, 790);
               this.gunaLinePanel1.TabIndex = 39;
               // 
               // Form6
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1310, 790);
               this.Controls.Add(this.guna2HtmlLabel1);
               this.Controls.Add(this.lb);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.gunaLinePanel1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.Name = "Form6";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Form6";
               this.Load += new System.EventHandler(this.Form6_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dgv6)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
               this.gunaLinePanel1.ResumeLayout(false);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion
          private System.Windows.Forms.Label label1;
          private Guna.UI2.WinForms.Guna2DataGridView dgv6;
          private Guna.UI2.WinForms.Guna2HtmlLabel lb;
          private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
          private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
          private System.Windows.Forms.DataGridViewTextBoxColumn manv;
          private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
          private System.Windows.Forms.DataGridViewTextBoxColumn Map;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
          private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
          private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
          private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
     }
}