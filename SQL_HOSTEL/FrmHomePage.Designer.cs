namespace SQL_HOSTEL
{
    partial class FrmHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomePage));
            this.BtnAddNewCust = new System.Windows.Forms.Button();
            this.BtnRooms = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAddNewCust
            // 
            this.BtnAddNewCust.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAddNewCust.Location = new System.Drawing.Point(72, 101);
            this.BtnAddNewCust.Name = "BtnAddNewCust";
            this.BtnAddNewCust.Size = new System.Drawing.Size(132, 99);
            this.BtnAddNewCust.TabIndex = 1;
            this.BtnAddNewCust.Text = "Add New Customer";
            this.BtnAddNewCust.UseVisualStyleBackColor = true;
            this.BtnAddNewCust.Click += new System.EventHandler(this.BtnAddNewCust_Click);
            // 
            // BtnRooms
            // 
            this.BtnRooms.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRooms.Location = new System.Drawing.Point(546, 101);
            this.BtnRooms.Name = "BtnRooms";
            this.BtnRooms.Size = new System.Drawing.Size(132, 99);
            this.BtnRooms.TabIndex = 2;
            this.BtnRooms.Text = "Rooms";
            this.BtnRooms.UseVisualStyleBackColor = true;
            this.BtnRooms.Click += new System.EventHandler(this.BtnRooms_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(309, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 98);
            this.button1.TabIndex = 3;
            this.button1.Text = "Customers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(72, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 99);
            this.button2.TabIndex = 4;
            this.button2.Text = "Income- Expense";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(309, 309);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 99);
            this.button4.TabIndex = 5;
            this.button4.Text = "Stock Status";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(546, 309);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 99);
            this.button5.TabIndex = 6;
            this.button5.Text = "Customer\'s Feedback";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // FrmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(770, 511);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnRooms);
            this.Controls.Add(this.BtnAddNewCust);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHomePage";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnAddNewCust;
        private System.Windows.Forms.Button BtnRooms;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}