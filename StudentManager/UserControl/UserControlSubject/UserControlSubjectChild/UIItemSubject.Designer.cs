﻿namespace StudentManager
{
    partial class UIItemSubject
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            exampleBox = new ReaLTaiizor.Controls.CyberGroupBox();
            lb_SoTinChi = new Label();
            lb_tenMon = new Label();
            lb_maMon = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            exampleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // exampleBox
            // 
            exampleBox.Alpha = 20;
            exampleBox.BackColor = Color.Transparent;
            exampleBox.Background = true;
            exampleBox.Background_WidthPen = 3F;
            exampleBox.BackgroundPen = true;
            exampleBox.ColorBackground = Color.FromArgb(37, 52, 68);
            exampleBox.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            exampleBox.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            exampleBox.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            exampleBox.ColorLighting = Color.FromArgb(29, 200, 238);
            exampleBox.ColorPen_1 = Color.FromArgb(37, 52, 68);
            exampleBox.ColorPen_2 = Color.FromArgb(41, 63, 86);
            exampleBox.Controls.Add(lb_SoTinChi);
            exampleBox.Controls.Add(lb_tenMon);
            exampleBox.Controls.Add(lb_maMon);
            exampleBox.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            exampleBox.Dock = DockStyle.Left;
            exampleBox.ForeColor = Color.FromArgb(245, 245, 245);
            exampleBox.Lighting = false;
            exampleBox.LinearGradient_Background = false;
            exampleBox.LinearGradientPen = false;
            exampleBox.Location = new Point(0, 0);
            exampleBox.Name = "exampleBox";
            exampleBox.PenWidth = 15;
            exampleBox.RGB = false;
            exampleBox.Rounding = true;
            exampleBox.RoundingInt = 60;
            exampleBox.Size = new Size(1402, 41);
            exampleBox.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            exampleBox.TabIndex = 29;
            exampleBox.Tag = "Cyber";
            exampleBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            exampleBox.Timer_RGB = 300;
            // 
            // lb_SoTinChi
            // 
            lb_SoTinChi.AutoSize = true;
            lb_SoTinChi.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lb_SoTinChi.Location = new Point(1100, 5);
            lb_SoTinChi.Name = "lb_SoTinChi";
            lb_SoTinChi.Size = new Size(129, 30);
            lb_SoTinChi.TabIndex = 4;
            lb_SoTinChi.Text = "23DTHHA2";
            // 
            // lb_tenMon
            // 
            lb_tenMon.AutoSize = true;
            lb_tenMon.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lb_tenMon.Location = new Point(353, 5);
            lb_tenMon.Name = "lb_tenMon";
            lb_tenMon.Size = new Size(282, 30);
            lb_tenMon.TabIndex = 2;
            lb_tenMon.Text = "Viện Công nghệ Việt Nhật";
            // 
            // lb_maMon
            // 
            lb_maMon.AutoSize = true;
            lb_maMon.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lb_maMon.Location = new Point(10, 5);
            lb_maMon.Name = "lb_maMon";
            lb_maMon.Size = new Size(105, 30);
            lb_maMon.TabIndex = 0;
            lb_maMon.Text = "CTDL-GT";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.remove;
            pictureBox2.Location = new Point(1444, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pen;
            pictureBox1.Location = new Point(1408, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // UIItemSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(exampleBox);
            Name = "UIItemSubject";
            Size = new Size(1477, 41);
            exampleBox.ResumeLayout(false);
            exampleBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CyberGroupBox exampleBox;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label lbnamemon;
        private Label lb_maMon;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lb_tenMon;
        private Label lbnamenganh;
        private Label lb_SoTinChi;
    }
}
