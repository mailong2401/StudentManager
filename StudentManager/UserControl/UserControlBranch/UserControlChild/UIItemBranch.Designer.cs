namespace StudentManager
{
    partial class UIItemBranch
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
            lbnamekhoa = new Label();
            lbnamenganh = new Label();
            lbidnganh = new Label();
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
            exampleBox.Controls.Add(lbnamekhoa);
            exampleBox.Controls.Add(lbnamenganh);
            exampleBox.Controls.Add(lbidnganh);
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
            // lbnamekhoa
            // 
            lbnamekhoa.AutoSize = true;
            lbnamekhoa.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbnamekhoa.Location = new Point(460, 5);
            lbnamekhoa.Name = "lbnamekhoa";
            lbnamekhoa.Size = new Size(282, 30);
            lbnamekhoa.TabIndex = 2;
            lbnamekhoa.Text = "Khoa công nghệ thông tin";
            // 
            // lbnamenganh
            // 
            lbnamenganh.AutoSize = true;
            lbnamenganh.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbnamenganh.Location = new Point(160, 5);
            lbnamenganh.Name = "lbnamenganh";
            lbnamenganh.Size = new Size(227, 30);
            lbnamenganh.TabIndex = 1;
            lbnamenganh.Text = "Công nghệ thông tin";
            // 
            // lbidnganh
            // 
            lbidnganh.AutoSize = true;
            lbidnganh.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbidnganh.Location = new Point(10, 5);
            lbidnganh.Name = "lbidnganh";
            lbidnganh.Size = new Size(83, 30);
            lbidnganh.TabIndex = 0;
            lbidnganh.Text = "CNTT1";
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
            // UIItemBranch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(exampleBox);
            Name = "UIItemBranch";
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
        private Label lbnamekhoa;
        private Label lbnamenganh;
        private Label lbidnganh;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
