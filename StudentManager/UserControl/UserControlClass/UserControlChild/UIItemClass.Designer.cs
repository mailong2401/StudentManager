namespace StudentManager
{
    partial class UIItemClass
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
            lbnameNganh = new Label();
            lbnamelop = new Label();
            lbmalop = new Label();
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
            exampleBox.Controls.Add(lbnameNganh);
            exampleBox.Controls.Add(lbnamelop);
            exampleBox.Controls.Add(lbmalop);
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
            // lbnameNganh
            // 
            lbnameNganh.AutoSize = true;
            lbnameNganh.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbnameNganh.Location = new Point(906, 5);
            lbnameNganh.Name = "lbnameNganh";
            lbnameNganh.Size = new Size(282, 30);
            lbnameNganh.TabIndex = 2;
            lbnameNganh.Text = "Viện Công nghệ Việt Nhật";
            // 
            // lbnamelop
            // 
            lbnamelop.AutoSize = true;
            lbnamelop.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbnamelop.Location = new Point(407, 5);
            lbnamelop.Name = "lbnamelop";
            lbnamelop.Size = new Size(246, 30);
            lbnamelop.TabIndex = 1;
            lbnamelop.Text = "Công nghệ thông tin 2";
            // 
            // lbmalop
            // 
            lbmalop.AutoSize = true;
            lbmalop.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbmalop.Location = new Point(10, 5);
            lbmalop.Name = "lbmalop";
            lbmalop.Size = new Size(129, 30);
            lbmalop.TabIndex = 0;
            lbmalop.Text = "23DTHHA2";
            lbmalop.Click += lbmalop_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.remove;
            pictureBox2.Location = new Point(1441, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
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
            // 
            // UIItemClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(exampleBox);
            Name = "UIItemClass";
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
        private Label lbnamelop;
        private Label lbmalop;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lbnameNganh;
    }
}
