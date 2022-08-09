namespace SQL_HOSTEL
{
    partial class FrmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomers));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnShwData = new System.Windows.Forms.Button();
            this.Btnupdate = new System.Windows.Forms.Button();
            this.Btndelete = new System.Windows.Forms.Button();
            this.Btnfind = new System.Windows.Forms.Button();
            this.DtpCheckOutD = new System.Windows.Forms.DateTimePicker();
            this.DtpCheckInD = new System.Windows.Forms.DateTimePicker();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.TxtRoomNmbr = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.MtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.CmbxGndr = new System.Windows.Forms.ComboBox();
            this.TxtSrName = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFind = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-1, 418);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1204, 170);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 41;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Surname";
            this.columnHeader3.Width = 96;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gender";
            this.columnHeader4.Width = 68;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Phone";
            this.columnHeader5.Width = 83;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "E-Mail";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "CustIomer ID";
            this.columnHeader7.Width = 137;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Room Number";
            this.columnHeader8.Width = 146;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Price";
            this.columnHeader9.Width = 62;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Check in Date";
            this.columnHeader10.Width = 137;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Check out Date";
            this.columnHeader11.Width = 163;
            // 
            // BtnShwData
            // 
            this.BtnShwData.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnShwData.Location = new System.Drawing.Point(1000, 40);
            this.BtnShwData.Name = "BtnShwData";
            this.BtnShwData.Size = new System.Drawing.Size(191, 49);
            this.BtnShwData.TabIndex = 1;
            this.BtnShwData.Text = "Show Data";
            this.BtnShwData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnShwData.UseVisualStyleBackColor = true;
            this.BtnShwData.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btnupdate
            // 
            this.Btnupdate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnupdate.Location = new System.Drawing.Point(1000, 107);
            this.Btnupdate.Name = "Btnupdate";
            this.Btnupdate.Size = new System.Drawing.Size(191, 49);
            this.Btnupdate.TabIndex = 2;
            this.Btnupdate.Text = "Update";
            this.Btnupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btnupdate.UseVisualStyleBackColor = true;
            this.Btnupdate.Click += new System.EventHandler(this.Btnupdate_Click);
            // 
            // Btndelete
            // 
            this.Btndelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btndelete.Location = new System.Drawing.Point(1000, 175);
            this.Btndelete.Name = "Btndelete";
            this.Btndelete.Size = new System.Drawing.Size(191, 49);
            this.Btndelete.TabIndex = 3;
            this.Btndelete.Text = "Delete";
            this.Btndelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btndelete.UseVisualStyleBackColor = true;
            this.Btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // Btnfind
            // 
            this.Btnfind.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnfind.Location = new System.Drawing.Point(1000, 242);
            this.Btnfind.Name = "Btnfind";
            this.Btnfind.Size = new System.Drawing.Size(191, 49);
            this.Btnfind.TabIndex = 4;
            this.Btnfind.Text = "Find";
            this.Btnfind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btnfind.UseVisualStyleBackColor = true;
            this.Btnfind.Click += new System.EventHandler(this.Btnfind_Click);
            // 
            // DtpCheckOutD
            // 
            this.DtpCheckOutD.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpCheckOutD.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.DtpCheckOutD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpCheckOutD.Location = new System.Drawing.Point(618, 233);
            this.DtpCheckOutD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpCheckOutD.Name = "DtpCheckOutD";
            this.DtpCheckOutD.Size = new System.Drawing.Size(193, 34);
            this.DtpCheckOutD.TabIndex = 40;
            // 
            // DtpCheckInD
            // 
            this.DtpCheckInD.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpCheckInD.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.DtpCheckInD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpCheckInD.Location = new System.Drawing.Point(618, 193);
            this.DtpCheckInD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpCheckInD.Name = "DtpCheckInD";
            this.DtpCheckInD.Size = new System.Drawing.Size(193, 34);
            this.DtpCheckInD.TabIndex = 39;
            // 
            // TxtPrice
            // 
            this.TxtPrice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPrice.Location = new System.Drawing.Point(618, 153);
            this.TxtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(193, 34);
            this.TxtPrice.TabIndex = 38;
            // 
            // TxtRoomNmbr
            // 
            this.TxtRoomNmbr.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtRoomNmbr.Enabled = false;
            this.TxtRoomNmbr.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtRoomNmbr.Location = new System.Drawing.Point(618, 113);
            this.TxtRoomNmbr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtRoomNmbr.Name = "TxtRoomNmbr";
            this.TxtRoomNmbr.Size = new System.Drawing.Size(193, 34);
            this.TxtRoomNmbr.TabIndex = 37;
            // 
            // TxtId
            // 
            this.TxtId.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtId.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtId.Location = new System.Drawing.Point(618, 73);
            this.TxtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(193, 34);
            this.TxtId.TabIndex = 36;
            // 
            // TxtMail
            // 
            this.TxtMail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtMail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.Location = new System.Drawing.Point(155, 230);
            this.TxtMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(193, 34);
            this.TxtMail.TabIndex = 35;
            // 
            // MtxtPhone
            // 
            this.MtxtPhone.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MtxtPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MtxtPhone.Location = new System.Drawing.Point(155, 192);
            this.MtxtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MtxtPhone.Mask = "(999) 000-0000";
            this.MtxtPhone.Name = "MtxtPhone";
            this.MtxtPhone.Size = new System.Drawing.Size(193, 34);
            this.MtxtPhone.TabIndex = 34;
            // 
            // CmbxGndr
            // 
            this.CmbxGndr.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CmbxGndr.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbxGndr.FormattingEnabled = true;
            this.CmbxGndr.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.CmbxGndr.Location = new System.Drawing.Point(155, 150);
            this.CmbxGndr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbxGndr.Name = "CmbxGndr";
            this.CmbxGndr.Size = new System.Drawing.Size(193, 36);
            this.CmbxGndr.TabIndex = 33;
            // 
            // TxtSrName
            // 
            this.TxtSrName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtSrName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSrName.Location = new System.Drawing.Point(155, 110);
            this.TxtSrName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSrName.Name = "TxtSrName";
            this.TxtSrName.Size = new System.Drawing.Size(193, 34);
            this.TxtSrName.TabIndex = 32;
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtName.Location = new System.Drawing.Point(155, 70);
            this.TxtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(193, 34);
            this.TxtName.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(456, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 28);
            this.label10.TabIndex = 30;
            this.label10.Text = "Check-out Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(470, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 28);
            this.label9.TabIndex = 29;
            this.label9.Text = "Check-in Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(553, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 28);
            this.label8.TabIndex = 28;
            this.label8.Text = "Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(462, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 28);
            this.label7.TabIndex = 27;
            this.label7.Text = "Room Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(495, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 28);
            this.label6.TabIndex = 26;
            this.label6.Text = "ID Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(77, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 28);
            this.label5.TabIndex = 25;
            this.label5.Text = "E-Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-8, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 28);
            this.label4.TabIndex = 24;
            this.label4.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(65, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 28);
            this.label3.TabIndex = 23;
            this.label3.Text = "Gender:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name:";
            // 
            // TxtFind
            // 
            this.TxtFind.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtFind.Location = new System.Drawing.Point(1000, 315);
            this.TxtFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtFind.Name = "TxtFind";
            this.TxtFind.Size = new System.Drawing.Size(191, 30);
            this.TxtFind.TabIndex = 41;
            this.TxtFind.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(929, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 25);
            this.label11.TabIndex = 42;
            this.label11.Text = "Name:";
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1203, 590);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtFind);
            this.Controls.Add(this.DtpCheckOutD);
            this.Controls.Add(this.DtpCheckInD);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.TxtRoomNmbr);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.MtxtPhone);
            this.Controls.Add(this.CmbxGndr);
            this.Controls.Add(this.TxtSrName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btnfind);
            this.Controls.Add(this.Btndelete);
            this.Controls.Add(this.Btnupdate);
            this.Controls.Add(this.BtnShwData);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Informations";
            this.Load += new System.EventHandler(this.FrmCustomers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button BtnShwData;
        private System.Windows.Forms.Button Btnupdate;
        private System.Windows.Forms.Button Btndelete;
        private System.Windows.Forms.Button Btnfind;
        private System.Windows.Forms.DateTimePicker DtpCheckOutD;
        private System.Windows.Forms.DateTimePicker DtpCheckInD;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.TextBox TxtRoomNmbr;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.MaskedTextBox MtxtPhone;
        private System.Windows.Forms.ComboBox CmbxGndr;
        private System.Windows.Forms.TextBox TxtSrName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFind;
        private System.Windows.Forms.Label label11;
    }
}