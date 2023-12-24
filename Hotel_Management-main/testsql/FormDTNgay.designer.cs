
namespace testsql
{
     partial class FormDTNgay
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
               this.components = new System.ComponentModel.Container();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDTNgay));
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
               System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
               System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
               this.datepick1 = new System.Windows.Forms.DateTimePicker();
               this.datepick2 = new System.Windows.Forms.DateTimePicker();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.dtgvNgay = new System.Windows.Forms.DataGridView();
               this.BDC = new System.Windows.Forms.DataVisualization.Charting.Chart();
               this.radioButton2 = new System.Windows.Forms.RadioButton();
               this.radioButton1 = new System.Windows.Forms.RadioButton();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.label4 = new System.Windows.Forms.Label();
               this.btnTimkiem = new Guna.UI2.WinForms.Guna2Button();
               this.btnXembieudo = new Guna.UI2.WinForms.Guna2Button();
               this.form2BindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
               this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
               this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
               ((System.ComponentModel.ISupportInitialize)(this.dtgvNgay)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.BDC)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).BeginInit();
               this.gunaLinePanel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
               this.SuspendLayout();
               // 
               // datepick1
               // 
               resources.ApplyResources(this.datepick1, "datepick1");
               this.datepick1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
               this.datepick1.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
               this.datepick1.Name = "datepick1";
               this.datepick1.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
               this.datepick1.ValueChanged += new System.EventHandler(this.datepick1_ValueChanged);
               // 
               // datepick2
               // 
               resources.ApplyResources(this.datepick2, "datepick2");
               this.datepick2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
               this.datepick2.Name = "datepick2";
               this.datepick2.ValueChanged += new System.EventHandler(this.datepick2_ValueChanged);
               // 
               // label1
               // 
               resources.ApplyResources(this.label1, "label1");
               this.label1.ForeColor = System.Drawing.Color.Navy;
               this.label1.Name = "label1";
               // 
               // label2
               // 
               resources.ApplyResources(this.label2, "label2");
               this.label2.ForeColor = System.Drawing.Color.Navy;
               this.label2.Name = "label2";
               // 
               // label3
               // 
               resources.ApplyResources(this.label3, "label3");
               this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
               this.label3.Name = "label3";
               // 
               // dtgvNgay
               // 
               this.dtgvNgay.AllowUserToAddRows = false;
               this.dtgvNgay.AllowUserToDeleteRows = false;
               this.dtgvNgay.AllowUserToResizeColumns = false;
               this.dtgvNgay.AllowUserToResizeRows = false;
               resources.ApplyResources(this.dtgvNgay, "dtgvNgay");
               this.dtgvNgay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
               this.dtgvNgay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
               dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
               dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
               dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
               dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.dtgvNgay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
               this.dtgvNgay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
               dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
               dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
               this.dtgvNgay.DefaultCellStyle = dataGridViewCellStyle2;
               this.dtgvNgay.Name = "dtgvNgay";
               this.dtgvNgay.RowHeadersVisible = false;
               this.dtgvNgay.RowTemplate.Height = 24;
               this.dtgvNgay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvNgay_CellClick);
               // 
               // BDC
               // 
               resources.ApplyResources(this.BDC, "BDC");
               chartArea1.Name = "ChartArea1";
               this.BDC.ChartAreas.Add(chartArea1);
               legend1.Enabled = false;
               legend1.Name = "Legend1";
               this.BDC.Legends.Add(legend1);
               this.BDC.Name = "BDC";
               series1.ChartArea = "ChartArea1";
               series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(100)))));
               series1.Legend = "Legend1";
               series1.Name = "bdc";
               series1.ShadowColor = System.Drawing.SystemColors.ActiveCaption;
               this.BDC.Series.Add(series1);
               this.BDC.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BDC_MouseMove);
               // 
               // radioButton2
               // 
               resources.ApplyResources(this.radioButton2, "radioButton2");
               this.radioButton2.Name = "radioButton2";
               this.radioButton2.TabStop = true;
               this.radioButton2.UseVisualStyleBackColor = true;
               this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
               // 
               // radioButton1
               // 
               resources.ApplyResources(this.radioButton1, "radioButton1");
               this.radioButton1.ForeColor = System.Drawing.Color.Navy;
               this.radioButton1.Name = "radioButton1";
               this.radioButton1.TabStop = true;
               this.radioButton1.UseVisualStyleBackColor = true;
               this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
               // 
               // textBox1
               // 
               resources.ApplyResources(this.textBox1, "textBox1");
               this.textBox1.Name = "textBox1";
               // 
               // label4
               // 
               resources.ApplyResources(this.label4, "label4");
               this.label4.ForeColor = System.Drawing.Color.Navy;
               this.label4.Name = "label4";
               // 
               // btnTimkiem
               // 
               this.btnTimkiem.AutoRoundedCorners = true;
               this.btnTimkiem.BorderRadius = 19;
               this.btnTimkiem.CheckedState.Parent = this.btnTimkiem;
               this.btnTimkiem.CustomImages.Parent = this.btnTimkiem;
               resources.ApplyResources(this.btnTimkiem, "btnTimkiem");
               this.btnTimkiem.ForeColor = System.Drawing.Color.White;
               this.btnTimkiem.HoverState.Parent = this.btnTimkiem;
               this.btnTimkiem.Name = "btnTimkiem";
               this.btnTimkiem.ShadowDecoration.Parent = this.btnTimkiem;
               this.btnTimkiem.Click += new System.EventHandler(this.btnTimKiem_Click);
               // 
               // btnXembieudo
               // 
               this.btnXembieudo.AutoRoundedCorners = true;
               this.btnXembieudo.BorderRadius = 19;
               this.btnXembieudo.CheckedState.Parent = this.btnXembieudo;
               this.btnXembieudo.CustomImages.Parent = this.btnXembieudo;
               resources.ApplyResources(this.btnXembieudo, "btnXembieudo");
               this.btnXembieudo.ForeColor = System.Drawing.Color.White;
               this.btnXembieudo.HoverState.Parent = this.btnXembieudo;
               this.btnXembieudo.Name = "btnXembieudo";
               this.btnXembieudo.ShadowDecoration.Parent = this.btnXembieudo;
               this.btnXembieudo.Click += new System.EventHandler(this.btnXembieudo_Click);
               // 
               // form2BindingSource
               // 
               this.form2BindingSource.DataSource = typeof(testsql.FormDTNgay);
               // 
               // gunaLinePanel1
               // 
               this.gunaLinePanel1.Controls.Add(this.bunifuImageButton2);
               this.gunaLinePanel1.Controls.Add(this.label3);
               this.gunaLinePanel1.Controls.Add(this.BDC);
               resources.ApplyResources(this.gunaLinePanel1, "gunaLinePanel1");
               this.gunaLinePanel1.ForeColor = System.Drawing.Color.Coral;
               this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
               this.gunaLinePanel1.LineTop = 40;
               this.gunaLinePanel1.Name = "gunaLinePanel1";
               // 
               // bunifuImageButton2
               // 
               this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               resources.ApplyResources(this.bunifuImageButton2, "bunifuImageButton2");
               this.bunifuImageButton2.ImageActive = null;
               this.bunifuImageButton2.Name = "bunifuImageButton2";
               this.bunifuImageButton2.TabStop = false;
               this.bunifuImageButton2.Zoom = 10;
               this.bunifuImageButton2.Click += new System.EventHandler(this.guna2ControlBox1_Click);
               // 
               // bunifuElipse1
               // 
               this.bunifuElipse1.ElipseRadius = 6;
               this.bunifuElipse1.TargetControl = this;
               // 
               // FormDTNgay
               // 
               resources.ApplyResources(this, "$this");
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
               this.Controls.Add(this.btnXembieudo);
               this.Controls.Add(this.btnTimkiem);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.radioButton1);
               this.Controls.Add(this.radioButton2);
               this.Controls.Add(this.dtgvNgay);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.datepick2);
               this.Controls.Add(this.datepick1);
               this.Controls.Add(this.gunaLinePanel1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "FormDTNgay";
               this.Load += new System.EventHandler(this.Form2_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dtgvNgay)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.BDC)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).EndInit();
               this.gunaLinePanel1.ResumeLayout(false);
               this.gunaLinePanel1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion
          private System.Windows.Forms.DateTimePicker datepick1;
          private System.Windows.Forms.DateTimePicker datepick2;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.DataGridView dtgvNgay;
          private System.Windows.Forms.DataVisualization.Charting.Chart BDC;
          private System.Windows.Forms.BindingSource form2BindingSource;
          private System.Windows.Forms.RadioButton radioButton2;
          private System.Windows.Forms.RadioButton radioButton1;
          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.Label label4;
          private Guna.UI2.WinForms.Guna2Button btnTimkiem;
          private Guna.UI2.WinForms.Guna2Button btnXembieudo;
          private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
          private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
          private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
     }
}