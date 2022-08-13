
namespace PartiSecimİstasistikProgrami
{
    partial class frmGrafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIlce = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prgAparti = new System.Windows.Forms.ProgressBar();
            this.prgBparti = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.prgCparti = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.prgDparti = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.prgEparti = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.lblGeriDon = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 378);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafikler";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(3, 30);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Partiler";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(812, 345);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblE);
            this.groupBox2.Controls.Add(this.lblC);
            this.groupBox2.Controls.Add(this.lblD);
            this.groupBox2.Controls.Add(this.lblB);
            this.groupBox2.Controls.Add(this.lblA);
            this.groupBox2.Controls.Add(this.prgEparti);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.prgDparti);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.prgCparti);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.prgBparti);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.prgAparti);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbIlce);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 404);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(818, 363);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlçe Değerleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "İlçe Seçin :";
            // 
            // cmbIlce
            // 
            this.cmbIlce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIlce.FormattingEnabled = true;
            this.cmbIlce.Location = new System.Drawing.Point(174, 43);
            this.cmbIlce.Name = "cmbIlce";
            this.cmbIlce.Size = new System.Drawing.Size(180, 34);
            this.cmbIlce.TabIndex = 4;
            this.cmbIlce.SelectedIndexChanged += new System.EventHandler(this.cmbIlce_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "A Parti :";
            // 
            // prgAparti
            // 
            this.prgAparti.Location = new System.Drawing.Point(174, 97);
            this.prgAparti.Maximum = 200;
            this.prgAparti.Name = "prgAparti";
            this.prgAparti.Size = new System.Drawing.Size(421, 38);
            this.prgAparti.TabIndex = 6;
            // 
            // prgBparti
            // 
            this.prgBparti.Location = new System.Drawing.Point(174, 150);
            this.prgBparti.Maximum = 200;
            this.prgBparti.Name = "prgBparti";
            this.prgBparti.Size = new System.Drawing.Size(421, 38);
            this.prgBparti.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "B Parti :";
            // 
            // prgCparti
            // 
            this.prgCparti.Location = new System.Drawing.Point(174, 205);
            this.prgCparti.Maximum = 200;
            this.prgCparti.Name = "prgCparti";
            this.prgCparti.Size = new System.Drawing.Size(421, 38);
            this.prgCparti.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "C Parti :";
            // 
            // prgDparti
            // 
            this.prgDparti.Location = new System.Drawing.Point(174, 258);
            this.prgDparti.Maximum = 200;
            this.prgDparti.Name = "prgDparti";
            this.prgDparti.Size = new System.Drawing.Size(421, 38);
            this.prgDparti.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "D Parti :";
            // 
            // prgEparti
            // 
            this.prgEparti.Location = new System.Drawing.Point(174, 311);
            this.prgEparti.Maximum = 200;
            this.prgEparti.Name = "prgEparti";
            this.prgEparti.Size = new System.Drawing.Size(421, 38);
            this.prgEparti.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 30);
            this.label6.TabIndex = 13;
            this.label6.Text = "E Parti :";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(601, 105);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(26, 30);
            this.lblA.TabIndex = 15;
            this.lblA.Text = "0";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(601, 158);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(26, 30);
            this.lblB.TabIndex = 16;
            this.lblB.Text = "0";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.Location = new System.Drawing.Point(601, 266);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(26, 30);
            this.lblD.TabIndex = 17;
            this.lblD.Text = "0";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(601, 213);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(26, 30);
            this.lblC.TabIndex = 17;
            this.lblC.Text = "0";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.Location = new System.Drawing.Point(601, 319);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(26, 30);
            this.lblE.TabIndex = 18;
            this.lblE.Text = "0";
            // 
            // lblGeriDon
            // 
            this.lblGeriDon.AutoSize = true;
            this.lblGeriDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGeriDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGeriDon.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeriDon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGeriDon.Location = new System.Drawing.Point(783, 0);
            this.lblGeriDon.Name = "lblGeriDon";
            this.lblGeriDon.Size = new System.Drawing.Size(50, 35);
            this.lblGeriDon.TabIndex = 19;
            this.lblGeriDon.Text = "<--";
            this.lblGeriDon.Click += new System.EventHandler(this.lblGeriDon_Click);
            // 
            // frmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(842, 775);
            this.Controls.Add(this.lblGeriDon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGrafikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGrafikler";
            this.Load += new System.EventHandler(this.frmGrafikler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.ProgressBar prgEparti;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar prgDparti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar prgCparti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar prgBparti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar prgAparti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbIlce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGeriDon;
    }
}