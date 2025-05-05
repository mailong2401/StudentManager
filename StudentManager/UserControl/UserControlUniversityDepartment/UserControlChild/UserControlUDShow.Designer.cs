namespace StudentManager
{
    partial class UserControlUDShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlUDShow));
            label2 = new Label();
            label1 = new Label();
            tablekhoa = new TableLayoutPanel();
            cyberGroupBox1 = new ReaLTaiizor.Controls.CyberGroupBox();
            inputidKhoa = new TextBox();
            lbCodeKhoa = new Label();
            btnConfirmOfUDAdd = new ReaLTaiizor.Controls.ParrotButton();
            lbNameKhoa = new Label();
            inputNameKhoa = new TextBox();
            cyberGroupBox4 = new ReaLTaiizor.Controls.CyberGroupBox();
            cyberGroupBox1.SuspendLayout();
            cyberGroupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(563, 145);
            label2.Name = "label2";
            label2.Size = new Size(107, 30);
            label2.TabIndex = 30;
            label2.Text = "Tên Khoa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(273, 145);
            label1.Name = "label1";
            label1.Size = new Size(102, 30);
            label1.TabIndex = 28;
            label1.Text = "Mã khoa";
            // 
            // tablekhoa
            // 
            tablekhoa.ColumnCount = 1;
            tablekhoa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablekhoa.Location = new Point(260, 188);
            tablekhoa.Name = "tablekhoa";
            tablekhoa.RowCount = 12;
            tablekhoa.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tablekhoa.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tablekhoa.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tablekhoa.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tablekhoa.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tablekhoa.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tablekhoa.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tablekhoa.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tablekhoa.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tablekhoa.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tablekhoa.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tablekhoa.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tablekhoa.Size = new Size(1000, 564);
            tablekhoa.TabIndex = 29;
            // 
            // cyberGroupBox1
            // 
            cyberGroupBox1.Alpha = 20;
            cyberGroupBox1.BackColor = Color.Transparent;
            cyberGroupBox1.Background = true;
            cyberGroupBox1.Background_WidthPen = 3F;
            cyberGroupBox1.BackgroundPen = true;
            cyberGroupBox1.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberGroupBox1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberGroupBox1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox1.Controls.Add(inputidKhoa);
            cyberGroupBox1.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox1.Lighting = false;
            cyberGroupBox1.LinearGradient_Background = false;
            cyberGroupBox1.LinearGradientPen = false;
            cyberGroupBox1.Location = new Point(188, 15);
            cyberGroupBox1.Name = "cyberGroupBox1";
            cyberGroupBox1.PenWidth = 15;
            cyberGroupBox1.RGB = false;
            cyberGroupBox1.Rounding = true;
            cyberGroupBox1.RoundingInt = 60;
            cyberGroupBox1.Size = new Size(300, 53);
            cyberGroupBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox1.TabIndex = 33;
            cyberGroupBox1.Tag = "Cyber";
            cyberGroupBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox1.Timer_RGB = 300;
            // 
            // inputidKhoa
            // 
            inputidKhoa.BackColor = Color.FromArgb(37, 52, 68);
            inputidKhoa.BorderStyle = BorderStyle.None;
            inputidKhoa.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            inputidKhoa.ForeColor = Color.White;
            inputidKhoa.Location = new Point(16, 6);
            inputidKhoa.Margin = new Padding(3, 0, 3, 0);
            inputidKhoa.Name = "inputidKhoa";
            inputidKhoa.PlaceholderText = "Nhập mã khoa";
            inputidKhoa.Size = new Size(270, 32);
            inputidKhoa.TabIndex = 4;
            inputidKhoa.TextChanged += inputidKhoa_TextChanged;
            // 
            // lbCodeKhoa
            // 
            lbCodeKhoa.AutoSize = true;
            lbCodeKhoa.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbCodeKhoa.ForeColor = SystemColors.Control;
            lbCodeKhoa.Location = new Point(19, 15);
            lbCodeKhoa.Name = "lbCodeKhoa";
            lbCodeKhoa.Size = new Size(142, 41);
            lbCodeKhoa.TabIndex = 34;
            lbCodeKhoa.Text = "Mã Khoa";
            // 
            // btnConfirmOfUDAdd
            // 
            btnConfirmOfUDAdd.BackgroundColor = Color.DimGray;
            btnConfirmOfUDAdd.ButtonImage = (Image)resources.GetObject("btnConfirmOfUDAdd.ButtonImage");
            btnConfirmOfUDAdd.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnConfirmOfUDAdd.ButtonText = "Thêm";
            btnConfirmOfUDAdd.ClickBackColor = Color.Transparent;
            btnConfirmOfUDAdd.ClickTextColor = Color.White;
            btnConfirmOfUDAdd.CornerRadius = 25;
            btnConfirmOfUDAdd.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnConfirmOfUDAdd.Horizontal_Alignment = StringAlignment.Center;
            btnConfirmOfUDAdd.HoverBackgroundColor = Color.Lime;
            btnConfirmOfUDAdd.HoverTextColor = Color.White;
            btnConfirmOfUDAdd.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnConfirmOfUDAdd.Location = new Point(1189, 15);
            btnConfirmOfUDAdd.Name = "btnConfirmOfUDAdd";
            btnConfirmOfUDAdd.RightToLeft = RightToLeft.No;
            btnConfirmOfUDAdd.Size = new Size(159, 50);
            btnConfirmOfUDAdd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnConfirmOfUDAdd.TabIndex = 35;
            btnConfirmOfUDAdd.TextColor = Color.White;
            btnConfirmOfUDAdd.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnConfirmOfUDAdd.Vertical_Alignment = StringAlignment.Center;
            btnConfirmOfUDAdd.Click += btnConfirmOfUDAdd_Click_1;
            // 
            // lbNameKhoa
            // 
            lbNameKhoa.AutoSize = true;
            lbNameKhoa.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbNameKhoa.ForeColor = SystemColors.Control;
            lbNameKhoa.Location = new Point(576, 15);
            lbNameKhoa.Name = "lbNameKhoa";
            lbNameKhoa.Size = new Size(144, 41);
            lbNameKhoa.TabIndex = 32;
            lbNameKhoa.Text = "Tên khoa";
            // 
            // inputNameKhoa
            // 
            inputNameKhoa.BackColor = Color.FromArgb(37, 52, 68);
            inputNameKhoa.BorderStyle = BorderStyle.None;
            inputNameKhoa.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            inputNameKhoa.ForeColor = Color.White;
            inputNameKhoa.Location = new Point(15, 6);
            inputNameKhoa.Margin = new Padding(3, 0, 3, 0);
            inputNameKhoa.Name = "inputNameKhoa";
            inputNameKhoa.PlaceholderText = "Nhập tên khoa";
            inputNameKhoa.Size = new Size(270, 32);
            inputNameKhoa.TabIndex = 4;
            // 
            // cyberGroupBox4
            // 
            cyberGroupBox4.Alpha = 20;
            cyberGroupBox4.BackColor = Color.Transparent;
            cyberGroupBox4.Background = true;
            cyberGroupBox4.Background_WidthPen = 3F;
            cyberGroupBox4.BackgroundPen = true;
            cyberGroupBox4.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberGroupBox4.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox4.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox4.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberGroupBox4.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberGroupBox4.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox4.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox4.Controls.Add(inputNameKhoa);
            cyberGroupBox4.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox4.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox4.Lighting = false;
            cyberGroupBox4.LinearGradient_Background = false;
            cyberGroupBox4.LinearGradientPen = false;
            cyberGroupBox4.Location = new Point(742, 15);
            cyberGroupBox4.Name = "cyberGroupBox4";
            cyberGroupBox4.PenWidth = 15;
            cyberGroupBox4.RGB = false;
            cyberGroupBox4.Rounding = true;
            cyberGroupBox4.RoundingInt = 60;
            cyberGroupBox4.Size = new Size(300, 53);
            cyberGroupBox4.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox4.TabIndex = 31;
            cyberGroupBox4.Tag = "Cyber";
            cyberGroupBox4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox4.Timer_RGB = 300;
            // 
            // UserControlUDShow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 61);
            Controls.Add(btnConfirmOfUDAdd);
            Controls.Add(cyberGroupBox1);
            Controls.Add(lbCodeKhoa);
            Controls.Add(cyberGroupBox4);
            Controls.Add(lbNameKhoa);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tablekhoa);
            Name = "UserControlUDShow";
            Size = new Size(1575, 813);
            cyberGroupBox1.ResumeLayout(false);
            cyberGroupBox1.PerformLayout();
            cyberGroupBox4.ResumeLayout(false);
            cyberGroupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private TableLayoutPanel tablekhoa;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox1;
        private TextBox inputidKhoa;
        private Label lbCodeKhoa;
        private ReaLTaiizor.Controls.ParrotButton btnConfirmOfUDAdd;
        private Label lbNameKhoa;
        private TextBox inputNameKhoa;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox4;
    }
}
