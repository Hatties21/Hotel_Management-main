
namespace testsql
{
    partial class FormDTThang
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
               System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
               System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
               System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
               System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDTThang));
               this.label3 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label1 = new System.Windows.Forms.Label();
               this.datepick2 = new System.Windows.Forms.DateTimePicker();
               this.dtgvThang = new System.Windows.Forms.DataGridView();
               this.DTThang = new System.Windows.Forms.DataVisualization.Charting.Chart();
               this.btnTimkiem = new Guna.UI2.WinForms.Guna2Button();
               this.btnXembieudo = new Guna.UI2.WinForms.Guna2Button();
               this.datepick1 = new System.Windows.Forms.DateTimePicker();
               this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
               this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
               ((System.ComponentModel.ISupportInitialize)(this.dtgvThang)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.DTThang)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
               this.gunaLinePanel1.SuspendLayout();
               this.SuspendLayout();
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
               this.label3.ForeColor = System.Drawing.SystemColors.Control;
               this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
               this.label3.Location = new System.Drawing.Point(7, 6);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(313, 28);
               this.label3.TabIndex = 22;
               this.label3.Text = "Thống kê doanh thu theo tháng";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.ForeColor = System.Drawing.Color.Red;
               this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
               this.label2.Location = new System.Drawing.Point(474, 76);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(128, 32);
               this.label2.TabIndex = 25;
               this.label2.Text = "Đến tháng";
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.Color.Red;
               this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
               this.label1.Location = new System.Drawing.Point(128, 76);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(111, 32);
               this.label1.TabIndex = 26;
               this.label1.Text = "Từ tháng";
               // 
               // datepick2
               // 
               this.datepick2.CustomFormat = "MM/yyyy";
               this.datepick2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
               this.datepick2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
               this.datepick2.Location = new System.Drawing.Point(637, 76);
               this.datepick2.Name = "datepick2";
               this.datepick2.ShowUpDown = true;
               this.datepick2.Size = new System.Drawing.Size(178, 34);
               this.datepick2.TabIndex = 24;
               // 
               // dtgvThang
               // 
               this.dtgvThang.AllowUserToAddRows = false;
               this.dtgvThang.AllowUserToDeleteRows = false;
               this.dtgvThang.AllowUserToResizeColumns = false;
               this.dtgvThang.AllowUserToResizeRows = false;
               this.dtgvThang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
               dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
               dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
               dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
               dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.dtgvThang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
               this.dtgvThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
               dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
               dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
               this.dtgvThang.DefaultCellStyle = dataGridViewCellStyle2;
               this.dtgvThang.Location = new System.Drawing.Point(3, 140);
               this.dtgvThang.Name = "dtgvThang";
               dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
               dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
               dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
               dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.dtgvThang.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
               this.dtgvThang.RowHeadersVisible = false;
               this.dtgvThang.RowHeadersWidth = 51;
               this.dtgvThang.RowTemplate.Height = 24;
               this.dtgvThang.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
               this.dtgvThang.Size = new System.Drawing.Size(270, 529);
               this.dtgvThang.TabIndex = 28;
               // 
               // DTThang
               // 
               this.DTThang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               chartArea1.Name = "theothang";
               this.DTThang.ChartAreas.Add(chartArea1);
               legend1.Enabled = false;
               legend1.Name = "Legend1";
               this.DTThang.Legends.Add(legend1);
               this.DTThang.Location = new System.Drawing.Point(277, 140);
               this.DTThang.Name = "DTThang";
               series1.ChartArea = "theothang";
               series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(100)))));
               series1.Legend = "Legend1";
               series1.Name = "theothang";
               series1.ShadowColor = System.Drawing.SystemColors.ActiveCaption;
               this.DTThang.Series.Add(series1);
               this.DTThang.Size = new System.Drawing.Size(1100, 524);
               this.DTThang.TabIndex = 29;
               this.DTThang.Text = "Biểu đồ doanh thu theo ngày";
               title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               title1.Name = "Title1";
               title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
               this.DTThang.Titles.Add(title1);
               this.DTThang.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DTThang_MouseMove);
               // 
               // btnTimkiem
               // 
               this.btnTimkiem.AutoRoundedCorners = true;
               this.btnTimkiem.BorderRadius = 21;
               this.btnTimkiem.CheckedState.Parent = this.btnTimkiem;
               this.btnTimkiem.CustomImages.Parent = this.btnTimkiem;
               this.btnTimkiem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnTimkiem.ForeColor = System.Drawing.Color.White;
               this.btnTimkiem.HoverState.Parent = this.btnTimkiem;
               this.btnTimkiem.Location = new System.Drawing.Point(870, 67);
               this.btnTimkiem.Name = "btnTimkiem";
               this.btnTimkiem.ShadowDecoration.Parent = this.btnTimkiem;
               this.btnTimkiem.Size = new System.Drawing.Size(180, 45);
               this.btnTimkiem.TabIndex = 34;
               this.btnTimkiem.Text = "Tìm kiếm";
               this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
               // 
               // btnXembieudo
               // 
               this.btnXembieudo.AutoRoundedCorners = true;
               this.btnXembieudo.BorderRadius = 21;
               this.btnXembieudo.CheckedState.Parent = this.btnXembieudo;
               this.btnXembieudo.CustomImages.Parent = this.btnXembieudo;
               this.btnXembieudo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnXembieudo.ForeColor = System.Drawing.Color.White;
               this.btnXembieudo.HoverState.Parent = this.btnXembieudo;
               this.btnXembieudo.Location = new System.Drawing.Point(1068, 67);
               this.btnXembieudo.Name = "btnXembieudo";
               this.btnXembieudo.ShadowDecoration.Parent = this.btnXembieudo;
               this.btnXembieudo.Size = new System.Drawing.Size(219, 45);
               this.btnXembieudo.TabIndex = 34;
               this.btnXembieudo.Text = "Xem biểu đồ";
               this.btnXembieudo.Click += new System.EventHandler(this.btnXembieudo_Click);
               // 
               // datepick1
               // 
               this.datepick1.CustomFormat = "MM/yyyy";
               this.datepick1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
               this.datepick1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
               this.datepick1.Location = new System.Drawing.Point(290, 76);
               this.datepick1.Name = "datepick1";
               this.datepick1.ShowUpDown = true;
               this.datepick1.Size = new System.Drawing.Size(178, 34);
               this.datepick1.TabIndex = 24;
               this.datepick1.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
               // 
               // bunifuImageButton1
               // 
               this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
               this.bunifuImageButton1.ImageActive = null;
               this.bunifuImageButton1.Location = new System.Drawing.Point(1340, 5);
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
               this.gunaLinePanel1.Controls.Add(this.label3);
               this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
               this.gunaLinePanel1.LineTop = 40;
               this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
               this.gunaLinePanel1.Name = "gunaLinePanel1";
               this.gunaLinePanel1.Size = new System.Drawing.Size(1377, 680);
               this.gunaLinePanel1.TabIndex = 39;
               // 
               // FormDTThang
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1377, 680);
               this.Controls.Add(this.bunifuImageButton1);
               this.Controls.Add(this.btnXembieudo);
               this.Controls.Add(this.btnTimkiem);
               this.Controls.Add(this.DTThang);
               this.Controls.Add(this.dtgvThang);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.datepick1);
               this.Controls.Add(this.datepick2);
               this.Controls.Add(this.gunaLinePanel1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.Name = "FormDTThang";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Form3";
               this.Load += new System.EventHandler(this.Form3_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dtgvThang)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.DTThang)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
               this.gunaLinePanel1.ResumeLayout(false);
               this.gunaLinePanel1.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datepick2;
        private System.Windows.Forms.DataGridView dtgvThang;
        private System.Windows.Forms.DataVisualization.Charting.Chart DTThang;
        private Guna.UI2.WinForms.Guna2Button btnTimkiem;
        private Guna.UI2.WinForms.Guna2Button btnXembieudo;
        private System.Windows.Forms.DateTimePicker datepick1;
          private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
          private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
     }
}