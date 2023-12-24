namespace testsql
{
     partial class Forminphieuthue
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forminphieuthue));
               this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
               this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
               this.label2 = new System.Windows.Forms.Label();
               this.groupBox6 = new System.Windows.Forms.GroupBox();
               this.listViewUseService = new System.Windows.Forms.ListView();
               this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
               this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
               this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
               this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
               this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
               this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
               this.lblRoomPrice_ = new System.Windows.Forms.Label();
               this.label18 = new System.Windows.Forms.Label();
               this.lblDateCheckIn = new System.Windows.Forms.Label();
               this.label17 = new System.Windows.Forms.Label();
               this.lblRoomTypeName = new System.Windows.Forms.Label();
               this.label16 = new System.Windows.Forms.Label();
               this.lblRoomName = new System.Windows.Forms.Label();
               this.label15 = new System.Windows.Forms.Label();
               this.lblAddress = new System.Windows.Forms.Label();
               this.label12 = new System.Windows.Forms.Label();
               this.lblPhoneNumber = new System.Windows.Forms.Label();
               this.label11 = new System.Windows.Forms.Label();
               this.lblIDCard = new System.Windows.Forms.Label();
               this.label10 = new System.Windows.Forms.Label();
               this.lblCustomerName = new System.Windows.Forms.Label();
               this.label9 = new System.Windows.Forms.Label();
               this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
               this.lblDateCreate = new System.Windows.Forms.Label();
               this.lblCustom = new System.Windows.Forms.Label();
               this.lblStaffSetUp = new System.Windows.Forms.Label();
               this.label7 = new System.Windows.Forms.Label();
               this.lblIDBill = new System.Windows.Forms.Label();
               this.label6 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.btnPrint = new Bunifu.Framework.UI.BunifuThinButton2();
               this.btnClose_ = new Bunifu.Framework.UI.BunifuThinButton2();
               this.printDocument1 = new System.Drawing.Printing.PrintDocument();
               this.printDialog1 = new System.Windows.Forms.PrintDialog();
               ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
               this.groupBox6.SuspendLayout();
               this.SuspendLayout();
               // 
               // bunifuDragControl1
               // 
               this.bunifuDragControl1.Fixed = true;
               this.bunifuDragControl1.Horizontal = true;
               this.bunifuDragControl1.TargetControl = this;
               this.bunifuDragControl1.Vertical = true;
               // 
               // btnClose
               // 
               this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.btnClose.BackColor = System.Drawing.Color.Transparent;
               this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
               this.btnClose.ImageActive = null;
               this.btnClose.Location = new System.Drawing.Point(916, 7);
               this.btnClose.Margin = new System.Windows.Forms.Padding(4);
               this.btnClose.Name = "btnClose";
               this.btnClose.Size = new System.Drawing.Size(21, 20);
               this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.btnClose.TabIndex = 35;
               this.btnClose.TabStop = false;
               this.btnClose.Zoom = 10;
               this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.label2.Location = new System.Drawing.Point(4, 0);
               this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(199, 41);
               this.label2.TabIndex = 33;
               this.label2.Text = "In Phiếu Thuê";
               // 
               // groupBox6
               // 
               this.groupBox6.Controls.Add(this.listViewUseService);
               this.groupBox6.Controls.Add(this.bunifuSeparator2);
               this.groupBox6.Controls.Add(this.lblRoomPrice_);
               this.groupBox6.Controls.Add(this.label18);
               this.groupBox6.Controls.Add(this.lblDateCheckIn);
               this.groupBox6.Controls.Add(this.label17);
               this.groupBox6.Controls.Add(this.lblRoomTypeName);
               this.groupBox6.Controls.Add(this.label16);
               this.groupBox6.Controls.Add(this.lblRoomName);
               this.groupBox6.Controls.Add(this.label15);
               this.groupBox6.Controls.Add(this.lblAddress);
               this.groupBox6.Controls.Add(this.label12);
               this.groupBox6.Controls.Add(this.lblPhoneNumber);
               this.groupBox6.Controls.Add(this.label11);
               this.groupBox6.Controls.Add(this.lblIDCard);
               this.groupBox6.Controls.Add(this.label10);
               this.groupBox6.Controls.Add(this.lblCustomerName);
               this.groupBox6.Controls.Add(this.label9);
               this.groupBox6.Controls.Add(this.bunifuSeparator1);
               this.groupBox6.Controls.Add(this.lblDateCreate);
               this.groupBox6.Controls.Add(this.lblCustom);
               this.groupBox6.Controls.Add(this.lblStaffSetUp);
               this.groupBox6.Controls.Add(this.label7);
               this.groupBox6.Controls.Add(this.lblIDBill);
               this.groupBox6.Controls.Add(this.label6);
               this.groupBox6.Controls.Add(this.label5);
               this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 12F);
               this.groupBox6.ForeColor = System.Drawing.Color.SeaGreen;
               this.groupBox6.Location = new System.Drawing.Point(8, 34);
               this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
               this.groupBox6.Name = "groupBox6";
               this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
               this.groupBox6.Size = new System.Drawing.Size(928, 647);
               this.groupBox6.TabIndex = 36;
               this.groupBox6.TabStop = false;
               // 
               // listViewUseService
               // 
               this.listViewUseService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
               this.listViewUseService.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.listViewUseService.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
               this.listViewUseService.Font = new System.Drawing.Font("Segoe UI", 8.25F);
               this.listViewUseService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.listViewUseService.FullRowSelect = true;
               this.listViewUseService.GridLines = true;
               this.listViewUseService.Location = new System.Drawing.Point(42, 298);
               this.listViewUseService.Margin = new System.Windows.Forms.Padding(4);
               this.listViewUseService.Name = "listViewUseService";
               this.listViewUseService.Size = new System.Drawing.Size(841, 341);
               this.listViewUseService.TabIndex = 100;
               this.listViewUseService.UseCompatibleStateImageBehavior = false;
               this.listViewUseService.View = System.Windows.Forms.View.Details;
               // 
               // columnHeader1
               // 
               this.columnHeader1.Text = "STT";
               this.columnHeader1.Width = 40;
               // 
               // columnHeader2
               // 
               this.columnHeader2.Text = "Mã Phòng";
               this.columnHeader2.Width = 181;
               // 
               // columnHeader3
               // 
               this.columnHeader3.Text = "Tên Phòng";
               this.columnHeader3.Width = 117;
               // 
               // columnHeader4
               // 
               this.columnHeader4.Text = "Loại Phòng";
               this.columnHeader4.Width = 202;
               // 
               // columnHeader5
               // 
               this.columnHeader5.Text = "Đơn Giá";
               this.columnHeader5.Width = 311;
               // 
               // bunifuSeparator2
               // 
               this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
               this.bunifuSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.bunifuSeparator2.LineThickness = 5740;
               this.bunifuSeparator2.Location = new System.Drawing.Point(23, 271);
               this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(11, 18, 11, 18);
               this.bunifuSeparator2.Name = "bunifuSeparator2";
               this.bunifuSeparator2.Size = new System.Drawing.Size(878, 5);
               this.bunifuSeparator2.TabIndex = 99;
               this.bunifuSeparator2.Transparency = 255;
               this.bunifuSeparator2.Vertical = false;
               // 
               // lblRoomPrice_
               // 
               this.lblRoomPrice_.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblRoomPrice_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.lblRoomPrice_.Location = new System.Drawing.Point(629, 185);
               this.lblRoomPrice_.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.lblRoomPrice_.Name = "lblRoomPrice_";
               this.lblRoomPrice_.Size = new System.Drawing.Size(216, 21);
               this.lblRoomPrice_.TabIndex = 92;
               this.lblRoomPrice_.Text = "Mã hóa đơn";
               // 
               // label18
               // 
               this.label18.AutoSize = true;
               this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.label18.Location = new System.Drawing.Point(487, 185);
               this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label18.Name = "label18";
               this.label18.Size = new System.Drawing.Size(74, 23);
               this.label18.TabIndex = 91;
               this.label18.Text = "Đơn giá:";
               // 
               // lblDateCheckIn
               // 
               this.lblDateCheckIn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblDateCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.lblDateCheckIn.Location = new System.Drawing.Point(629, 220);
               this.lblDateCheckIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.lblDateCheckIn.Name = "lblDateCheckIn";
               this.lblDateCheckIn.Size = new System.Drawing.Size(216, 21);
               this.lblDateCheckIn.TabIndex = 90;
               this.lblDateCheckIn.Text = "Mã hóa đơn";
               // 
               // label17
               // 
               this.label17.AutoSize = true;
               this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.label17.Location = new System.Drawing.Point(487, 218);
               this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label17.Name = "label17";
               this.label17.Size = new System.Drawing.Size(88, 23);
               this.label17.TabIndex = 89;
               this.label17.Text = "Ngày đến:";
               // 
               // lblRoomTypeName
               // 
               this.lblRoomTypeName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblRoomTypeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.lblRoomTypeName.Location = new System.Drawing.Point(629, 149);
               this.lblRoomTypeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.lblRoomTypeName.Name = "lblRoomTypeName";
               this.lblRoomTypeName.Size = new System.Drawing.Size(216, 25);
               this.lblRoomTypeName.TabIndex = 88;
               this.lblRoomTypeName.Text = "Mã hóa đơn";
               // 
               // label16
               // 
               this.label16.AutoSize = true;
               this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.label16.Location = new System.Drawing.Point(487, 149);
               this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label16.Name = "label16";
               this.label16.Size = new System.Drawing.Size(100, 23);
               this.label16.TabIndex = 87;
               this.label16.Text = "Loại phòng:";
               // 
               // lblRoomName
               // 
               this.lblRoomName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblRoomName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.lblRoomName.Location = new System.Drawing.Point(629, 111);
               this.lblRoomName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.lblRoomName.Name = "lblRoomName";
               this.lblRoomName.Size = new System.Drawing.Size(206, 21);
               this.lblRoomName.TabIndex = 86;
               this.lblRoomName.Text = "Mã hóa đơn";
               // 
               // label15
               // 
               this.label15.AutoSize = true;
               this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.label15.Location = new System.Drawing.Point(487, 111);
               this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label15.Name = "label15";
               this.label15.Size = new System.Drawing.Size(95, 23);
               this.label15.TabIndex = 85;
               this.label15.Text = "Tên phòng:";
               // 
               // lblAddress
               // 
               this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.lblAddress.Location = new System.Drawing.Point(189, 220);
               this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.lblAddress.Name = "lblAddress";
               this.lblAddress.Size = new System.Drawing.Size(256, 25);
               this.lblAddress.TabIndex = 82;
               this.lblAddress.Text = "Mã hóa đơn";
               // 
               // label12
               // 
               this.label12.AutoSize = true;
               this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.label12.Location = new System.Drawing.Point(47, 218);
               this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label12.Name = "label12";
               this.label12.Size = new System.Drawing.Size(66, 23);
               this.label12.TabIndex = 81;
               this.label12.Text = "Địa chỉ:";
               // 
               // lblPhoneNumber
               // 
               this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.lblPhoneNumber.Location = new System.Drawing.Point(189, 185);
               this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.lblPhoneNumber.Name = "lblPhoneNumber";
               this.lblPhoneNumber.Size = new System.Drawing.Size(244, 21);
               this.lblPhoneNumber.TabIndex = 80;
               this.lblPhoneNumber.Text = "Mã hóa đơn";
               // 
               // label11
               // 
               this.label11.AutoSize = true;
               this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.label11.Location = new System.Drawing.Point(47, 185);
               this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label11.Name = "label11";
               this.label11.Size = new System.Drawing.Size(115, 23);
               this.label11.TabIndex = 79;
               this.label11.Text = "Số điện thoại:";
               // 
               // lblIDCard
               // 
               this.lblIDCard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblIDCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.lblIDCard.Location = new System.Drawing.Point(189, 149);
               this.lblIDCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.lblIDCard.Name = "lblIDCard";
               this.lblIDCard.Size = new System.Drawing.Size(244, 21);
               this.lblIDCard.TabIndex = 78;
               this.lblIDCard.Text = "Mã hóa đơn";
               // 
               // label10
               // 
               this.label10.AutoSize = true;
               this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.label10.Location = new System.Drawing.Point(47, 149);
               this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label10.Name = "label10";
               this.label10.Size = new System.Drawing.Size(65, 23);
               this.label10.TabIndex = 77;
               this.label10.Text = "CMND:";
               // 
               // lblCustomerName
               // 
               this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.lblCustomerName.Location = new System.Drawing.Point(189, 111);
               this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.lblCustomerName.Name = "lblCustomerName";
               this.lblCustomerName.Size = new System.Drawing.Size(244, 25);
               this.lblCustomerName.TabIndex = 76;
               this.lblCustomerName.Text = "Mã hóa đơn";
               // 
               // label9
               // 
               this.label9.AutoSize = true;
               this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.label9.Location = new System.Drawing.Point(47, 111);
               this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label9.Name = "label9";
               this.label9.Size = new System.Drawing.Size(134, 23);
               this.label9.TabIndex = 75;
               this.label9.Text = "Tên khách hàng:";
               // 
               // bunifuSeparator1
               // 
               this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
               this.bunifuSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.bunifuSeparator1.LineThickness = 3280;
               this.bunifuSeparator1.Location = new System.Drawing.Point(23, 91);
               this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
               this.bunifuSeparator1.Name = "bunifuSeparator1";
               this.bunifuSeparator1.Size = new System.Drawing.Size(877, 5);
               this.bunifuSeparator1.TabIndex = 74;
               this.bunifuSeparator1.Transparency = 255;
               this.bunifuSeparator1.Vertical = false;
               // 
               // lblDateCreate
               // 
               this.lblDateCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblDateCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.lblDateCreate.Location = new System.Drawing.Point(743, 58);
               this.lblDateCreate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.lblDateCreate.Name = "lblDateCreate";
               this.lblDateCreate.Size = new System.Drawing.Size(155, 21);
               this.lblDateCreate.TabIndex = 73;
               this.lblDateCreate.Text = "Mã hóa đơn";
               // 
               // lblCustom
               // 
               this.lblCustom.AutoSize = true;
               this.lblCustom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblCustom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.lblCustom.Location = new System.Drawing.Point(642, 58);
               this.lblCustom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.lblCustom.Name = "lblCustom";
               this.lblCustom.Size = new System.Drawing.Size(82, 23);
               this.lblCustom.TabIndex = 72;
               this.lblCustom.Text = "Ngày lập:";
               // 
               // lblStaffSetUp
               // 
               this.lblStaffSetUp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblStaffSetUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.lblStaffSetUp.Location = new System.Drawing.Point(429, 60);
               this.lblStaffSetUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.lblStaffSetUp.Name = "lblStaffSetUp";
               this.lblStaffSetUp.Size = new System.Drawing.Size(205, 24);
               this.lblStaffSetUp.TabIndex = 71;
               this.lblStaffSetUp.Text = "Mã hóa đơn";
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.label7.Location = new System.Drawing.Point(292, 58);
               this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(120, 23);
               this.label7.TabIndex = 70;
               this.label7.Text = "Nhân viên lập:";
               // 
               // lblIDBill
               // 
               this.lblIDBill.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lblIDBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.lblIDBill.Location = new System.Drawing.Point(159, 58);
               this.lblIDBill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.lblIDBill.Name = "lblIDBill";
               this.lblIDBill.Size = new System.Drawing.Size(111, 21);
               this.lblIDBill.TabIndex = 69;
               this.lblIDBill.Text = "Mã hóa đơn";
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.label6.Location = new System.Drawing.Point(25, 58);
               this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(126, 23);
               this.label6.TabIndex = 68;
               this.label6.Text = "Mã phiếu thuê:";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.label5.Location = new System.Drawing.Point(406, 26);
               this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(150, 32);
               this.label5.TabIndex = 67;
               this.label5.Text = "PHIẾU THUÊ";
               // 
               // btnPrint
               // 
               this.btnPrint.ActiveBorderThickness = 1;
               this.btnPrint.ActiveCornerRadius = 20;
               this.btnPrint.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.btnPrint.ActiveForecolor = System.Drawing.Color.White;
               this.btnPrint.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
               this.btnPrint.BackColor = System.Drawing.Color.White;
               this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
               this.btnPrint.ButtonText = "In Phiếu Thuê";
               this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
               this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.btnPrint.IdleBorderThickness = 1;
               this.btnPrint.IdleCornerRadius = 20;
               this.btnPrint.IdleFillColor = System.Drawing.Color.White;
               this.btnPrint.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.btnPrint.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.btnPrint.Location = new System.Drawing.Point(119, 689);
               this.btnPrint.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
               this.btnPrint.Name = "btnPrint";
               this.btnPrint.Size = new System.Drawing.Size(271, 49);
               this.btnPrint.TabIndex = 65;
               this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
               // 
               // btnClose_
               // 
               this.btnClose_.ActiveBorderThickness = 1;
               this.btnClose_.ActiveCornerRadius = 20;
               this.btnClose_.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.btnClose_.ActiveForecolor = System.Drawing.Color.White;
               this.btnClose_.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.btnClose_.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
               this.btnClose_.BackColor = System.Drawing.Color.White;
               this.btnClose_.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose_.BackgroundImage")));
               this.btnClose_.ButtonText = "Đóng";
               this.btnClose_.Cursor = System.Windows.Forms.Cursors.Hand;
               this.btnClose_.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnClose_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.btnClose_.IdleBorderThickness = 1;
               this.btnClose_.IdleCornerRadius = 20;
               this.btnClose_.IdleFillColor = System.Drawing.Color.White;
               this.btnClose_.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.btnClose_.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
               this.btnClose_.Location = new System.Drawing.Point(551, 689);
               this.btnClose_.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
               this.btnClose_.Name = "btnClose_";
               this.btnClose_.Size = new System.Drawing.Size(271, 49);
               this.btnClose_.TabIndex = 66;
               this.btnClose_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               this.btnClose_.Click += new System.EventHandler(this.btnClose__Click);
               // 
               // printDocument1
               // 
               this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
               // 
               // printDialog1
               // 
               this.printDialog1.Document = this.printDocument1;
               this.printDialog1.UseEXDialog = true;
               // 
               // Forminphieuthue
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.White;
               this.ClientSize = new System.Drawing.Size(944, 753);
               this.Controls.Add(this.btnClose_);
               this.Controls.Add(this.btnPrint);
               this.Controls.Add(this.groupBox6);
               this.Controls.Add(this.btnClose);
               this.Controls.Add(this.label2);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.Margin = new System.Windows.Forms.Padding(4);
               this.Name = "Forminphieuthue";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "fPrintBill";
               ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
               this.groupBox6.ResumeLayout(false);
               this.groupBox6.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
          private Bunifu.Framework.UI.BunifuImageButton btnClose;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.GroupBox groupBox6;
          private System.Windows.Forms.Label label5;
          private System.Windows.Forms.Label label6;
          private System.Windows.Forms.Label lblDateCreate;
          private System.Windows.Forms.Label lblCustom;
          private System.Windows.Forms.Label lblStaffSetUp;
          private System.Windows.Forms.Label label7;
          private System.Windows.Forms.Label lblIDBill;
          private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
          private System.Windows.Forms.Label lblIDCard;
          private System.Windows.Forms.Label label10;
          private System.Windows.Forms.Label lblCustomerName;
          private System.Windows.Forms.Label label9;
          private System.Windows.Forms.Label lblAddress;
          private System.Windows.Forms.Label label12;
          private System.Windows.Forms.Label lblPhoneNumber;
          private System.Windows.Forms.Label label11;
          private System.Windows.Forms.Label lblRoomPrice_;
          private System.Windows.Forms.Label label18;
          private System.Windows.Forms.Label lblDateCheckIn;
          private System.Windows.Forms.Label label17;
          private System.Windows.Forms.Label lblRoomTypeName;
          private System.Windows.Forms.Label label16;
          private System.Windows.Forms.Label lblRoomName;
          private System.Windows.Forms.Label label15;
          private System.Windows.Forms.ListView listViewUseService;
          private System.Windows.Forms.ColumnHeader columnHeader1;
          private System.Windows.Forms.ColumnHeader columnHeader2;
          private System.Windows.Forms.ColumnHeader columnHeader3;
          private System.Windows.Forms.ColumnHeader columnHeader4;
          private System.Windows.Forms.ColumnHeader columnHeader5;
          private Bunifu.Framework.UI.BunifuThinButton2 btnClose_;
          private Bunifu.Framework.UI.BunifuThinButton2 btnPrint;
          private System.Drawing.Printing.PrintDocument printDocument1;
          private System.Windows.Forms.PrintDialog printDialog1;
          private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
     }
}