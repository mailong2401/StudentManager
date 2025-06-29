﻿namespace StudentManager
{
    partial class UIitemStudent
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
            lbclass = new Label();
            lbphone = new Label();
            lbdress = new Label();
            lbrender = new Label();
            lbdate = new Label();
            lbname = new Label();
            lbid = new Label();
            pic_delete = new PictureBox();
            pic_edit = new PictureBox();
            exampleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_delete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_edit).BeginInit();
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
            exampleBox.Controls.Add(lbclass);
            exampleBox.Controls.Add(lbphone);
            exampleBox.Controls.Add(lbdress);
            exampleBox.Controls.Add(lbrender);
            exampleBox.Controls.Add(lbdate);
            exampleBox.Controls.Add(lbname);
            exampleBox.Controls.Add(lbid);
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
            // lbclass
            // 
            lbclass.AutoSize = true;
            lbclass.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbclass.Location = new Point(1250, 5);
            lbclass.Name = "lbclass";
            lbclass.Size = new Size(145, 30);
            lbclass.TabIndex = 6;
            lbclass.Text = "D21MARK01";
            // 
            // lbphone
            // 
            lbphone.AutoSize = true;
            lbphone.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbphone.Location = new Point(1072, 5);
            lbphone.Name = "lbphone";
            lbphone.Size = new Size(143, 30);
            lbphone.TabIndex = 5;
            lbphone.Text = "0901234567";
            // 
            // lbdress
            // 
            lbdress.AutoSize = true;
            lbdress.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbdress.Location = new Point(872, 5);
            lbdress.Name = "lbdress";
            lbdress.Size = new Size(141, 30);
            lbdress.TabIndex = 4;
            lbdress.Text = "Hồ Chí Minh";
            // 
            // lbrender
            // 
            lbrender.AutoSize = true;
            lbrender.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbrender.Location = new Point(749, 5);
            lbrender.Name = "lbrender";
            lbrender.Size = new Size(62, 30);
            lbrender.TabIndex = 3;
            lbrender.Text = "Nam";
            // 
            // lbdate
            // 
            lbdate.AutoSize = true;
            lbdate.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbdate.Location = new Point(551, 5);
            lbdate.Name = "lbdate";
            lbdate.Size = new Size(137, 30);
            lbdate.TabIndex = 2;
            lbdate.Text = "24/01/2005";
            // 
            // lbname
            // 
            lbname.AutoSize = true;
            lbname.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbname.Location = new Point(185, 5);
            lbname.Name = "lbname";
            lbname.Size = new Size(313, 30);
            lbname.TabIndex = 1;
            lbname.Text = "Pham nguyen Minh Tri neskd";
            // 
            // lbid
            // 
            lbid.AutoSize = true;
            lbid.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbid.Location = new Point(10, 5);
            lbid.Name = "lbid";
            lbid.Size = new Size(143, 30);
            lbid.TabIndex = 0;
            lbid.Text = "2380601236";
            // 
            // pic_delete
            // 
            pic_delete.Image = Properties.Resources.remove;
            pic_delete.Location = new Point(1444, 5);
            pic_delete.Name = "pic_delete";
            pic_delete.Size = new Size(30, 30);
            pic_delete.SizeMode = PictureBoxSizeMode.Zoom;
            pic_delete.TabIndex = 31;
            pic_delete.TabStop = false;
            // 
            // pic_edit
            // 
            pic_edit.Image = Properties.Resources.pen;
            pic_edit.Location = new Point(1408, 4);
            pic_edit.Name = "pic_edit";
            pic_edit.Size = new Size(30, 30);
            pic_edit.SizeMode = PictureBoxSizeMode.Zoom;
            pic_edit.TabIndex = 30;
            pic_edit.TabStop = false;
            // 
            // UIitemStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pic_delete);
            Controls.Add(pic_edit);
            Controls.Add(exampleBox);
            Name = "UIitemStudent";
            Size = new Size(1477, 41);
            exampleBox.ResumeLayout(false);
            exampleBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_delete).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_edit).EndInit();
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
        private Label lbphone;
        private Label lbdress;
        private Label lbrender;
        private Label lbdate;
        private Label lbname;
        private Label lbid;
        private PictureBox pic_delete;
        private PictureBox pic_edit;
        private Label lbclass;
    }
}
