namespace ThongTinTienAo
{
    partial class formMain
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


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tmrUpdateTop3 = new System.Windows.Forms.Timer(this.components);
            this.tbxNameCoin1 = new System.Windows.Forms.TextBox();
            this.g = new System.Windows.Forms.Label();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.btnDoThi = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCoinTop1 = new System.Windows.Forms.Label();
            this.lblCoinTop2 = new System.Windows.Forms.Label();
            this.lblCoinTop6 = new System.Windows.Forms.Label();
            this.lblCoinTop4 = new System.Windows.Forms.Label();
            this.lblCoinTop5 = new System.Windows.Forms.Label();
            this.lblCoinTop8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 33);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(865, 239);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(445, 414);
            this.panel3.TabIndex = 4;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AccessibleName = "";
            this.lblWelcome.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(548, 2);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(484, 31);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Coins Price Checker";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // tmrUpdateTop3
            // 
            this.tmrUpdateTop3.Enabled = true;
            this.tmrUpdateTop3.Interval = 10000;
            this.tmrUpdateTop3.Tick += new System.EventHandler(this.tmrUpdateTop3_Tick);
            // 
            // tbxNameCoin1
            // 
            this.tbxNameCoin1.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxNameCoin1.Location = new System.Drawing.Point(1049, 55);
            this.tbxNameCoin1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxNameCoin1.Name = "tbxNameCoin1";
            this.tbxNameCoin1.Size = new System.Drawing.Size(218, 22);
            this.tbxNameCoin1.TabIndex = 4;
            this.tbxNameCoin1.TextChanged += new System.EventHandler(this.tbxNameCoin1_TextChanged);
            // 
            // g
            // 
            this.g.AutoSize = true;
            this.g.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g.Location = new System.Drawing.Point(864, 55);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(158, 20);
            this.g.TabIndex = 5;
            this.g.Text = "Enter Coin Name:";
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTien.Location = new System.Drawing.Point(865, 158);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(94, 16);
            this.lblGiaTien.TabIndex = 7;
            this.lblGiaTien.Text = "Coin Price: $";
            this.lblGiaTien.Click += new System.EventHandler(this.lblGiaTien_Click);
            // 
            // btnDoThi
            // 
            this.btnDoThi.BackColor = System.Drawing.Color.DarkGray;
            this.btnDoThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoThi.Location = new System.Drawing.Point(948, 190);
            this.btnDoThi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoThi.Name = "btnDoThi";
            this.btnDoThi.Size = new System.Drawing.Size(291, 57);
            this.btnDoThi.TabIndex = 8;
            this.btnDoThi.Text = "Show Coin Graph";
            this.btnDoThi.UseVisualStyleBackColor = false;
            this.btnDoThi.Click += new System.EventHandler(this.btnDoThi_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.IndianRed;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(867, 90);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(149, 50);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Check";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ThongTinTienAo.Properties.Resources.LastPic;
            this.pictureBox1.Location = new System.Drawing.Point(187, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(476, 431);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblCoinTop1
            // 
            this.lblCoinTop1.AutoSize = true;
            this.lblCoinTop1.Location = new System.Drawing.Point(563, 164);
            this.lblCoinTop1.Name = "lblCoinTop1";
            this.lblCoinTop1.Size = new System.Drawing.Size(44, 16);
            this.lblCoinTop1.TabIndex = 2;
            this.lblCoinTop1.Text = "label1";
            this.lblCoinTop1.Click += new System.EventHandler(this.lblCoinTop1_Click);
            // 
            // lblCoinTop2
            // 
            this.lblCoinTop2.AutoSize = true;
            this.lblCoinTop2.Location = new System.Drawing.Point(563, 221);
            this.lblCoinTop2.Name = "lblCoinTop2";
            this.lblCoinTop2.Size = new System.Drawing.Size(44, 16);
            this.lblCoinTop2.TabIndex = 3;
            this.lblCoinTop2.Text = "label2";
            this.lblCoinTop2.Click += new System.EventHandler(this.lblCoinTop2_Click);
            // 
            // lblCoinTop6
            // 
            this.lblCoinTop6.AutoSize = true;
            this.lblCoinTop6.Location = new System.Drawing.Point(563, 348);
            this.lblCoinTop6.Name = "lblCoinTop6";
            this.lblCoinTop6.Size = new System.Drawing.Size(44, 16);
            this.lblCoinTop6.TabIndex = 4;
            this.lblCoinTop6.Text = "label6";
            this.lblCoinTop6.Click += new System.EventHandler(this.lblCoinTop3_Click);
            // 
            // lblCoinTop4
            // 
            this.lblCoinTop4.AutoSize = true;
            this.lblCoinTop4.Location = new System.Drawing.Point(563, 285);
            this.lblCoinTop4.Name = "lblCoinTop4";
            this.lblCoinTop4.Size = new System.Drawing.Size(44, 16);
            this.lblCoinTop4.TabIndex = 5;
            this.lblCoinTop4.Text = "label4";
            this.lblCoinTop4.Click += new System.EventHandler(this.lblCoinTop4_Click);
            // 
            // lblCoinTop5
            // 
            this.lblCoinTop5.AutoSize = true;
            this.lblCoinTop5.Location = new System.Drawing.Point(563, 411);
            this.lblCoinTop5.Name = "lblCoinTop5";
            this.lblCoinTop5.Size = new System.Drawing.Size(44, 16);
            this.lblCoinTop5.TabIndex = 6;
            this.lblCoinTop5.Text = "label5";
            this.lblCoinTop5.Click += new System.EventHandler(this.lblCoinTop5_Click);
            // 
            // lblCoinTop8
            // 
            this.lblCoinTop8.AutoSize = true;
            this.lblCoinTop8.Location = new System.Drawing.Point(563, 474);
            this.lblCoinTop8.Name = "lblCoinTop8";
            this.lblCoinTop8.Size = new System.Drawing.Size(44, 16);
            this.lblCoinTop8.TabIndex = 9;
            this.lblCoinTop8.Text = "label8";
            this.lblCoinTop8.Click += new System.EventHandler(this.lblCoinTop8_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(187, 54);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(476, 28);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "\r\n6 Best Cryptocurrencies in 2022\r\n";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BackgroundImage = global::ThongTinTienAo.Properties.Resources.top_cryptocurrencies;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.lblCoinTop8);
            this.panel2.Controls.Add(this.lblCoinTop5);
            this.panel2.Controls.Add(this.lblCoinTop4);
            this.panel2.Controls.Add(this.lblCoinTop6);
            this.panel2.Controls.Add(this.lblCoinTop2);
            this.panel2.Controls.Add(this.lblCoinTop1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(1, 39);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(857, 678);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1315, 688);
            this.Controls.Add(this.btnDoThi);
            this.Controls.Add(this.lblGiaTien);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.g);
            this.Controls.Add(this.tbxNameCoin1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Timer tmrUpdateTop3;
        private System.Windows.Forms.TextBox tbxNameCoin1;
        private System.Windows.Forms.Label g;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.Button btnDoThi;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtCoin;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCoinTop1;
        private System.Windows.Forms.Label lblCoinTop2;
        private System.Windows.Forms.Label lblCoinTop6;
        private System.Windows.Forms.Label lblCoinTop4;
        private System.Windows.Forms.Label lblCoinTop5;
        private System.Windows.Forms.Label lblCoinTop8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
    }
}

