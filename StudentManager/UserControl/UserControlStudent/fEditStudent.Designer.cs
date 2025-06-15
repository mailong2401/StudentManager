namespace StudentManager
{
    partial class fEditStudent
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
            btn_delete = new ReaLTaiizor.Controls.ParrotButton();
            btn_edit = new ReaLTaiizor.Controls.ParrotButton();
            label7 = new Label();
            radio_btn_female = new ReaLTaiizor.Controls.CyberRadioButton();
            radio_btn_male = new ReaLTaiizor.Controls.CyberRadioButton();
            label6 = new Label();
            label4 = new Label();
            cyberGroupBox6 = new ReaLTaiizor.Controls.CyberGroupBox();
            inputngaysinh = new StudentManager.CustomControl.CustomDateTimePicker();
            cyberGroupBox5 = new ReaLTaiizor.Controls.CyberGroupBox();
            inputlop = new StudentManager.CustomControl.BorderlessComboBox();
            label5 = new Label();
            label3 = new Label();
            cyberGroupBox3 = new ReaLTaiizor.Controls.CyberGroupBox();
            inputphone = new TextBox();
            cyberGroupBox2 = new ReaLTaiizor.Controls.CyberGroupBox();
            inputdiachi = new TextBox();
            cyberGroupBox1 = new ReaLTaiizor.Controls.CyberGroupBox();
            inputid = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cyberGroupBox7 = new ReaLTaiizor.Controls.CyberGroupBox();
            inputname = new TextBox();
            cyberGroupBox6.SuspendLayout();
            cyberGroupBox5.SuspendLayout();
            cyberGroupBox3.SuspendLayout();
            cyberGroupBox2.SuspendLayout();
            cyberGroupBox1.SuspendLayout();
            cyberGroupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // btn_delete
            // 
            btn_delete.BackgroundColor = Color.DimGray;
            btn_delete.ButtonImage = Properties.Resources.bin__1_;
            btn_delete.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btn_delete.ButtonText = "Xóa";
            btn_delete.ClickBackColor = Color.Transparent;
            btn_delete.ClickTextColor = Color.White;
            btn_delete.CornerRadius = 25;
            btn_delete.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.Horizontal_Alignment = StringAlignment.Center;
            btn_delete.HoverBackgroundColor = Color.Lime;
            btn_delete.HoverTextColor = Color.White;
            btn_delete.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btn_delete.Location = new Point(802, 436);
            btn_delete.Name = "btn_delete";
            btn_delete.RightToLeft = RightToLeft.No;
            btn_delete.Size = new Size(227, 57);
            btn_delete.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btn_delete.TabIndex = 76;
            btn_delete.TextColor = Color.White;
            btn_delete.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btn_delete.Vertical_Alignment = StringAlignment.Center;
            // 
            // btn_edit
            // 
            btn_edit.BackgroundColor = Color.DimGray;
            btn_edit.ButtonImage = Properties.Resources.pen;
            btn_edit.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btn_edit.ButtonText = "Sửa";
            btn_edit.ClickBackColor = Color.Transparent;
            btn_edit.ClickTextColor = Color.White;
            btn_edit.CornerRadius = 25;
            btn_edit.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_edit.Horizontal_Alignment = StringAlignment.Center;
            btn_edit.HoverBackgroundColor = Color.Lime;
            btn_edit.HoverTextColor = Color.White;
            btn_edit.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btn_edit.Location = new Point(1145, 436);
            btn_edit.Name = "btn_edit";
            btn_edit.RightToLeft = RightToLeft.No;
            btn_edit.Size = new Size(227, 57);
            btn_edit.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btn_edit.TabIndex = 75;
            btn_edit.TextColor = Color.White;
            btn_edit.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btn_edit.Vertical_Alignment = StringAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(61, 439);
            label7.Name = "label7";
            label7.Size = new Size(184, 54);
            label7.TabIndex = 74;
            label7.Text = "Giới tính";
            // 
            // radio_btn_female
            // 
            radio_btn_female.BackColor = Color.Transparent;
            radio_btn_female.Background = true;
            radio_btn_female.Background_WidthPen = 2F;
            radio_btn_female.BackgroundPen = true;
            radio_btn_female.Checked = false;
            radio_btn_female.Color_1_Background_value = Color.Empty;
            radio_btn_female.Color_2_Background_value = Color.Empty;
            radio_btn_female.ColorBackground = Color.FromArgb(37, 52, 68);
            radio_btn_female.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            radio_btn_female.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            radio_btn_female.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            radio_btn_female.ColorChecked = Color.FromArgb(29, 200, 238);
            radio_btn_female.ColorPen_1 = Color.FromArgb(37, 52, 68);
            radio_btn_female.ColorPen_2 = Color.FromArgb(41, 63, 86);
            radio_btn_female.CyberRadioButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            radio_btn_female.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            radio_btn_female.Effect_1_Transparency = 25;
            radio_btn_female.Effect_2 = true;
            radio_btn_female.Effect_2_ColorBackground = Color.White;
            radio_btn_female.Effect_2_Transparency = 15;
            radio_btn_female.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            radio_btn_female.ForeColor = Color.FromArgb(245, 245, 245);
            radio_btn_female.LinearGradient_Background = false;
            radio_btn_female.LinearGradient_Value = false;
            radio_btn_female.LinearGradientPen = false;
            radio_btn_female.Location = new Point(557, 448);
            radio_btn_female.Name = "radio_btn_female";
            radio_btn_female.RGB = false;
            radio_btn_female.Rounding = true;
            radio_btn_female.RoundingInt = 100;
            radio_btn_female.Size = new Size(146, 45);
            radio_btn_female.SizeChecked = 8;
            radio_btn_female.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            radio_btn_female.TabIndex = 73;
            radio_btn_female.Tag = "Cyber";
            radio_btn_female.TextButton = "Nữ";
            radio_btn_female.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            radio_btn_female.Timer_Effect_1 = 1;
            radio_btn_female.Timer_RGB = 300;
            // 
            // radio_btn_male
            // 
            radio_btn_male.BackColor = Color.Transparent;
            radio_btn_male.Background = true;
            radio_btn_male.Background_WidthPen = 2F;
            radio_btn_male.BackgroundPen = true;
            radio_btn_male.Checked = false;
            radio_btn_male.Color_1_Background_value = Color.Empty;
            radio_btn_male.Color_2_Background_value = Color.Empty;
            radio_btn_male.ColorBackground = Color.FromArgb(37, 52, 68);
            radio_btn_male.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            radio_btn_male.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            radio_btn_male.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            radio_btn_male.ColorChecked = Color.FromArgb(29, 200, 238);
            radio_btn_male.ColorPen_1 = Color.FromArgb(37, 52, 68);
            radio_btn_male.ColorPen_2 = Color.FromArgb(41, 63, 86);
            radio_btn_male.CyberRadioButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            radio_btn_male.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            radio_btn_male.Effect_1_Transparency = 25;
            radio_btn_male.Effect_2 = true;
            radio_btn_male.Effect_2_ColorBackground = Color.White;
            radio_btn_male.Effect_2_Transparency = 15;
            radio_btn_male.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            radio_btn_male.ForeColor = Color.FromArgb(245, 245, 245);
            radio_btn_male.LinearGradient_Background = false;
            radio_btn_male.LinearGradient_Value = false;
            radio_btn_male.LinearGradientPen = false;
            radio_btn_male.Location = new Point(379, 448);
            radio_btn_male.Name = "radio_btn_male";
            radio_btn_male.RGB = false;
            radio_btn_male.Rounding = true;
            radio_btn_male.RoundingInt = 100;
            radio_btn_male.Size = new Size(148, 45);
            radio_btn_male.SizeChecked = 8;
            radio_btn_male.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            radio_btn_male.TabIndex = 72;
            radio_btn_male.Tag = "Cyber";
            radio_btn_male.TextButton = "Nam";
            radio_btn_male.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            radio_btn_male.Timer_Effect_1 = 1;
            radio_btn_male.Timer_RGB = 300;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(768, 293);
            label6.Name = "label6";
            label6.Size = new Size(212, 54);
            label6.TabIndex = 71;
            label6.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(768, 179);
            label4.Name = "label4";
            label4.Size = new Size(93, 54);
            label4.TabIndex = 70;
            label4.Text = "Lớp";
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
            cyberGroupBox6.Controls.Add(inputngaysinh);
            cyberGroupBox6.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox6.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox6.Lighting = false;
            cyberGroupBox6.LinearGradient_Background = false;
            cyberGroupBox6.LinearGradientPen = false;
            cyberGroupBox6.Location = new Point(996, 282);
            cyberGroupBox6.Name = "cyberGroupBox6";
            cyberGroupBox6.PenWidth = 15;
            cyberGroupBox6.RGB = false;
            cyberGroupBox6.Rounding = true;
            cyberGroupBox6.RoundingInt = 60;
            cyberGroupBox6.Size = new Size(376, 75);
            cyberGroupBox6.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox6.TabIndex = 69;
            cyberGroupBox6.Tag = "Cyber";
            cyberGroupBox6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox6.Timer_RGB = 300;
            // 
            // inputngaysinh
            // 
            inputngaysinh.BackColor = Color.FromArgb(37, 52, 68);
            inputngaysinh.CustomFormat = "dd/MM/yyyy";
            inputngaysinh.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            inputngaysinh.ForeColor = Color.White;
            inputngaysinh.Format = DateTimePickerFormat.Custom;
            inputngaysinh.Location = new Point(24, 10);
            inputngaysinh.Name = "inputngaysinh";
            inputngaysinh.Size = new Size(309, 52);
            inputngaysinh.TabIndex = 0;
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
            cyberGroupBox5.Controls.Add(inputlop);
            cyberGroupBox5.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox5.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox5.Lighting = false;
            cyberGroupBox5.LinearGradient_Background = false;
            cyberGroupBox5.LinearGradientPen = false;
            cyberGroupBox5.Location = new Point(999, 169);
            cyberGroupBox5.Name = "cyberGroupBox5";
            cyberGroupBox5.PenWidth = 15;
            cyberGroupBox5.RGB = false;
            cyberGroupBox5.Rounding = true;
            cyberGroupBox5.RoundingInt = 60;
            cyberGroupBox5.Size = new Size(373, 75);
            cyberGroupBox5.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox5.TabIndex = 68;
            cyberGroupBox5.Tag = "Cyber";
            cyberGroupBox5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox5.Timer_RGB = 300;
            // 
            // inputlop
            // 
            inputlop.BackColor = Color.FromArgb(37, 52, 68);
            inputlop.DrawMode = DrawMode.OwnerDrawFixed;
            inputlop.DropDownStyle = ComboBoxStyle.DropDownList;
            inputlop.FlatStyle = FlatStyle.Flat;
            inputlop.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            inputlop.ForeColor = Color.White;
            inputlop.FormattingEnabled = true;
            inputlop.Items.AddRange(new object[] { "23DTHHA2", "23DTHHA3", "23DTHHA1" });
            inputlop.Location = new Point(24, 10);
            inputlop.Name = "inputlop";
            inputlop.Placeholder = "Chọn lớp...";
            inputlop.Size = new Size(335, 53);
            inputlop.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(768, 66);
            label5.Name = "label5";
            label5.Size = new Size(151, 54);
            label5.TabIndex = 67;
            label5.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(61, 297);
            label3.Name = "label3";
            label3.Size = new Size(270, 54);
            label3.TabIndex = 66;
            label3.Text = "Số điện thoại";
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
            cyberGroupBox3.Controls.Add(inputphone);
            cyberGroupBox3.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox3.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox3.Lighting = false;
            cyberGroupBox3.LinearGradient_Background = false;
            cyberGroupBox3.LinearGradientPen = false;
            cyberGroupBox3.Location = new Point(366, 282);
            cyberGroupBox3.Name = "cyberGroupBox3";
            cyberGroupBox3.PenWidth = 15;
            cyberGroupBox3.RGB = false;
            cyberGroupBox3.Rounding = true;
            cyberGroupBox3.RoundingInt = 60;
            cyberGroupBox3.Size = new Size(337, 75);
            cyberGroupBox3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox3.TabIndex = 64;
            cyberGroupBox3.Tag = "Cyber";
            cyberGroupBox3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox3.Timer_RGB = 300;
            // 
            // inputphone
            // 
            inputphone.BackColor = Color.FromArgb(37, 52, 68);
            inputphone.BorderStyle = BorderStyle.None;
            inputphone.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            inputphone.ForeColor = Color.White;
            inputphone.Location = new Point(13, 14);
            inputphone.Margin = new Padding(3, 0, 3, 0);
            inputphone.Name = "inputphone";
            inputphone.PlaceholderText = "Nhập số điện thoại";
            inputphone.Size = new Size(309, 45);
            inputphone.TabIndex = 3;
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
            cyberGroupBox2.Controls.Add(inputdiachi);
            cyberGroupBox2.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox2.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox2.Lighting = false;
            cyberGroupBox2.LinearGradient_Background = false;
            cyberGroupBox2.LinearGradientPen = false;
            cyberGroupBox2.Location = new Point(999, 52);
            cyberGroupBox2.Name = "cyberGroupBox2";
            cyberGroupBox2.PenWidth = 15;
            cyberGroupBox2.RGB = false;
            cyberGroupBox2.Rounding = true;
            cyberGroupBox2.RoundingInt = 60;
            cyberGroupBox2.Size = new Size(373, 75);
            cyberGroupBox2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox2.TabIndex = 65;
            cyberGroupBox2.Tag = "Cyber";
            cyberGroupBox2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox2.Timer_RGB = 300;
            // 
            // inputdiachi
            // 
            inputdiachi.BackColor = Color.FromArgb(37, 52, 68);
            inputdiachi.BorderStyle = BorderStyle.None;
            inputdiachi.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            inputdiachi.ForeColor = Color.White;
            inputdiachi.Location = new Point(13, 14);
            inputdiachi.Margin = new Padding(3, 0, 3, 0);
            inputdiachi.Name = "inputdiachi";
            inputdiachi.PlaceholderText = "Nhập địa chỉ";
            inputdiachi.Size = new Size(309, 45);
            inputdiachi.TabIndex = 3;
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
            cyberGroupBox1.Location = new Point(366, 52);
            cyberGroupBox1.Name = "cyberGroupBox1";
            cyberGroupBox1.PenWidth = 15;
            cyberGroupBox1.RGB = false;
            cyberGroupBox1.Rounding = true;
            cyberGroupBox1.RoundingInt = 60;
            cyberGroupBox1.Size = new Size(337, 75);
            cyberGroupBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox1.TabIndex = 61;
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
            inputid.PlaceholderText = "Nhập MSSV";
            inputid.Size = new Size(299, 45);
            inputid.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(61, 63);
            label1.Name = "label1";
            label1.Size = new Size(132, 54);
            label1.TabIndex = 63;
            label1.Text = "MSSV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(61, 182);
            label2.Name = "label2";
            label2.Size = new Size(205, 54);
            label2.TabIndex = 62;
            label2.Text = "Họ và tên";
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
            cyberGroupBox7.Controls.Add(inputname);
            cyberGroupBox7.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox7.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox7.Lighting = false;
            cyberGroupBox7.LinearGradient_Background = false;
            cyberGroupBox7.LinearGradientPen = false;
            cyberGroupBox7.Location = new Point(366, 169);
            cyberGroupBox7.Name = "cyberGroupBox7";
            cyberGroupBox7.PenWidth = 15;
            cyberGroupBox7.RGB = false;
            cyberGroupBox7.Rounding = true;
            cyberGroupBox7.RoundingInt = 60;
            cyberGroupBox7.Size = new Size(337, 75);
            cyberGroupBox7.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox7.TabIndex = 60;
            cyberGroupBox7.Tag = "Cyber";
            cyberGroupBox7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox7.Timer_RGB = 300;
            // 
            // inputname
            // 
            inputname.BackColor = Color.FromArgb(37, 52, 68);
            inputname.BorderStyle = BorderStyle.None;
            inputname.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            inputname.ForeColor = Color.White;
            inputname.Location = new Point(13, 13);
            inputname.Margin = new Padding(3, 0, 3, 0);
            inputname.Name = "inputname";
            inputname.PlaceholderText = "Nhập họ và tên";
            inputname.Size = new Size(309, 45);
            inputname.TabIndex = 3;
            // 
            // fEditStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 61);
            ClientSize = new Size(1432, 545);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(label7);
            Controls.Add(radio_btn_female);
            Controls.Add(radio_btn_male);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(cyberGroupBox6);
            Controls.Add(cyberGroupBox5);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(cyberGroupBox3);
            Controls.Add(cyberGroupBox2);
            Controls.Add(cyberGroupBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(cyberGroupBox7);
            Name = "fEditStudent";
            Text = "fEditStudent";
            cyberGroupBox6.ResumeLayout(false);
            cyberGroupBox5.ResumeLayout(false);
            cyberGroupBox3.ResumeLayout(false);
            cyberGroupBox3.PerformLayout();
            cyberGroupBox2.ResumeLayout(false);
            cyberGroupBox2.PerformLayout();
            cyberGroupBox1.ResumeLayout(false);
            cyberGroupBox1.PerformLayout();
            cyberGroupBox7.ResumeLayout(false);
            cyberGroupBox7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotButton btn_delete;
        private ReaLTaiizor.Controls.ParrotButton btn_edit;
        private Label label7;
        private ReaLTaiizor.Controls.CyberRadioButton radio_btn_female;
        private ReaLTaiizor.Controls.CyberRadioButton radio_btn_male;
        private Label label6;
        private Label label4;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox6;
        private CustomControl.CustomDateTimePicker inputngaysinh;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox5;
        private CustomControl.BorderlessComboBox inputlop;
        private Label label5;
        private Label label3;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox3;
        private TextBox inputphone;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox2;
        private TextBox inputdiachi;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox1;
        private TextBox inputid;
        private Label label1;
        private Label label2;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox7;
        private TextBox inputname;
    }
}