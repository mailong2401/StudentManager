namespace StudentManager
{
    partial class fAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdmin));
            panel1 = new Panel();
            btnDiem = new ReaLTaiizor.Controls.ParrotButton();
            btnMon = new ReaLTaiizor.Controls.ParrotButton();
            btnKhoa = new ReaLTaiizor.Controls.ParrotButton();
            btnThongKe = new ReaLTaiizor.Controls.ParrotButton();
            btnSinhVien = new ReaLTaiizor.Controls.ParrotButton();
            btnLop = new ReaLTaiizor.Controls.ParrotButton();
            btnNganh = new ReaLTaiizor.Controls.ParrotButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelUserControlDad = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(5, 25, 30);
            panel1.Controls.Add(btnDiem);
            panel1.Controls.Add(btnMon);
            panel1.Controls.Add(btnKhoa);
            panel1.Controls.Add(btnThongKe);
            panel1.Controls.Add(btnSinhVien);
            panel1.Controls.Add(btnLop);
            panel1.Controls.Add(btnNganh);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 829);
            panel1.TabIndex = 0;
            // 
            // btnDiem
            // 
            btnDiem.BackgroundColor = Color.Transparent;
            btnDiem.ButtonImage = Properties.Resources.score;
            btnDiem.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            btnDiem.ButtonText = "Điểm";
            btnDiem.ClickBackColor = Color.FromArgb(15, 40, 45);
            btnDiem.ClickTextColor = Color.DodgerBlue;
            btnDiem.CornerRadius = 0;
            btnDiem.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiem.Horizontal_Alignment = StringAlignment.Center;
            btnDiem.HoverBackgroundColor = Color.FromArgb(15, 40, 45);
            btnDiem.HoverTextColor = Color.DodgerBlue;
            btnDiem.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnDiem.Location = new Point(3, 800);
            btnDiem.Name = "btnDiem";
            btnDiem.Size = new Size(340, 64);
            btnDiem.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnDiem.TabIndex = 10;
            btnDiem.TextColor = Color.White;
            btnDiem.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnDiem.Vertical_Alignment = StringAlignment.Center;
            btnDiem.Click += btnDiem_Click;
            // 
            // btnMon
            // 
            btnMon.BackgroundColor = Color.Transparent;
            btnMon.ButtonImage = Properties.Resources.subject;
            btnMon.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            btnMon.ButtonText = "Môn học";
            btnMon.ClickBackColor = Color.FromArgb(15, 40, 45);
            btnMon.ClickTextColor = Color.DodgerBlue;
            btnMon.CornerRadius = 0;
            btnMon.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMon.Horizontal_Alignment = StringAlignment.Center;
            btnMon.HoverBackgroundColor = Color.FromArgb(15, 40, 45);
            btnMon.HoverTextColor = Color.DodgerBlue;
            btnMon.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnMon.Location = new Point(3, 550);
            btnMon.Name = "btnMon";
            btnMon.Size = new Size(340, 64);
            btnMon.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnMon.TabIndex = 9;
            btnMon.TextColor = Color.White;
            btnMon.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnMon.Vertical_Alignment = StringAlignment.Center;
            btnMon.Click += btnMon_Click;
            // 
            // btnKhoa
            // 
            btnKhoa.BackgroundColor = Color.Transparent;
            btnKhoa.ButtonImage = Properties.Resources.university;
            btnKhoa.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            btnKhoa.ButtonText = "Khoa/Viện";
            btnKhoa.ClickBackColor = Color.FromArgb(15, 40, 45);
            btnKhoa.ClickTextColor = Color.DodgerBlue;
            btnKhoa.CornerRadius = 0;
            btnKhoa.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKhoa.Horizontal_Alignment = StringAlignment.Center;
            btnKhoa.HoverBackgroundColor = Color.FromArgb(15, 40, 45);
            btnKhoa.HoverTextColor = Color.DodgerBlue;
            btnKhoa.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnKhoa.ImeMode = ImeMode.NoControl;
            btnKhoa.Location = new Point(3, 175);
            btnKhoa.Name = "btnKhoa";
            btnKhoa.RightToLeft = RightToLeft.No;
            btnKhoa.Size = new Size(340, 64);
            btnKhoa.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnKhoa.TabIndex = 8;
            btnKhoa.TextColor = Color.White;
            btnKhoa.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnKhoa.Vertical_Alignment = StringAlignment.Center;
            btnKhoa.Click += btnKhoa_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.BackgroundColor = Color.Transparent;
            btnThongKe.ButtonImage = Properties.Resources.statistic;
            btnThongKe.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            btnThongKe.ButtonText = "Thống kê";
            btnThongKe.ClickBackColor = Color.FromArgb(15, 40, 45);
            btnThongKe.ClickTextColor = Color.DodgerBlue;
            btnThongKe.CornerRadius = 0;
            btnThongKe.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThongKe.Horizontal_Alignment = StringAlignment.Center;
            btnThongKe.HoverBackgroundColor = Color.FromArgb(15, 40, 45);
            btnThongKe.HoverTextColor = Color.DodgerBlue;
            btnThongKe.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnThongKe.Location = new Point(3, 925);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(340, 64);
            btnThongKe.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnThongKe.TabIndex = 7;
            btnThongKe.TextColor = Color.White;
            btnThongKe.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnThongKe.Vertical_Alignment = StringAlignment.Center;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnSinhVien
            // 
            btnSinhVien.BackgroundColor = Color.Transparent;
            btnSinhVien.ButtonImage = Properties.Resources.graduated;
            btnSinhVien.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            btnSinhVien.ButtonText = "Sinh viên";
            btnSinhVien.ClickBackColor = Color.FromArgb(15, 40, 45);
            btnSinhVien.ClickTextColor = Color.DodgerBlue;
            btnSinhVien.CornerRadius = 0;
            btnSinhVien.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSinhVien.Horizontal_Alignment = StringAlignment.Center;
            btnSinhVien.HoverBackgroundColor = Color.FromArgb(15, 40, 45);
            btnSinhVien.HoverTextColor = Color.DodgerBlue;
            btnSinhVien.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnSinhVien.Location = new Point(3, 675);
            btnSinhVien.Name = "btnSinhVien";
            btnSinhVien.Size = new Size(340, 64);
            btnSinhVien.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSinhVien.TabIndex = 6;
            btnSinhVien.TextColor = Color.White;
            btnSinhVien.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSinhVien.Vertical_Alignment = StringAlignment.Center;
            btnSinhVien.Click += btnSinhVien_Click;
            // 
            // btnLop
            // 
            btnLop.BackgroundColor = Color.Transparent;
            btnLop.ButtonImage = Properties.Resources._class;
            btnLop.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            btnLop.ButtonText = "Lớp học";
            btnLop.ClickBackColor = Color.FromArgb(15, 40, 45);
            btnLop.ClickTextColor = Color.DodgerBlue;
            btnLop.CornerRadius = 0;
            btnLop.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLop.Horizontal_Alignment = StringAlignment.Center;
            btnLop.HoverBackgroundColor = Color.FromArgb(15, 40, 45);
            btnLop.HoverTextColor = Color.DodgerBlue;
            btnLop.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnLop.Location = new Point(3, 425);
            btnLop.Name = "btnLop";
            btnLop.Size = new Size(340, 64);
            btnLop.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnLop.TabIndex = 5;
            btnLop.TextColor = Color.White;
            btnLop.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnLop.Vertical_Alignment = StringAlignment.Center;
            btnLop.Click += btnLop_Click;
            // 
            // btnNganh
            // 
            btnNganh.BackgroundColor = Color.Transparent;
            btnNganh.ButtonImage = Properties.Resources.branch;
            btnNganh.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            btnNganh.ButtonText = "Ngành học";
            btnNganh.ClickBackColor = Color.FromArgb(15, 40, 45);
            btnNganh.ClickTextColor = Color.DodgerBlue;
            btnNganh.CornerRadius = 0;
            btnNganh.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNganh.Horizontal_Alignment = StringAlignment.Center;
            btnNganh.HoverBackgroundColor = Color.FromArgb(15, 40, 45);
            btnNganh.HoverTextColor = Color.DodgerBlue;
            btnNganh.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnNganh.Location = new Point(3, 300);
            btnNganh.Name = "btnNganh";
            btnNganh.Size = new Size(340, 64);
            btnNganh.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnNganh.TabIndex = 2;
            btnNganh.TextColor = Color.White;
            btnNganh.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnNganh.Vertical_Alignment = StringAlignment.Center;
            btnNganh.Click += btnNganh_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Cyan;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(25, 117);
            label3.Name = "label3";
            label3.Size = new Size(291, 10);
            label3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(171, 58);
            label2.Name = "label2";
            label2.Size = new Size(96, 46);
            label2.TabIndex = 3;
            label2.Text = "VKIT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(112, 3);
            label1.Name = "label1";
            label1.Size = new Size(228, 46);
            label1.TabIndex = 2;
            label1.Text = "Quản trị viên";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panelUserControlDad
            // 
            panelUserControlDad.Dock = DockStyle.Fill;
            panelUserControlDad.Location = new Point(343, 0);
            panelUserControlDad.Name = "panelUserControlDad";
            panelUserControlDad.Size = new Size(584, 829);
            panelUserControlDad.TabIndex = 2;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 829);
            Controls.Add(panelUserControlDad);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "fAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản trị viên";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private ReaLTaiizor.Controls.ParrotButton btnNganh;
        private Label label3;
        private ReaLTaiizor.Controls.ParrotButton btnThongKe;
        private ReaLTaiizor.Controls.ParrotButton btnSinhVien;
        private ReaLTaiizor.Controls.ParrotButton btnLop;
        private ReaLTaiizor.Controls.ParrotButton btnKhoa;
        private Panel panelUserControlDad;
        private ReaLTaiizor.Controls.ParrotButton btnMon;
        private ReaLTaiizor.Controls.ParrotButton btnDiem;
    }
}
