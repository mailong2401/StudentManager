namespace StudentManager
{
    partial class UserControlSubjectShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlSubjectShow));
            label5 = new Label();
            comboboxnganh = new StudentManager.CustomControl.BorderlessComboBox();
            cyberGroupBox3 = new ReaLTaiizor.Controls.CyberGroupBox();
            inputidMon = new TextBox();
            lbNameNganh = new Label();
            inputNameMon = new TextBox();
            comboboxkhoa = new StudentManager.CustomControl.BorderlessComboBox();
            btnConfirmOfSubjectAdd = new ReaLTaiizor.Controls.ParrotButton();
            parrotButton8 = new ReaLTaiizor.Controls.ParrotButton();
            parrotButton7 = new ReaLTaiizor.Controls.ParrotButton();
            parrotButton6 = new ReaLTaiizor.Controls.ParrotButton();
            parrotButton5 = new ReaLTaiizor.Controls.ParrotButton();
            parrotButton4 = new ReaLTaiizor.Controls.ParrotButton();
            parrotButton3 = new ReaLTaiizor.Controls.ParrotButton();
            parrotButton1 = new ReaLTaiizor.Controls.ParrotButton();
            parrotButton2 = new ReaLTaiizor.Controls.ParrotButton();
            cyberGroupBox2 = new ReaLTaiizor.Controls.CyberGroupBox();
            lbNameKhoa = new Label();
            lbCodeMon = new Label();
            cyberGroupBox4 = new ReaLTaiizor.Controls.CyberGroupBox();
            cyberGroupBox1 = new ReaLTaiizor.Controls.CyberGroupBox();
            lbNameMon = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbNganh = new TableLayoutPanel();
            cyberGroupBox5 = new ReaLTaiizor.Controls.CyberGroupBox();
            comboboxlop = new StudentManager.CustomControl.BorderlessComboBox();
            lbNameLop = new Label();
            label4 = new Label();
            cyberGroupBox3.SuspendLayout();
            cyberGroupBox2.SuspendLayout();
            cyberGroupBox4.SuspendLayout();
            cyberGroupBox1.SuspendLayout();
            cyberGroupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(850, 156);
            label5.Name = "label5";
            label5.Size = new Size(120, 30);
            label5.TabIndex = 93;
            label5.Text = "Tên ngành";
            // 
            // comboboxnganh
            // 
            comboboxnganh.BackColor = Color.FromArgb(37, 52, 68);
            comboboxnganh.DrawMode = DrawMode.OwnerDrawFixed;
            comboboxnganh.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxnganh.FlatStyle = FlatStyle.Flat;
            comboboxnganh.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            comboboxnganh.ForeColor = Color.White;
            comboboxnganh.FormattingEnabled = true;
            comboboxnganh.Location = new Point(12, 9);
            comboboxnganh.Name = "comboboxnganh";
            comboboxnganh.Placeholder = "Chọn một mục...";
            comboboxnganh.Size = new Size(277, 37);
            comboboxnganh.TabIndex = 39;
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
            cyberGroupBox3.Controls.Add(comboboxnganh);
            cyberGroupBox3.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox3.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox3.Lighting = false;
            cyberGroupBox3.LinearGradient_Background = false;
            cyberGroupBox3.LinearGradientPen = false;
            cyberGroupBox3.Location = new Point(750, 70);
            cyberGroupBox3.Name = "cyberGroupBox3";
            cyberGroupBox3.PenWidth = 15;
            cyberGroupBox3.RGB = false;
            cyberGroupBox3.Rounding = true;
            cyberGroupBox3.RoundingInt = 60;
            cyberGroupBox3.Size = new Size(310, 53);
            cyberGroupBox3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox3.TabIndex = 81;
            cyberGroupBox3.Tag = "Cyber";
            cyberGroupBox3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox3.Timer_RGB = 300;
            // 
            // inputidMon
            // 
            inputidMon.BackColor = Color.FromArgb(37, 52, 68);
            inputidMon.BorderStyle = BorderStyle.None;
            inputidMon.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            inputidMon.ForeColor = Color.White;
            inputidMon.Location = new Point(12, 9);
            inputidMon.Margin = new Padding(3, 0, 3, 0);
            inputidMon.Name = "inputidMon";
            inputidMon.PlaceholderText = "Nhập mã môn";
            inputidMon.Size = new Size(270, 32);
            inputidMon.TabIndex = 4;
            // 
            // lbNameNganh
            // 
            lbNameNganh.AutoSize = true;
            lbNameNganh.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbNameNganh.ForeColor = SystemColors.Control;
            lbNameNganh.Location = new Point(600, 70);
            lbNameNganh.Name = "lbNameNganh";
            lbNameNganh.Size = new Size(113, 41);
            lbNameNganh.TabIndex = 83;
            lbNameNganh.Text = "Ngành";
            // 
            // inputNameMon
            // 
            inputNameMon.BackColor = Color.FromArgb(37, 52, 68);
            inputNameMon.BorderStyle = BorderStyle.None;
            inputNameMon.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            inputNameMon.ForeColor = Color.White;
            inputNameMon.Location = new Point(12, 9);
            inputNameMon.Margin = new Padding(3, 0, 3, 0);
            inputNameMon.Name = "inputNameMon";
            inputNameMon.PlaceholderText = "Nhập tên môn";
            inputNameMon.Size = new Size(270, 32);
            inputNameMon.TabIndex = 4;
            // 
            // comboboxkhoa
            // 
            comboboxkhoa.BackColor = Color.FromArgb(37, 52, 68);
            comboboxkhoa.DrawMode = DrawMode.OwnerDrawFixed;
            comboboxkhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxkhoa.FlatStyle = FlatStyle.Flat;
            comboboxkhoa.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            comboboxkhoa.ForeColor = Color.White;
            comboboxkhoa.FormattingEnabled = true;
            comboboxkhoa.Location = new Point(12, 9);
            comboboxkhoa.Name = "comboboxkhoa";
            comboboxkhoa.Placeholder = "Chọn một mục...";
            comboboxkhoa.Size = new Size(277, 37);
            comboboxkhoa.TabIndex = 39;
            // 
            // btnConfirmOfSubjectAdd
            // 
            btnConfirmOfSubjectAdd.BackgroundColor = Color.DimGray;
            btnConfirmOfSubjectAdd.ButtonImage = (Image)resources.GetObject("btnConfirmOfSubjectAdd.ButtonImage");
            btnConfirmOfSubjectAdd.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnConfirmOfSubjectAdd.ButtonText = "Thêm";
            btnConfirmOfSubjectAdd.ClickBackColor = Color.Transparent;
            btnConfirmOfSubjectAdd.ClickTextColor = Color.White;
            btnConfirmOfSubjectAdd.CornerRadius = 25;
            btnConfirmOfSubjectAdd.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnConfirmOfSubjectAdd.Horizontal_Alignment = StringAlignment.Center;
            btnConfirmOfSubjectAdd.HoverBackgroundColor = Color.Lime;
            btnConfirmOfSubjectAdd.HoverTextColor = Color.White;
            btnConfirmOfSubjectAdd.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnConfirmOfSubjectAdd.Location = new Point(1300, 108);
            btnConfirmOfSubjectAdd.Name = "btnConfirmOfSubjectAdd";
            btnConfirmOfSubjectAdd.RightToLeft = RightToLeft.No;
            btnConfirmOfSubjectAdd.Size = new Size(159, 50);
            btnConfirmOfSubjectAdd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnConfirmOfSubjectAdd.TabIndex = 84;
            btnConfirmOfSubjectAdd.TextColor = Color.White;
            btnConfirmOfSubjectAdd.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnConfirmOfSubjectAdd.Vertical_Alignment = StringAlignment.Center;
            // 
            // parrotButton8
            // 
            parrotButton8.BackgroundColor = Color.FromArgb(37, 52, 68);
            parrotButton8.ButtonImage = null;
            parrotButton8.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            parrotButton8.ButtonText = "6";
            parrotButton8.ClickBackColor = Color.FromArgb(195, 195, 195);
            parrotButton8.ClickTextColor = Color.DodgerBlue;
            parrotButton8.CornerRadius = 5;
            parrotButton8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotButton8.Horizontal_Alignment = StringAlignment.Center;
            parrotButton8.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            parrotButton8.HoverTextColor = Color.DodgerBlue;
            parrotButton8.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButton8.Location = new Point(817, 766);
            parrotButton8.Name = "parrotButton8";
            parrotButton8.Size = new Size(32, 32);
            parrotButton8.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButton8.TabIndex = 92;
            parrotButton8.TextColor = Color.White;
            parrotButton8.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButton8.Vertical_Alignment = StringAlignment.Center;
            // 
            // parrotButton7
            // 
            parrotButton7.BackgroundColor = Color.FromArgb(37, 52, 68);
            parrotButton7.ButtonImage = null;
            parrotButton7.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            parrotButton7.ButtonText = "5";
            parrotButton7.ClickBackColor = Color.FromArgb(195, 195, 195);
            parrotButton7.ClickTextColor = Color.DodgerBlue;
            parrotButton7.CornerRadius = 5;
            parrotButton7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotButton7.Horizontal_Alignment = StringAlignment.Center;
            parrotButton7.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            parrotButton7.HoverTextColor = Color.DodgerBlue;
            parrotButton7.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButton7.Location = new Point(779, 766);
            parrotButton7.Name = "parrotButton7";
            parrotButton7.Size = new Size(32, 32);
            parrotButton7.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButton7.TabIndex = 91;
            parrotButton7.TextColor = Color.White;
            parrotButton7.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButton7.Vertical_Alignment = StringAlignment.Center;
            // 
            // parrotButton6
            // 
            parrotButton6.BackgroundColor = Color.FromArgb(37, 52, 68);
            parrotButton6.ButtonImage = null;
            parrotButton6.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            parrotButton6.ButtonText = "4";
            parrotButton6.ClickBackColor = Color.FromArgb(195, 195, 195);
            parrotButton6.ClickTextColor = Color.DodgerBlue;
            parrotButton6.CornerRadius = 5;
            parrotButton6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotButton6.Horizontal_Alignment = StringAlignment.Center;
            parrotButton6.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            parrotButton6.HoverTextColor = Color.DodgerBlue;
            parrotButton6.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButton6.Location = new Point(741, 766);
            parrotButton6.Name = "parrotButton6";
            parrotButton6.Size = new Size(32, 32);
            parrotButton6.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButton6.TabIndex = 90;
            parrotButton6.TextColor = Color.White;
            parrotButton6.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButton6.Vertical_Alignment = StringAlignment.Center;
            // 
            // parrotButton5
            // 
            parrotButton5.BackgroundColor = Color.FromArgb(37, 52, 68);
            parrotButton5.ButtonImage = null;
            parrotButton5.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            parrotButton5.ButtonText = "2";
            parrotButton5.ClickBackColor = Color.FromArgb(195, 195, 195);
            parrotButton5.ClickTextColor = Color.DodgerBlue;
            parrotButton5.CornerRadius = 5;
            parrotButton5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotButton5.Horizontal_Alignment = StringAlignment.Center;
            parrotButton5.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            parrotButton5.HoverTextColor = Color.DodgerBlue;
            parrotButton5.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButton5.Location = new Point(665, 766);
            parrotButton5.Name = "parrotButton5";
            parrotButton5.Size = new Size(32, 32);
            parrotButton5.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButton5.TabIndex = 89;
            parrotButton5.TextColor = Color.White;
            parrotButton5.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButton5.Vertical_Alignment = StringAlignment.Center;
            // 
            // parrotButton4
            // 
            parrotButton4.BackgroundColor = Color.FromArgb(37, 52, 68);
            parrotButton4.ButtonImage = null;
            parrotButton4.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            parrotButton4.ButtonText = "3";
            parrotButton4.ClickBackColor = Color.FromArgb(195, 195, 195);
            parrotButton4.ClickTextColor = Color.DodgerBlue;
            parrotButton4.CornerRadius = 5;
            parrotButton4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotButton4.Horizontal_Alignment = StringAlignment.Center;
            parrotButton4.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            parrotButton4.HoverTextColor = Color.DodgerBlue;
            parrotButton4.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButton4.Location = new Point(703, 766);
            parrotButton4.Name = "parrotButton4";
            parrotButton4.Size = new Size(32, 32);
            parrotButton4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButton4.TabIndex = 88;
            parrotButton4.TextColor = Color.White;
            parrotButton4.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButton4.Vertical_Alignment = StringAlignment.Center;
            // 
            // parrotButton3
            // 
            parrotButton3.BackgroundColor = Color.FromArgb(37, 52, 68);
            parrotButton3.ButtonImage = null;
            parrotButton3.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            parrotButton3.ButtonText = "1";
            parrotButton3.ClickBackColor = Color.FromArgb(195, 195, 195);
            parrotButton3.ClickTextColor = Color.DodgerBlue;
            parrotButton3.CornerRadius = 5;
            parrotButton3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parrotButton3.Horizontal_Alignment = StringAlignment.Center;
            parrotButton3.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            parrotButton3.HoverTextColor = Color.DodgerBlue;
            parrotButton3.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButton3.Location = new Point(627, 766);
            parrotButton3.Name = "parrotButton3";
            parrotButton3.Size = new Size(32, 32);
            parrotButton3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButton3.TabIndex = 87;
            parrotButton3.TextColor = Color.White;
            parrotButton3.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButton3.Vertical_Alignment = StringAlignment.Center;
            // 
            // parrotButton1
            // 
            parrotButton1.BackgroundColor = Color.FromArgb(37, 52, 68);
            parrotButton1.ButtonImage = Properties.Resources.right_arrow;
            parrotButton1.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            parrotButton1.ButtonText = "";
            parrotButton1.ClickBackColor = Color.FromArgb(195, 195, 195);
            parrotButton1.ClickTextColor = Color.DodgerBlue;
            parrotButton1.CornerRadius = 5;
            parrotButton1.Font = new Font("Microsoft Sans Serif", 14F);
            parrotButton1.Horizontal_Alignment = StringAlignment.Center;
            parrotButton1.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            parrotButton1.HoverTextColor = Color.DodgerBlue;
            parrotButton1.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButton1.Location = new Point(861, 766);
            parrotButton1.Name = "parrotButton1";
            parrotButton1.Size = new Size(32, 32);
            parrotButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButton1.TabIndex = 85;
            parrotButton1.TextColor = Color.Black;
            parrotButton1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButton1.Vertical_Alignment = StringAlignment.Center;
            // 
            // parrotButton2
            // 
            parrotButton2.BackgroundColor = Color.FromArgb(37, 52, 68);
            parrotButton2.ButtonImage = Properties.Resources.left_arrow;
            parrotButton2.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            parrotButton2.ButtonText = "";
            parrotButton2.ClickBackColor = Color.FromArgb(195, 195, 195);
            parrotButton2.ClickTextColor = Color.DodgerBlue;
            parrotButton2.CornerRadius = 5;
            parrotButton2.Font = new Font("Microsoft Sans Serif", 14F);
            parrotButton2.Horizontal_Alignment = StringAlignment.Center;
            parrotButton2.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            parrotButton2.HoverTextColor = Color.DodgerBlue;
            parrotButton2.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButton2.Location = new Point(584, 766);
            parrotButton2.Name = "parrotButton2";
            parrotButton2.Size = new Size(32, 32);
            parrotButton2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButton2.TabIndex = 86;
            parrotButton2.TextColor = Color.Black;
            parrotButton2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButton2.Vertical_Alignment = StringAlignment.Center;
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
            cyberGroupBox2.Controls.Add(comboboxkhoa);
            cyberGroupBox2.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox2.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox2.Lighting = false;
            cyberGroupBox2.LinearGradient_Background = false;
            cyberGroupBox2.LinearGradientPen = false;
            cyberGroupBox2.Location = new Point(750, 14);
            cyberGroupBox2.Name = "cyberGroupBox2";
            cyberGroupBox2.PenWidth = 15;
            cyberGroupBox2.RGB = false;
            cyberGroupBox2.Rounding = true;
            cyberGroupBox2.RoundingInt = 60;
            cyberGroupBox2.Size = new Size(310, 53);
            cyberGroupBox2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox2.TabIndex = 79;
            cyberGroupBox2.Tag = "Cyber";
            cyberGroupBox2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox2.Timer_RGB = 300;
            // 
            // lbNameKhoa
            // 
            lbNameKhoa.AutoSize = true;
            lbNameKhoa.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbNameKhoa.ForeColor = SystemColors.Control;
            lbNameKhoa.Location = new Point(600, 14);
            lbNameKhoa.Name = "lbNameKhoa";
            lbNameKhoa.Size = new Size(89, 41);
            lbNameKhoa.TabIndex = 80;
            lbNameKhoa.Text = "Khoa";
            // 
            // lbCodeMon
            // 
            lbCodeMon.AutoSize = true;
            lbCodeMon.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbCodeMon.ForeColor = SystemColors.Control;
            lbCodeMon.Location = new Point(20, 14);
            lbCodeMon.Name = "lbCodeMon";
            lbCodeMon.Size = new Size(142, 41);
            lbCodeMon.TabIndex = 82;
            lbCodeMon.Text = "Mã  môn";
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
            cyberGroupBox4.Controls.Add(inputNameMon);
            cyberGroupBox4.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox4.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox4.Lighting = false;
            cyberGroupBox4.LinearGradient_Background = false;
            cyberGroupBox4.LinearGradientPen = false;
            cyberGroupBox4.Location = new Point(200, 70);
            cyberGroupBox4.Name = "cyberGroupBox4";
            cyberGroupBox4.PenWidth = 15;
            cyberGroupBox4.RGB = false;
            cyberGroupBox4.Rounding = true;
            cyberGroupBox4.RoundingInt = 60;
            cyberGroupBox4.Size = new Size(300, 53);
            cyberGroupBox4.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox4.TabIndex = 76;
            cyberGroupBox4.Tag = "Cyber";
            cyberGroupBox4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox4.Timer_RGB = 300;
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
            cyberGroupBox1.Controls.Add(inputidMon);
            cyberGroupBox1.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox1.Lighting = false;
            cyberGroupBox1.LinearGradient_Background = false;
            cyberGroupBox1.LinearGradientPen = false;
            cyberGroupBox1.Location = new Point(200, 14);
            cyberGroupBox1.Name = "cyberGroupBox1";
            cyberGroupBox1.PenWidth = 15;
            cyberGroupBox1.RGB = false;
            cyberGroupBox1.Rounding = true;
            cyberGroupBox1.RoundingInt = 60;
            cyberGroupBox1.Size = new Size(300, 53);
            cyberGroupBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox1.TabIndex = 78;
            cyberGroupBox1.Tag = "Cyber";
            cyberGroupBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox1.Timer_RGB = 300;
            // 
            // lbNameMon
            // 
            lbNameMon.AutoSize = true;
            lbNameMon.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbNameMon.ForeColor = SystemColors.Control;
            lbNameMon.Location = new Point(20, 70);
            lbNameMon.Name = "lbNameMon";
            lbNameMon.Size = new Size(138, 41);
            lbNameMon.TabIndex = 77;
            lbNameMon.Text = "Tên môn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(550, 156);
            label3.Name = "label3";
            label3.Size = new Size(158, 30);
            label3.TabIndex = 75;
            label3.Text = "Tên khoa/viện";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(200, 156);
            label2.Name = "label2";
            label2.Size = new Size(101, 30);
            label2.TabIndex = 74;
            label2.Text = "Tên môn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(60, 157);
            label1.Name = "label1";
            label1.Size = new Size(98, 30);
            label1.TabIndex = 73;
            label1.Text = "Mã môn";
            // 
            // tbNganh
            // 
            tbNganh.ColumnCount = 1;
            tbNganh.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tbNganh.Location = new Point(47, 200);
            tbNganh.Name = "tbNganh";
            tbNganh.RowCount = 12;
            tbNganh.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tbNganh.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tbNganh.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tbNganh.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tbNganh.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tbNganh.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tbNganh.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tbNganh.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tbNganh.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tbNganh.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tbNganh.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tbNganh.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333332F));
            tbNganh.Size = new Size(1483, 564);
            tbNganh.TabIndex = 72;
            // 
            // cyberGroupBox5
            // 
            cyberGroupBox5.Alpha = 20;
            cyberGroupBox5.BackColor = Color.Transparent;
            cyberGroupBox5.Background = true;
            cyberGroupBox5.Background_WidthPen = 3F;
            cyberGroupBox5.BackgroundPen = true;
            cyberGroupBox5.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberGroupBox5.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox5.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox5.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberGroupBox5.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberGroupBox5.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox5.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox5.Controls.Add(comboboxlop);
            cyberGroupBox5.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox5.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox5.Lighting = false;
            cyberGroupBox5.LinearGradient_Background = false;
            cyberGroupBox5.LinearGradientPen = false;
            cyberGroupBox5.Location = new Point(1250, 14);
            cyberGroupBox5.Name = "cyberGroupBox5";
            cyberGroupBox5.PenWidth = 15;
            cyberGroupBox5.RGB = false;
            cyberGroupBox5.Rounding = true;
            cyberGroupBox5.RoundingInt = 60;
            cyberGroupBox5.Size = new Size(310, 53);
            cyberGroupBox5.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox5.TabIndex = 81;
            cyberGroupBox5.Tag = "Cyber";
            cyberGroupBox5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox5.Timer_RGB = 300;
            // 
            // comboboxlop
            // 
            comboboxlop.BackColor = Color.FromArgb(37, 52, 68);
            comboboxlop.DrawMode = DrawMode.OwnerDrawFixed;
            comboboxlop.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxlop.FlatStyle = FlatStyle.Flat;
            comboboxlop.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            comboboxlop.ForeColor = Color.White;
            comboboxlop.FormattingEnabled = true;
            comboboxlop.Location = new Point(12, 9);
            comboboxlop.Name = "comboboxlop";
            comboboxlop.Placeholder = "Chọn một mục...";
            comboboxlop.Size = new Size(277, 37);
            comboboxlop.TabIndex = 39;
            // 
            // lbNameLop
            // 
            lbNameLop.AutoSize = true;
            lbNameLop.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbNameLop.ForeColor = SystemColors.Control;
            lbNameLop.Location = new Point(1150, 14);
            lbNameLop.Name = "lbNameLop";
            lbNameLop.Size = new Size(71, 41);
            lbNameLop.TabIndex = 82;
            lbNameLop.Text = "Lớp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(1150, 156);
            label4.Name = "label4";
            label4.Size = new Size(89, 30);
            label4.TabIndex = 94;
            label4.Text = "Tên lớp";
            // 
            // UserControlSubjectShow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 61);
            Controls.Add(label4);
            Controls.Add(cyberGroupBox5);
            Controls.Add(lbNameLop);
            Controls.Add(label5);
            Controls.Add(cyberGroupBox3);
            Controls.Add(lbNameNganh);
            Controls.Add(btnConfirmOfSubjectAdd);
            Controls.Add(parrotButton8);
            Controls.Add(parrotButton7);
            Controls.Add(parrotButton6);
            Controls.Add(parrotButton5);
            Controls.Add(parrotButton4);
            Controls.Add(parrotButton3);
            Controls.Add(parrotButton1);
            Controls.Add(parrotButton2);
            Controls.Add(cyberGroupBox2);
            Controls.Add(lbNameKhoa);
            Controls.Add(lbCodeMon);
            Controls.Add(cyberGroupBox4);
            Controls.Add(cyberGroupBox1);
            Controls.Add(lbNameMon);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbNganh);
            Name = "UserControlSubjectShow";
            Size = new Size(1575, 813);
            cyberGroupBox3.ResumeLayout(false);
            cyberGroupBox2.ResumeLayout(false);
            cyberGroupBox4.ResumeLayout(false);
            cyberGroupBox4.PerformLayout();
            cyberGroupBox1.ResumeLayout(false);
            cyberGroupBox1.PerformLayout();
            cyberGroupBox5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private CustomControl.BorderlessComboBox comboboxnganh;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox3;
        private TextBox inputidMon;
        private Label lbNameNganh;
        private TextBox inputNameMon;
        private CustomControl.BorderlessComboBox comboboxkhoa;
        private ReaLTaiizor.Controls.ParrotButton btnConfirmOfSubjectAdd;
        private ReaLTaiizor.Controls.ParrotButton parrotButton8;
        private ReaLTaiizor.Controls.ParrotButton parrotButton7;
        private ReaLTaiizor.Controls.ParrotButton parrotButton6;
        private ReaLTaiizor.Controls.ParrotButton parrotButton5;
        private ReaLTaiizor.Controls.ParrotButton parrotButton4;
        private ReaLTaiizor.Controls.ParrotButton parrotButton3;
        private ReaLTaiizor.Controls.ParrotButton parrotButton1;
        private ReaLTaiizor.Controls.ParrotButton parrotButton2;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox2;
        private Label lbNameKhoa;
        private Label lbCodeMon;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox4;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox1;
        private Label lbNameMon;
        private Label label3;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tbNganh;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox5;
        private CustomControl.BorderlessComboBox comboboxlop;
        private Label lbNameLop;
        private Label label4;
    }
}
