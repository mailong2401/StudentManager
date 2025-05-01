namespace StudentManager
{
    partial class UserControlClassAdd
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlClassAdd));
            errorProvider1 = new ErrorProvider(components);
            label8 = new Label();
            cyberGroupBox8 = new ReaLTaiizor.Controls.CyberGroupBox();
            inputnganh = new StudentManager.CustomControl.BorderlessComboBox();
            cyberGroupBox4 = new ReaLTaiizor.Controls.CyberGroupBox();
            inputkhoavien = new StudentManager.CustomControl.BorderlessComboBox();
            label7 = new Label();
            btnDeleteOfClassAdd = new ReaLTaiizor.Controls.ParrotButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnConfirmOfClassAdd = new ReaLTaiizor.Controls.ParrotButton();
            nightPanel1 = new ReaLTaiizor.Controls.NightPanel();
            cyberGroupBox1 = new ReaLTaiizor.Controls.CyberGroupBox();
            inputlop = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            cyberGroupBox8.SuspendLayout();
            cyberGroupBox4.SuspendLayout();
            nightPanel1.SuspendLayout();
            cyberGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label8.Location = new Point(445, 302);
            label8.Name = "label8";
            label8.Size = new Size(150, 54);
            label8.TabIndex = 30;
            label8.Text = "Ngành";
            // 
            // cyberGroupBox8
            // 
            cyberGroupBox8.Alpha = 20;
            cyberGroupBox8.BackColor = Color.Transparent;
            cyberGroupBox8.Background = true;
            cyberGroupBox8.Background_WidthPen = 3F;
            cyberGroupBox8.BackgroundPen = true;
            cyberGroupBox8.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberGroupBox8.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox8.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox8.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberGroupBox8.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberGroupBox8.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox8.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox8.Controls.Add(inputnganh);
            cyberGroupBox8.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox8.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox8.Lighting = false;
            cyberGroupBox8.LinearGradient_Background = false;
            cyberGroupBox8.LinearGradientPen = false;
            cyberGroupBox8.Location = new Point(709, 292);
            cyberGroupBox8.Name = "cyberGroupBox8";
            cyberGroupBox8.PenWidth = 15;
            cyberGroupBox8.RGB = false;
            cyberGroupBox8.Rounding = true;
            cyberGroupBox8.RoundingInt = 60;
            cyberGroupBox8.Size = new Size(377, 75);
            cyberGroupBox8.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox8.TabIndex = 29;
            cyberGroupBox8.Tag = "Cyber";
            cyberGroupBox8.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox8.Timer_RGB = 300;
            // 
            // inputnganh
            // 
            inputnganh.BackColor = Color.FromArgb(37, 52, 68);
            inputnganh.DrawMode = DrawMode.OwnerDrawFixed;
            inputnganh.DropDownStyle = ComboBoxStyle.DropDownList;
            inputnganh.FlatStyle = FlatStyle.Flat;
            inputnganh.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            inputnganh.ForeColor = Color.White;
            inputnganh.FormattingEnabled = true;
            inputnganh.Items.AddRange(new object[] { "23DTHHA2", "23DTHHA3", "23DTHHA1" });
            inputnganh.Location = new Point(24, 10);
            inputnganh.Name = "inputnganh";
            inputnganh.Placeholder = "Chọn ngành...";
            inputnganh.Size = new Size(335, 53);
            inputnganh.TabIndex = 20;
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
            cyberGroupBox4.Controls.Add(inputkhoavien);
            cyberGroupBox4.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox4.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox4.Lighting = false;
            cyberGroupBox4.LinearGradient_Background = false;
            cyberGroupBox4.LinearGradientPen = false;
            cyberGroupBox4.Location = new Point(709, 42);
            cyberGroupBox4.Name = "cyberGroupBox4";
            cyberGroupBox4.PenWidth = 15;
            cyberGroupBox4.RGB = false;
            cyberGroupBox4.Rounding = true;
            cyberGroupBox4.RoundingInt = 60;
            cyberGroupBox4.Size = new Size(377, 75);
            cyberGroupBox4.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox4.TabIndex = 21;
            cyberGroupBox4.Tag = "Cyber";
            cyberGroupBox4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox4.Timer_RGB = 300;
            // 
            // inputkhoavien
            // 
            inputkhoavien.BackColor = Color.FromArgb(37, 52, 68);
            inputkhoavien.DrawMode = DrawMode.OwnerDrawFixed;
            inputkhoavien.DropDownStyle = ComboBoxStyle.DropDownList;
            inputkhoavien.FlatStyle = FlatStyle.Flat;
            inputkhoavien.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            inputkhoavien.ForeColor = Color.White;
            inputkhoavien.FormattingEnabled = true;
            inputkhoavien.Items.AddRange(new object[] { "23DTHHA2", "23DTHHA3", "23DTHHA1" });
            inputkhoavien.Location = new Point(24, 8);
            inputkhoavien.Name = "inputkhoavien";
            inputkhoavien.Placeholder = "Chọn khoa/viện...";
            inputkhoavien.Size = new Size(335, 53);
            inputkhoavien.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label7.Location = new Point(445, 42);
            label7.Name = "label7";
            label7.Size = new Size(216, 54);
            label7.TabIndex = 28;
            label7.Text = "Khoa/viện";
            // 
            // btnDeleteOfClassAdd
            // 
            btnDeleteOfClassAdd.BackgroundColor = Color.FromArgb(255, 173, 153);
            btnDeleteOfClassAdd.ButtonImage = (Image)resources.GetObject("btnDeleteOfClassAdd.ButtonImage");
            btnDeleteOfClassAdd.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnDeleteOfClassAdd.ButtonText = "Xóa sạch";
            btnDeleteOfClassAdd.ClickBackColor = Color.Transparent;
            btnDeleteOfClassAdd.ClickTextColor = Color.White;
            btnDeleteOfClassAdd.CornerRadius = 40;
            btnDeleteOfClassAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteOfClassAdd.Horizontal_Alignment = StringAlignment.Center;
            btnDeleteOfClassAdd.HoverBackgroundColor = Color.Red;
            btnDeleteOfClassAdd.HoverTextColor = Color.White;
            btnDeleteOfClassAdd.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnDeleteOfClassAdd.Location = new Point(874, 810);
            btnDeleteOfClassAdd.Name = "btnDeleteOfClassAdd";
            btnDeleteOfClassAdd.RightToLeft = RightToLeft.No;
            btnDeleteOfClassAdd.Size = new Size(283, 83);
            btnDeleteOfClassAdd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnDeleteOfClassAdd.TabIndex = 18;
            btnDeleteOfClassAdd.TextColor = Color.White;
            btnDeleteOfClassAdd.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnDeleteOfClassAdd.Vertical_Alignment = StringAlignment.Center;
            // 
            // btnConfirmOfClassAdd
            // 
            btnConfirmOfClassAdd.BackgroundColor = Color.FromArgb(133, 224, 133);
            btnConfirmOfClassAdd.ButtonImage = (Image)resources.GetObject("btnConfirmOfClassAdd.ButtonImage");
            btnConfirmOfClassAdd.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnConfirmOfClassAdd.ButtonText = "Thêm";
            btnConfirmOfClassAdd.ClickBackColor = Color.Transparent;
            btnConfirmOfClassAdd.ClickTextColor = Color.White;
            btnConfirmOfClassAdd.CornerRadius = 40;
            btnConfirmOfClassAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmOfClassAdd.Horizontal_Alignment = StringAlignment.Center;
            btnConfirmOfClassAdd.HoverBackgroundColor = Color.Lime;
            btnConfirmOfClassAdd.HoverTextColor = Color.White;
            btnConfirmOfClassAdd.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnConfirmOfClassAdd.Location = new Point(1250, 810);
            btnConfirmOfClassAdd.Name = "btnConfirmOfClassAdd";
            btnConfirmOfClassAdd.RightToLeft = RightToLeft.No;
            btnConfirmOfClassAdd.Size = new Size(283, 83);
            btnConfirmOfClassAdd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnConfirmOfClassAdd.TabIndex = 19;
            btnConfirmOfClassAdd.TextColor = Color.White;
            btnConfirmOfClassAdd.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnConfirmOfClassAdd.Vertical_Alignment = StringAlignment.Center;
            // 
            // nightPanel1
            // 
            nightPanel1.Controls.Add(cyberGroupBox1);
            nightPanel1.Controls.Add(label1);
            nightPanel1.Controls.Add(label8);
            nightPanel1.Controls.Add(cyberGroupBox8);
            nightPanel1.Controls.Add(cyberGroupBox4);
            nightPanel1.Controls.Add(label7);
            nightPanel1.Controls.Add(btnConfirmOfClassAdd);
            nightPanel1.Controls.Add(btnDeleteOfClassAdd);
            nightPanel1.Dock = DockStyle.Fill;
            nightPanel1.ForeColor = Color.FromArgb(250, 250, 250);
            nightPanel1.LeftSideColor = Color.FromArgb(41, 44, 61);
            nightPanel1.Location = new Point(0, 0);
            nightPanel1.Name = "nightPanel1";
            nightPanel1.RightSideColor = Color.FromArgb(41, 44, 61);
            nightPanel1.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
            nightPanel1.Size = new Size(1575, 813);
            nightPanel1.TabIndex = 2;
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
            cyberGroupBox1.Controls.Add(inputlop);
            cyberGroupBox1.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox1.Lighting = false;
            cyberGroupBox1.LinearGradient_Background = false;
            cyberGroupBox1.LinearGradientPen = false;
            cyberGroupBox1.Location = new Point(709, 542);
            cyberGroupBox1.Name = "cyberGroupBox1";
            cyberGroupBox1.PenWidth = 15;
            cyberGroupBox1.RGB = false;
            cyberGroupBox1.Rounding = true;
            cyberGroupBox1.RoundingInt = 60;
            cyberGroupBox1.Size = new Size(377, 75);
            cyberGroupBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox1.TabIndex = 25;
            cyberGroupBox1.Tag = "Cyber";
            cyberGroupBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox1.Timer_RGB = 300;
            // 
            // inputlop
            // 
            inputlop.BackColor = Color.FromArgb(37, 52, 68);
            inputlop.BorderStyle = BorderStyle.None;
            inputlop.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            inputlop.ForeColor = Color.White;
            inputlop.Location = new Point(24, 10);
            inputlop.Margin = new Padding(3, 0, 3, 0);
            inputlop.Name = "inputlop";
            inputlop.PlaceholderText = "Nhập tên lớp";
            inputlop.Size = new Size(335, 45);
            inputlop.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(445, 562);
            label1.Name = "label1";
            label1.Size = new Size(93, 54);
            label1.TabIndex = 26;
            label1.Text = "Lớp";
            // 
            // UserControlClassAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(nightPanel1);
            Name = "UserControlClassAdd";
            Size = new Size(1575, 813);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            cyberGroupBox8.ResumeLayout(false);
            cyberGroupBox4.ResumeLayout(false);
            nightPanel1.ResumeLayout(false);
            nightPanel1.PerformLayout();
            cyberGroupBox1.ResumeLayout(false);
            cyberGroupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ErrorProvider errorProvider1;
        private ReaLTaiizor.Controls.NightPanel nightPanel1;
        private Label label8;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox8;
        private CustomControl.BorderlessComboBox inputnganh;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox4;
        private CustomControl.BorderlessComboBox inputkhoavien;
        private Label label7;
        private ReaLTaiizor.Controls.ParrotButton btnConfirmOfClassAdd;
        private ReaLTaiizor.Controls.ParrotButton btnDeleteOfClassAdd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox1;
        private TextBox inputlop;
        private Label label1;
    }
}
