namespace StudentManager
{
    partial class UserControlBranchAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlBranchAdd));
            errorProvider1 = new ErrorProvider(components);
            inputname = new TextBox();
            cyberGroupBox4 = new ReaLTaiizor.Controls.CyberGroupBox();
            inputkhoavien = new StudentManager.CustomControl.BorderlessComboBox();
            inputngaythem = new StudentManager.CustomControl.CustomDateTimePicker();
            label7 = new Label();
            label6 = new Label();
            cyberGroupBox1 = new ReaLTaiizor.Controls.CyberGroupBox();
            inputid = new TextBox();
            inputnamenganh = new TextBox();
            label1 = new Label();
            label5 = new Label();
            inputMSGV = new TextBox();
            label3 = new Label();
            label2 = new Label();
            cyberGroupBox7 = new ReaLTaiizor.Controls.CyberGroupBox();
            btnDeleteOfBranchAdd = new ReaLTaiizor.Controls.ParrotButton();
            cyberGroupBox6 = new ReaLTaiizor.Controls.CyberGroupBox();
            cyberGroupBox2 = new ReaLTaiizor.Controls.CyberGroupBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            cyberGroupBox3 = new ReaLTaiizor.Controls.CyberGroupBox();
            btnConfirmOfBranchAdd = new ReaLTaiizor.Controls.ParrotButton();
            nightPanel1 = new ReaLTaiizor.Controls.NightPanel();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            cyberGroupBox4.SuspendLayout();
            cyberGroupBox1.SuspendLayout();
            cyberGroupBox7.SuspendLayout();
            cyberGroupBox6.SuspendLayout();
            cyberGroupBox2.SuspendLayout();
            cyberGroupBox3.SuspendLayout();
            nightPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // inputname
            // 
            inputname.BackColor = Color.FromArgb(37, 52, 68);
            inputname.BorderStyle = BorderStyle.None;
            inputname.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            inputname.ForeColor = Color.White;
            inputname.Location = new Point(13, 14);
            inputname.Margin = new Padding(3, 0, 3, 0);
            inputname.Name = "inputname";
            inputname.PlaceholderText = "Họ và tên";
            inputname.Size = new Size(309, 45);
            inputname.TabIndex = 3;
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
            cyberGroupBox4.Location = new Point(1184, 34);
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
            // inputngaythem
            // 
            inputngaythem.BackColor = Color.FromArgb(37, 52, 68);
            inputngaythem.CustomFormat = "dd/MM/yyyy";
            inputngaythem.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            inputngaythem.ForeColor = Color.White;
            inputngaythem.Format = DateTimePickerFormat.Custom;
            inputngaythem.Location = new Point(24, 10);
            inputngaythem.Name = "inputngaythem";
            inputngaythem.Size = new Size(309, 52);
            inputngaythem.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label7.Location = new Point(830, 45);
            label7.Name = "label7";
            label7.Size = new Size(216, 54);
            label7.TabIndex = 28;
            label7.Text = "Khoa/viện";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label6.Location = new Point(830, 270);
            label6.Name = "label6";
            label6.Size = new Size(327, 54);
            label6.TabIndex = 27;
            label6.Text = "Ngày mở ngành";
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
            cyberGroupBox1.Controls.Add(inputid);
            cyberGroupBox1.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox1.Lighting = false;
            cyberGroupBox1.LinearGradient_Background = false;
            cyberGroupBox1.LinearGradientPen = false;
            cyberGroupBox1.Location = new Point(320, 34);
            cyberGroupBox1.Name = "cyberGroupBox1";
            cyberGroupBox1.PenWidth = 15;
            cyberGroupBox1.RGB = false;
            cyberGroupBox1.Rounding = true;
            cyberGroupBox1.RoundingInt = 60;
            cyberGroupBox1.Size = new Size(337, 75);
            cyberGroupBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox1.TabIndex = 23;
            cyberGroupBox1.Tag = "Cyber";
            cyberGroupBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox1.Timer_RGB = 300;
            // 
            // inputid
            // 
            inputid.BackColor = Color.FromArgb(37, 52, 68);
            inputid.BorderStyle = BorderStyle.None;
            inputid.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            inputid.ForeColor = Color.White;
            inputid.Location = new Point(23, 11);
            inputid.Margin = new Padding(3, 0, 3, 0);
            inputid.Name = "inputid";
            inputid.PlaceholderText = "Nhập mã ngành";
            inputid.Size = new Size(299, 45);
            inputid.TabIndex = 3;
            // 
            // inputnamenganh
            // 
            inputnamenganh.BackColor = Color.FromArgb(37, 52, 68);
            inputnamenganh.BorderStyle = BorderStyle.None;
            inputnamenganh.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            inputnamenganh.ForeColor = Color.White;
            inputnamenganh.Location = new Point(13, 13);
            inputnamenganh.Margin = new Padding(3, 0, 3, 0);
            inputnamenganh.Name = "inputnamenganh";
            inputnamenganh.PlaceholderText = "Nhập tên ngành";
            inputnamenganh.Size = new Size(309, 45);
            inputnamenganh.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(15, 45);
            label1.Name = "label1";
            label1.Size = new Size(213, 54);
            label1.TabIndex = 24;
            label1.Text = "Mã ngành";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label5.Location = new Point(830, 495);
            label5.Name = "label5";
            label5.Size = new Size(290, 54);
            label5.TabIndex = 26;
            label5.Text = "Trưởng ngành";
            // 
            // inputMSGV
            // 
            inputMSGV.BackColor = Color.FromArgb(37, 52, 68);
            inputMSGV.BorderStyle = BorderStyle.None;
            inputMSGV.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            inputMSGV.ForeColor = Color.White;
            inputMSGV.Location = new Point(13, 14);
            inputMSGV.Margin = new Padding(3, 0, 3, 0);
            inputMSGV.Name = "inputMSGV";
            inputMSGV.PlaceholderText = "Nhập MSGV";
            inputMSGV.Size = new Size(309, 45);
            inputMSGV.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label3.Location = new Point(15, 495);
            label3.Name = "label3";
            label3.Size = new Size(138, 54);
            label3.TabIndex = 24;
            label3.Text = "MSGV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label2.Location = new Point(15, 270);
            label2.Name = "label2";
            label2.Size = new Size(218, 54);
            label2.TabIndex = 23;
            label2.Text = "Tên ngành";
            // 
            // cyberGroupBox7
            // 
            cyberGroupBox7.Alpha = 20;
            cyberGroupBox7.BackColor = Color.Transparent;
            cyberGroupBox7.Background = true;
            cyberGroupBox7.Background_WidthPen = 3F;
            cyberGroupBox7.BackgroundPen = true;
            cyberGroupBox7.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberGroupBox7.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox7.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox7.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberGroupBox7.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberGroupBox7.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox7.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox7.Controls.Add(inputnamenganh);
            cyberGroupBox7.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox7.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox7.Lighting = false;
            cyberGroupBox7.LinearGradient_Background = false;
            cyberGroupBox7.LinearGradientPen = false;
            cyberGroupBox7.Location = new Point(320, 257);
            cyberGroupBox7.Name = "cyberGroupBox7";
            cyberGroupBox7.PenWidth = 15;
            cyberGroupBox7.RGB = false;
            cyberGroupBox7.Rounding = true;
            cyberGroupBox7.RoundingInt = 60;
            cyberGroupBox7.Size = new Size(337, 75);
            cyberGroupBox7.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox7.TabIndex = 4;
            cyberGroupBox7.Tag = "Cyber";
            cyberGroupBox7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox7.Timer_RGB = 300;
            // 
            // btnDeleteOfBranchAdd
            // 
            btnDeleteOfBranchAdd.BackgroundColor = Color.FromArgb(255, 173, 153);
            btnDeleteOfBranchAdd.ButtonImage = (Image)resources.GetObject("btnDeleteOfBranchAdd.ButtonImage");
            btnDeleteOfBranchAdd.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnDeleteOfBranchAdd.ButtonText = "Xóa sạch";
            btnDeleteOfBranchAdd.ClickBackColor = Color.Transparent;
            btnDeleteOfBranchAdd.ClickTextColor = Color.White;
            btnDeleteOfBranchAdd.CornerRadius = 40;
            btnDeleteOfBranchAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteOfBranchAdd.Horizontal_Alignment = StringAlignment.Center;
            btnDeleteOfBranchAdd.HoverBackgroundColor = Color.Red;
            btnDeleteOfBranchAdd.HoverTextColor = Color.White;
            btnDeleteOfBranchAdd.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnDeleteOfBranchAdd.Location = new Point(874, 810);
            btnDeleteOfBranchAdd.Name = "btnDeleteOfBranchAdd";
            btnDeleteOfBranchAdd.RightToLeft = RightToLeft.No;
            btnDeleteOfBranchAdd.Size = new Size(283, 83);
            btnDeleteOfBranchAdd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnDeleteOfBranchAdd.TabIndex = 18;
            btnDeleteOfBranchAdd.TextColor = Color.White;
            btnDeleteOfBranchAdd.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnDeleteOfBranchAdd.Vertical_Alignment = StringAlignment.Center;
            // 
            // cyberGroupBox6
            // 
            cyberGroupBox6.Alpha = 20;
            cyberGroupBox6.BackColor = Color.Transparent;
            cyberGroupBox6.Background = true;
            cyberGroupBox6.Background_WidthPen = 3F;
            cyberGroupBox6.BackgroundPen = true;
            cyberGroupBox6.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberGroupBox6.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox6.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox6.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberGroupBox6.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberGroupBox6.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox6.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox6.Controls.Add(inputngaythem);
            cyberGroupBox6.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox6.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox6.Lighting = false;
            cyberGroupBox6.LinearGradient_Background = false;
            cyberGroupBox6.LinearGradientPen = false;
            cyberGroupBox6.Location = new Point(1184, 257);
            cyberGroupBox6.Name = "cyberGroupBox6";
            cyberGroupBox6.PenWidth = 15;
            cyberGroupBox6.RGB = false;
            cyberGroupBox6.Rounding = true;
            cyberGroupBox6.RoundingInt = 60;
            cyberGroupBox6.Size = new Size(380, 75);
            cyberGroupBox6.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox6.TabIndex = 21;
            cyberGroupBox6.Tag = "Cyber";
            cyberGroupBox6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox6.Timer_RGB = 300;
            // 
            // cyberGroupBox2
            // 
            cyberGroupBox2.Alpha = 20;
            cyberGroupBox2.BackColor = Color.Transparent;
            cyberGroupBox2.Background = true;
            cyberGroupBox2.Background_WidthPen = 3F;
            cyberGroupBox2.BackgroundPen = true;
            cyberGroupBox2.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberGroupBox2.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox2.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox2.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberGroupBox2.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberGroupBox2.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox2.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox2.Controls.Add(inputname);
            cyberGroupBox2.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox2.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox2.Lighting = false;
            cyberGroupBox2.LinearGradient_Background = false;
            cyberGroupBox2.LinearGradientPen = false;
            cyberGroupBox2.Location = new Point(1184, 480);
            cyberGroupBox2.Name = "cyberGroupBox2";
            cyberGroupBox2.PenWidth = 15;
            cyberGroupBox2.RGB = false;
            cyberGroupBox2.Rounding = true;
            cyberGroupBox2.RoundingInt = 60;
            cyberGroupBox2.Size = new Size(380, 75);
            cyberGroupBox2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox2.TabIndex = 4;
            cyberGroupBox2.Tag = "Cyber";
            cyberGroupBox2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox2.Timer_RGB = 300;
            // 
            // cyberGroupBox3
            // 
            cyberGroupBox3.Alpha = 20;
            cyberGroupBox3.BackColor = Color.Transparent;
            cyberGroupBox3.Background = true;
            cyberGroupBox3.Background_WidthPen = 3F;
            cyberGroupBox3.BackgroundPen = true;
            cyberGroupBox3.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberGroupBox3.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox3.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox3.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberGroupBox3.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberGroupBox3.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox3.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox3.Controls.Add(inputMSGV);
            cyberGroupBox3.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox3.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox3.Lighting = false;
            cyberGroupBox3.LinearGradient_Background = false;
            cyberGroupBox3.LinearGradientPen = false;
            cyberGroupBox3.Location = new Point(320, 480);
            cyberGroupBox3.Name = "cyberGroupBox3";
            cyberGroupBox3.PenWidth = 15;
            cyberGroupBox3.RGB = false;
            cyberGroupBox3.Rounding = true;
            cyberGroupBox3.RoundingInt = 60;
            cyberGroupBox3.Size = new Size(337, 75);
            cyberGroupBox3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox3.TabIndex = 4;
            cyberGroupBox3.Tag = "Cyber";
            cyberGroupBox3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox3.Timer_RGB = 300;
            // 
            // btnConfirmOfBranchAdd
            // 
            btnConfirmOfBranchAdd.BackgroundColor = Color.FromArgb(133, 224, 133);
            btnConfirmOfBranchAdd.ButtonImage = (Image)resources.GetObject("btnConfirmOfBranchAdd.ButtonImage");
            btnConfirmOfBranchAdd.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnConfirmOfBranchAdd.ButtonText = "Thêm";
            btnConfirmOfBranchAdd.ClickBackColor = Color.Transparent;
            btnConfirmOfBranchAdd.ClickTextColor = Color.White;
            btnConfirmOfBranchAdd.CornerRadius = 40;
            btnConfirmOfBranchAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmOfBranchAdd.Horizontal_Alignment = StringAlignment.Center;
            btnConfirmOfBranchAdd.HoverBackgroundColor = Color.Lime;
            btnConfirmOfBranchAdd.HoverTextColor = Color.White;
            btnConfirmOfBranchAdd.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnConfirmOfBranchAdd.Location = new Point(1250, 810);
            btnConfirmOfBranchAdd.Name = "btnConfirmOfBranchAdd";
            btnConfirmOfBranchAdd.RightToLeft = RightToLeft.No;
            btnConfirmOfBranchAdd.Size = new Size(283, 83);
            btnConfirmOfBranchAdd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnConfirmOfBranchAdd.TabIndex = 19;
            btnConfirmOfBranchAdd.TextColor = Color.White;
            btnConfirmOfBranchAdd.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnConfirmOfBranchAdd.Vertical_Alignment = StringAlignment.Center;
            // 
            // nightPanel1
            // 
            nightPanel1.Controls.Add(cyberGroupBox4);
            nightPanel1.Controls.Add(label7);
            nightPanel1.Controls.Add(label6);
            nightPanel1.Controls.Add(cyberGroupBox1);
            nightPanel1.Controls.Add(label1);
            nightPanel1.Controls.Add(label5);
            nightPanel1.Controls.Add(label3);
            nightPanel1.Controls.Add(cyberGroupBox3);
            nightPanel1.Controls.Add(label2);
            nightPanel1.Controls.Add(cyberGroupBox7);
            nightPanel1.Controls.Add(cyberGroupBox6);
            nightPanel1.Controls.Add(cyberGroupBox2);
            nightPanel1.Controls.Add(btnConfirmOfBranchAdd);
            nightPanel1.Controls.Add(btnDeleteOfBranchAdd);
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
            // UserControlBranchAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(nightPanel1);
            Name = "UserControlBranchAdd";
            Size = new Size(1575, 813);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            cyberGroupBox4.ResumeLayout(false);
            cyberGroupBox1.ResumeLayout(false);
            cyberGroupBox1.PerformLayout();
            cyberGroupBox7.ResumeLayout(false);
            cyberGroupBox7.PerformLayout();
            cyberGroupBox6.ResumeLayout(false);
            cyberGroupBox2.ResumeLayout(false);
            cyberGroupBox2.PerformLayout();
            cyberGroupBox3.ResumeLayout(false);
            cyberGroupBox3.PerformLayout();
            nightPanel1.ResumeLayout(false);
            nightPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ErrorProvider errorProvider1;
        private ReaLTaiizor.Controls.NightPanel nightPanel1;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox4;
        private CustomControl.BorderlessComboBox inputkhoavien;
        private Label label7;
        private Label label6;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox1;
        private TextBox inputid;
        private Label label1;
        private Label label5;
        private Label label3;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox3;
        private TextBox inputMSGV;
        private Label label2;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox7;
        private TextBox inputnamenganh;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox6;
        private CustomControl.CustomDateTimePicker inputngaythem;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox2;
        private TextBox inputname;
        private ReaLTaiizor.Controls.ParrotButton btnConfirmOfBranchAdd;
        private ReaLTaiizor.Controls.ParrotButton btnDeleteOfBranchAdd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
