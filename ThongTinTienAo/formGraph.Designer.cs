
namespace ThongTinTienAo
{
    partial class formGraph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtCoin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chtCoin)).BeginInit();
            this.SuspendLayout();
            // 
            // chtCoin
            // 
            this.chtCoin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            chartArea1.Name = "ChartArea1";
            this.chtCoin.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtCoin.Legends.Add(legend1);
            this.chtCoin.Location = new System.Drawing.Point(9, 10);
            this.chtCoin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chtCoin.Name = "chtCoin";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Bitcoin";
            this.chtCoin.Series.Add(series1);
            this.chtCoin.Size = new System.Drawing.Size(996, 594);
            this.chtCoin.TabIndex = 0;
            this.chtCoin.Text = "chart1";
            this.chtCoin.Click += new System.EventHandler(this.chtCoin_Click);
            // 
            // formGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 606);
            this.Controls.Add(this.chtCoin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formGraph";
            this.Text = "formGraph";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formGraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtCoin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtCoin;
    }
}