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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tmrUpdateTop3 = new System.Windows.Forms.Timer(this.components);
            this.tbxNameCoin1 = new System.Windows.Forms.TextBox();
            this.g = new System.Windows.Forms.Label();
            this.CP1 = new System.Windows.Forms.Label();
            this.btnDoThi = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TV = new System.Windows.Forms.Label();
            this.MC = new System.Windows.Forms.Label();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblMarketCap = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCoinVolume6 = new System.Windows.Forms.Label();
            this.lblCoinVolume5 = new System.Windows.Forms.Label();
            this.lblCoinVolume3 = new System.Windows.Forms.Label();
            this.lblCoinVolume2 = new System.Windows.Forms.Label();
            this.lblMarketCap6 = new System.Windows.Forms.Label();
            this.lblCoinVolume4 = new System.Windows.Forms.Label();
            this.lblMarketCap5 = new System.Windows.Forms.Label();
            this.lblCoinVolume1 = new System.Windows.Forms.Label();
            this.lblMarketCap4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMarketCap3 = new System.Windows.Forms.Label();
            this.lblCoinTop6 = new System.Windows.Forms.Label();
            this.lblMarketCap2 = new System.Windows.Forms.Label();
            this.lblCoinTop5 = new System.Windows.Forms.Label();
            this.lblMarketCap1 = new System.Windows.Forms.Label();
            this.lblCoinTop3 = new System.Windows.Forms.Label();
            this.lblCoinTop4 = new System.Windows.Forms.Label();
            this.lblCoinTop2 = new System.Windows.Forms.Label();
            this.lblCoinTop1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-5, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1932, 46);
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
            this.lblWelcome.BackColor = System.Drawing.Color.DimGray;
            this.lblWelcome.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWelcome.Location = new System.Drawing.Point(755, 5);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(484, 31);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Coins Infomation Checker";
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
            this.tbxNameCoin1.Location = new System.Drawing.Point(1412, 49);
            this.tbxNameCoin1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxNameCoin1.Name = "tbxNameCoin1";
            this.tbxNameCoin1.Size = new System.Drawing.Size(257, 22);
            this.tbxNameCoin1.TabIndex = 4;
            this.tbxNameCoin1.TextChanged += new System.EventHandler(this.tbxNameCoin1_TextChanged);
            // 
            // g
            // 
            this.g.AutoSize = true;
            this.g.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g.Location = new System.Drawing.Point(1228, 49);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(158, 20);
            this.g.TabIndex = 5;
            this.g.Text = "Enter Coin Name:";
            // 
            // CP1
            // 
            this.CP1.AutoSize = true;
            this.CP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP1.Location = new System.Drawing.Point(1234, 139);
            this.CP1.Name = "CP1";
            this.CP1.Size = new System.Drawing.Size(86, 16);
            this.CP1.TabIndex = 7;
            this.CP1.Text = "Coin Price: ";
            this.CP1.Click += new System.EventHandler(this.lblGiaTien_Click);
            // 
            // btnDoThi
            // 
            this.btnDoThi.BackColor = System.Drawing.Color.DimGray;
            this.btnDoThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoThi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDoThi.Location = new System.Drawing.Point(1320, 257);
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
            this.btnTim.Location = new System.Drawing.Point(1232, 75);
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
            // TV
            // 
            this.TV.AutoSize = true;
            this.TV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TV.Location = new System.Drawing.Point(1234, 170);
            this.TV.Name = "TV";
            this.TV.Size = new System.Drawing.Size(107, 16);
            this.TV.TabIndex = 9;
            this.TV.Text = "Total Volume: ";
            this.TV.Click += new System.EventHandler(this.lblVolume_Click);
            // 
            // MC
            // 
            this.MC.AutoSize = true;
            this.MC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MC.Location = new System.Drawing.Point(1234, 204);
            this.MC.Name = "MC";
            this.MC.Size = new System.Drawing.Size(94, 16);
            this.MC.TabIndex = 19;
            this.MC.Text = "Market Cap: ";
            this.MC.Click += new System.EventHandler(this.MC_Click);
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Location = new System.Drawing.Point(1355, 139);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(47, 16);
            this.lblGiaTien.TabIndex = 20;
            this.lblGiaTien.Text = "----------";
            this.lblGiaTien.Click += new System.EventHandler(this.lblGiaTien_Click_1);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(1355, 170);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(47, 16);
            this.lblVolume.TabIndex = 21;
            this.lblVolume.Text = "----------";
            this.lblVolume.Click += new System.EventHandler(this.lblVolume_Click_1);
            // 
            // lblMarketCap
            // 
            this.lblMarketCap.AutoSize = true;
            this.lblMarketCap.Location = new System.Drawing.Point(1355, 204);
            this.lblMarketCap.Name = "lblMarketCap";
            this.lblMarketCap.Size = new System.Drawing.Size(47, 16);
            this.lblMarketCap.TabIndex = 22;
            this.lblMarketCap.Text = "----------";
            this.lblMarketCap.Click += new System.EventHandler(this.lblMarketCap_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BackgroundImage = global::ThongTinTienAo.Properties.Resources.BackGroundPJ1;
            this.panel2.Controls.Add(this.lblCoinVolume6);
            this.panel2.Controls.Add(this.lblCoinVolume5);
            this.panel2.Controls.Add(this.lblCoinVolume3);
            this.panel2.Controls.Add(this.lblCoinVolume2);
            this.panel2.Controls.Add(this.lblMarketCap6);
            this.panel2.Controls.Add(this.lblCoinVolume4);
            this.panel2.Controls.Add(this.lblMarketCap5);
            this.panel2.Controls.Add(this.lblCoinVolume1);
            this.panel2.Controls.Add(this.lblMarketCap4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.lblMarketCap3);
            this.panel2.Controls.Add(this.lblCoinTop6);
            this.panel2.Controls.Add(this.lblMarketCap2);
            this.panel2.Controls.Add(this.lblCoinTop5);
            this.panel2.Controls.Add(this.lblMarketCap1);
            this.panel2.Controls.Add(this.lblCoinTop3);
            this.panel2.Controls.Add(this.lblCoinTop4);
            this.panel2.Controls.Add(this.lblCoinTop2);
            this.panel2.Controls.Add(this.lblCoinTop1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-5, 39);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1227, 864);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblCoinVolume6
            // 
            this.lblCoinVolume6.AutoSize = true;
            this.lblCoinVolume6.Location = new System.Drawing.Point(536, 468);
            this.lblCoinVolume6.Name = "lblCoinVolume6";
            this.lblCoinVolume6.Size = new System.Drawing.Size(45, 16);
            this.lblCoinVolume6.TabIndex = 17;
            this.lblCoinVolume6.Text = "labelF";
            // 
            // lblCoinVolume5
            // 
            this.lblCoinVolume5.AutoSize = true;
            this.lblCoinVolume5.Location = new System.Drawing.Point(536, 409);
            this.lblCoinVolume5.Name = "lblCoinVolume5";
            this.lblCoinVolume5.Size = new System.Drawing.Size(46, 16);
            this.lblCoinVolume5.TabIndex = 16;
            this.lblCoinVolume5.Text = "labelE";
            // 
            // lblCoinVolume3
            // 
            this.lblCoinVolume3.AutoSize = true;
            this.lblCoinVolume3.Location = new System.Drawing.Point(535, 345);
            this.lblCoinVolume3.Name = "lblCoinVolume3";
            this.lblCoinVolume3.Size = new System.Drawing.Size(46, 16);
            this.lblCoinVolume3.TabIndex = 15;
            this.lblCoinVolume3.Text = "labelC";
            this.lblCoinVolume3.Click += new System.EventHandler(this.lblCoinVolume4_Click);
            // 
            // lblCoinVolume2
            // 
            this.lblCoinVolume2.AutoSize = true;
            this.lblCoinVolume2.Location = new System.Drawing.Point(537, 282);
            this.lblCoinVolume2.Name = "lblCoinVolume2";
            this.lblCoinVolume2.Size = new System.Drawing.Size(46, 16);
            this.lblCoinVolume2.TabIndex = 14;
            this.lblCoinVolume2.Text = "labelB";
            this.lblCoinVolume2.Click += new System.EventHandler(this.lblCoinVolume3_Click);
            // 
            // lblMarketCap6
            // 
            this.lblMarketCap6.AutoSize = true;
            this.lblMarketCap6.Location = new System.Drawing.Point(729, 468);
            this.lblMarketCap6.Name = "lblMarketCap6";
            this.lblMarketCap6.Size = new System.Drawing.Size(51, 16);
            this.lblMarketCap6.TabIndex = 18;
            this.lblMarketCap6.Text = "label15";
            // 
            // lblCoinVolume4
            // 
            this.lblCoinVolume4.AutoSize = true;
            this.lblCoinVolume4.Location = new System.Drawing.Point(536, 218);
            this.lblCoinVolume4.Name = "lblCoinVolume4";
            this.lblCoinVolume4.Size = new System.Drawing.Size(47, 16);
            this.lblCoinVolume4.TabIndex = 13;
            this.lblCoinVolume4.Text = "labelD";
            this.lblCoinVolume4.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblMarketCap5
            // 
            this.lblMarketCap5.AutoSize = true;
            this.lblMarketCap5.Location = new System.Drawing.Point(729, 406);
            this.lblMarketCap5.Name = "lblMarketCap5";
            this.lblMarketCap5.Size = new System.Drawing.Size(51, 16);
            this.lblMarketCap5.TabIndex = 17;
            this.lblMarketCap5.Text = "label14";
            // 
            // lblCoinVolume1
            // 
            this.lblCoinVolume1.AutoSize = true;
            this.lblCoinVolume1.Location = new System.Drawing.Point(536, 159);
            this.lblCoinVolume1.Name = "lblCoinVolume1";
            this.lblCoinVolume1.Size = new System.Drawing.Size(46, 16);
            this.lblCoinVolume1.TabIndex = 12;
            this.lblCoinVolume1.Text = "labelA";
            this.lblCoinVolume1.Click += new System.EventHandler(this.CoinVolume1_Click);
            // 
            // lblMarketCap4
            // 
            this.lblMarketCap4.AutoSize = true;
            this.lblMarketCap4.Location = new System.Drawing.Point(729, 343);
            this.lblMarketCap4.Name = "lblMarketCap4";
            this.lblMarketCap4.Size = new System.Drawing.Size(51, 16);
            this.lblMarketCap4.TabIndex = 16;
            this.lblMarketCap4.Text = "label13";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(363, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(488, 34);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "\r\n6 Best Cryptocurrencies in 2022\r\n";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMarketCap3
            // 
            this.lblMarketCap3.AutoSize = true;
            this.lblMarketCap3.Location = new System.Drawing.Point(729, 280);
            this.lblMarketCap3.Name = "lblMarketCap3";
            this.lblMarketCap3.Size = new System.Drawing.Size(51, 16);
            this.lblMarketCap3.TabIndex = 15;
            this.lblMarketCap3.Text = "label12";
            // 
            // lblCoinTop6
            // 
            this.lblCoinTop6.AutoSize = true;
            this.lblCoinTop6.Location = new System.Drawing.Point(925, 469);
            this.lblCoinTop6.Name = "lblCoinTop6";
            this.lblCoinTop6.Size = new System.Drawing.Size(44, 16);
            this.lblCoinTop6.TabIndex = 9;
            this.lblCoinTop6.Text = "label6";
            this.lblCoinTop6.Click += new System.EventHandler(this.lblCoinTop8_Click);
            // 
            // lblMarketCap2
            // 
            this.lblMarketCap2.AutoSize = true;
            this.lblMarketCap2.Location = new System.Drawing.Point(729, 218);
            this.lblMarketCap2.Name = "lblMarketCap2";
            this.lblMarketCap2.Size = new System.Drawing.Size(51, 16);
            this.lblMarketCap2.TabIndex = 14;
            this.lblMarketCap2.Text = "label11";
            // 
            // lblCoinTop5
            // 
            this.lblCoinTop5.AutoSize = true;
            this.lblCoinTop5.Location = new System.Drawing.Point(925, 406);
            this.lblCoinTop5.Name = "lblCoinTop5";
            this.lblCoinTop5.Size = new System.Drawing.Size(44, 16);
            this.lblCoinTop5.TabIndex = 6;
            this.lblCoinTop5.Text = "label5";
            this.lblCoinTop5.Click += new System.EventHandler(this.lblCoinTop5_Click);
            // 
            // lblMarketCap1
            // 
            this.lblMarketCap1.AutoSize = true;
            this.lblMarketCap1.Location = new System.Drawing.Point(729, 159);
            this.lblMarketCap1.Name = "lblMarketCap1";
            this.lblMarketCap1.Size = new System.Drawing.Size(51, 16);
            this.lblMarketCap1.TabIndex = 13;
            this.lblMarketCap1.Text = "label10";
            // 
            // lblCoinTop3
            // 
            this.lblCoinTop3.AutoSize = true;
            this.lblCoinTop3.Location = new System.Drawing.Point(925, 280);
            this.lblCoinTop3.Name = "lblCoinTop3";
            this.lblCoinTop3.Size = new System.Drawing.Size(44, 16);
            this.lblCoinTop3.TabIndex = 5;
            this.lblCoinTop3.Text = "label3";
            this.lblCoinTop3.Click += new System.EventHandler(this.lblCoinTop4_Click);
            // 
            // lblCoinTop4
            // 
            this.lblCoinTop4.AutoSize = true;
            this.lblCoinTop4.Location = new System.Drawing.Point(925, 343);
            this.lblCoinTop4.Name = "lblCoinTop4";
            this.lblCoinTop4.Size = new System.Drawing.Size(44, 16);
            this.lblCoinTop4.TabIndex = 4;
            this.lblCoinTop4.Text = "label4";
            this.lblCoinTop4.Click += new System.EventHandler(this.lblCoinTop3_Click);
            // 
            // lblCoinTop2
            // 
            this.lblCoinTop2.AutoSize = true;
            this.lblCoinTop2.Location = new System.Drawing.Point(925, 216);
            this.lblCoinTop2.Name = "lblCoinTop2";
            this.lblCoinTop2.Size = new System.Drawing.Size(44, 16);
            this.lblCoinTop2.TabIndex = 3;
            this.lblCoinTop2.Text = "label2";
            this.lblCoinTop2.Click += new System.EventHandler(this.lblCoinTop2_Click);
            // 
            // lblCoinTop1
            // 
            this.lblCoinTop1.AutoSize = true;
            this.lblCoinTop1.Location = new System.Drawing.Point(925, 159);
            this.lblCoinTop1.Name = "lblCoinTop1";
            this.lblCoinTop1.Size = new System.Drawing.Size(44, 16);
            this.lblCoinTop1.TabIndex = 2;
            this.lblCoinTop1.Text = "label1";
            this.lblCoinTop1.Click += new System.EventHandler(this.lblCoinTop1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ThongTinTienAo.Properties.Resources.VCLVCLVCLVCLVLCVLCLVCLVCLVCLV;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1227, 620);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.lblMarketCap);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblGiaTien);
            this.Controls.Add(this.MC);
            this.Controls.Add(this.TV);
            this.Controls.Add(this.btnDoThi);
            this.Controls.Add(this.CP1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.g);
            this.Controls.Add(this.tbxNameCoin1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label CP1;
        private System.Windows.Forms.Button btnDoThi;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtCoin;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCoinTop1;
        private System.Windows.Forms.Label lblCoinTop2;
        private System.Windows.Forms.Label lblCoinTop4;
        private System.Windows.Forms.Label lblCoinTop3;
        private System.Windows.Forms.Label lblCoinTop5;
        private System.Windows.Forms.Label lblCoinTop6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCoinVolume4;
        private System.Windows.Forms.Label lblCoinVolume1;
        private System.Windows.Forms.Label lblCoinVolume6;
        private System.Windows.Forms.Label lblCoinVolume5;
        private System.Windows.Forms.Label lblCoinVolume3;
        private System.Windows.Forms.Label lblCoinVolume2;
        private System.Windows.Forms.Label TV;
        private System.Windows.Forms.Label lblMarketCap1;
        private System.Windows.Forms.Label lblMarketCap2;
        private System.Windows.Forms.Label lblMarketCap3;
        private System.Windows.Forms.Label lblMarketCap4;
        private System.Windows.Forms.Label lblMarketCap5;
        private System.Windows.Forms.Label lblMarketCap6;
        private System.Windows.Forms.Label MC;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblMarketCap;
    }
}

