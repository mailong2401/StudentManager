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
            panelMain = new Panel();
            pbidkhoa = new PictureBox();
            btnSearch = new ReaLTaiizor.Controls.ParrotButton();
            cyberGroupBox1 = new ReaLTaiizor.Controls.CyberGroupBox();
            inputidKhoa = new TextBox();
            page6 = new ReaLTaiizor.Controls.ParrotButton();
            page5 = new ReaLTaiizor.Controls.ParrotButton();
            page4 = new ReaLTaiizor.Controls.ParrotButton();
            page2 = new ReaLTaiizor.Controls.ParrotButton();
            page3 = new ReaLTaiizor.Controls.ParrotButton();
            page1 = new ReaLTaiizor.Controls.ParrotButton();
            pageLeft = new ReaLTaiizor.Controls.ParrotButton();
            pageRight = new ReaLTaiizor.Controls.ParrotButton();
            btnConfirmOfUDAdd = new ReaLTaiizor.Controls.ParrotButton();
            lbnamekhoa = new Label();
            lbkhoa = new Label();
            tablekhoa = new TableLayoutPanel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pbnamekhoa = new PictureBox();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbidkhoa).BeginInit();
            cyberGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbnamekhoa).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(pbnamekhoa);
            panelMain.Controls.Add(pbidkhoa);
            panelMain.Controls.Add(btnSearch);
            panelMain.Controls.Add(cyberGroupBox1);
            panelMain.Controls.Add(page6);
            panelMain.Controls.Add(page5);
            panelMain.Controls.Add(page4);
            panelMain.Controls.Add(page2);
            panelMain.Controls.Add(page3);
            panelMain.Controls.Add(page1);
            panelMain.Controls.Add(pageLeft);
            panelMain.Controls.Add(pageRight);
            panelMain.Controls.Add(btnConfirmOfUDAdd);
            panelMain.Controls.Add(lbnamekhoa);
            panelMain.Controls.Add(lbkhoa);
            panelMain.Controls.Add(tablekhoa);
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1704, 807);
            panelMain.TabIndex = 48;
            // 
            // pbidkhoa
            // 
            pbidkhoa.Location = new Point(155, 147);
            pbidkhoa.Name = "pbidkhoa";
            pbidkhoa.Size = new Size(24, 24);
            pbidkhoa.SizeMode = PictureBoxSizeMode.Zoom;
            pbidkhoa.TabIndex = 62;
            pbidkhoa.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.BackgroundColor = Color.DimGray;
            btnSearch.ButtonImage = Properties.Resources.loupe;
            btnSearch.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnSearch.ButtonText = "Tìm kiếm";
            btnSearch.ClickBackColor = Color.Transparent;
            btnSearch.ClickTextColor = Color.White;
            btnSearch.CornerRadius = 25;
            btnSearch.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSearch.Horizontal_Alignment = StringAlignment.Center;
            btnSearch.HoverBackgroundColor = Color.Lime;
            btnSearch.HoverTextColor = Color.White;
            btnSearch.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnSearch.Location = new Point(655, 90);
            btnSearch.Name = "btnSearch";
            btnSearch.RightToLeft = RightToLeft.No;
            btnSearch.Size = new Size(185, 50);
            btnSearch.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSearch.TabIndex = 61;
            btnSearch.TextColor = Color.White;
            btnSearch.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSearch.Vertical_Alignment = StringAlignment.Center;
            btnSearch.Click += btnSearch_Click;
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
            cyberGroupBox1.Location = new Point(566, 11);
            cyberGroupBox1.Name = "cyberGroupBox1";
            cyberGroupBox1.PenWidth = 15;
            cyberGroupBox1.RGB = false;
            cyberGroupBox1.Rounding = true;
            cyberGroupBox1.RoundingInt = 60;
            cyberGroupBox1.Size = new Size(377, 63);
            cyberGroupBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox1.TabIndex = 60;
            cyberGroupBox1.Tag = "Cyber";
            cyberGroupBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox1.Timer_RGB = 300;
            // 
            // inputidKhoa
            // 
            inputidKhoa.BackColor = Color.FromArgb(37, 52, 68);
            inputidKhoa.BorderStyle = BorderStyle.None;
            inputidKhoa.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            inputidKhoa.ForeColor = Color.White;
            inputidKhoa.Location = new Point(16, 11);
            inputidKhoa.Margin = new Padding(3, 0, 3, 0);
            inputidKhoa.Name = "inputidKhoa";
            inputidKhoa.PlaceholderText = "Nhập mã khoa";
            inputidKhoa.Size = new Size(339, 38);
            inputidKhoa.TabIndex = 4;
            // 
            // page6
            // 
            page6.BackgroundColor = Color.FromArgb(37, 52, 68);
            page6.ButtonImage = null;
            page6.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            page6.ButtonText = "6";
            page6.ClickBackColor = Color.FromArgb(195, 195, 195);
            page6.ClickTextColor = Color.DodgerBlue;
            page6.CornerRadius = 5;
            page6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            page6.Horizontal_Alignment = StringAlignment.Center;
            page6.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            page6.HoverTextColor = Color.DodgerBlue;
            page6.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            page6.Location = new Point(693, 763);
            page6.Name = "page6";
            page6.Size = new Size(32, 32);
            page6.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            page6.TabIndex = 59;
            page6.TextColor = Color.White;
            page6.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            page6.Vertical_Alignment = StringAlignment.Center;
            // 
            // page5
            // 
            page5.BackgroundColor = Color.FromArgb(37, 52, 68);
            page5.ButtonImage = null;
            page5.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            page5.ButtonText = "5";
            page5.ClickBackColor = Color.FromArgb(195, 195, 195);
            page5.ClickTextColor = Color.DodgerBlue;
            page5.CornerRadius = 5;
            page5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            page5.Horizontal_Alignment = StringAlignment.Center;
            page5.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            page5.HoverTextColor = Color.DodgerBlue;
            page5.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            page5.Location = new Point(655, 763);
            page5.Name = "page5";
            page5.Size = new Size(32, 32);
            page5.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            page5.TabIndex = 58;
            page5.TextColor = Color.White;
            page5.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            page5.Vertical_Alignment = StringAlignment.Center;
            // 
            // page4
            // 
            page4.BackgroundColor = Color.FromArgb(37, 52, 68);
            page4.ButtonImage = null;
            page4.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            page4.ButtonText = "4";
            page4.ClickBackColor = Color.FromArgb(195, 195, 195);
            page4.ClickTextColor = Color.DodgerBlue;
            page4.CornerRadius = 5;
            page4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            page4.Horizontal_Alignment = StringAlignment.Center;
            page4.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            page4.HoverTextColor = Color.DodgerBlue;
            page4.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            page4.Location = new Point(617, 763);
            page4.Name = "page4";
            page4.Size = new Size(32, 32);
            page4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            page4.TabIndex = 57;
            page4.TextColor = Color.White;
            page4.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            page4.Vertical_Alignment = StringAlignment.Center;
            // 
            // page2
            // 
            page2.BackgroundColor = Color.FromArgb(37, 52, 68);
            page2.ButtonImage = null;
            page2.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            page2.ButtonText = "2";
            page2.ClickBackColor = Color.FromArgb(195, 195, 195);
            page2.ClickTextColor = Color.DodgerBlue;
            page2.CornerRadius = 5;
            page2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            page2.Horizontal_Alignment = StringAlignment.Center;
            page2.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            page2.HoverTextColor = Color.DodgerBlue;
            page2.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            page2.Location = new Point(541, 763);
            page2.Name = "page2";
            page2.Size = new Size(32, 32);
            page2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            page2.TabIndex = 56;
            page2.TextColor = Color.White;
            page2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            page2.Vertical_Alignment = StringAlignment.Center;
            // 
            // page3
            // 
            page3.BackgroundColor = Color.FromArgb(37, 52, 68);
            page3.ButtonImage = null;
            page3.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            page3.ButtonText = "3";
            page3.ClickBackColor = Color.FromArgb(195, 195, 195);
            page3.ClickTextColor = Color.DodgerBlue;
            page3.CornerRadius = 5;
            page3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            page3.Horizontal_Alignment = StringAlignment.Center;
            page3.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            page3.HoverTextColor = Color.DodgerBlue;
            page3.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            page3.Location = new Point(579, 763);
            page3.Name = "page3";
            page3.Size = new Size(32, 32);
            page3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            page3.TabIndex = 55;
            page3.TextColor = Color.White;
            page3.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            page3.Vertical_Alignment = StringAlignment.Center;
            // 
            // page1
            // 
            page1.BackgroundColor = Color.FromArgb(37, 52, 68);
            page1.ButtonImage = null;
            page1.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            page1.ButtonText = "1";
            page1.ClickBackColor = Color.FromArgb(195, 195, 195);
            page1.ClickTextColor = Color.DodgerBlue;
            page1.CornerRadius = 5;
            page1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            page1.Horizontal_Alignment = StringAlignment.Center;
            page1.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            page1.HoverTextColor = Color.DodgerBlue;
            page1.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            page1.Location = new Point(503, 763);
            page1.Name = "page1";
            page1.Size = new Size(32, 32);
            page1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            page1.TabIndex = 54;
            page1.TextColor = Color.White;
            page1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            page1.Vertical_Alignment = StringAlignment.Center;
            // 
            // pageLeft
            // 
            pageLeft.BackgroundColor = Color.FromArgb(37, 52, 68);
            pageLeft.ButtonImage = Properties.Resources.left_arrow;
            pageLeft.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            pageLeft.ButtonText = "";
            pageLeft.ClickBackColor = Color.FromArgb(195, 195, 195);
            pageLeft.ClickTextColor = Color.DodgerBlue;
            pageLeft.CornerRadius = 5;
            pageLeft.Font = new Font("Microsoft Sans Serif", 14F);
            pageLeft.Horizontal_Alignment = StringAlignment.Center;
            pageLeft.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            pageLeft.HoverTextColor = Color.DodgerBlue;
            pageLeft.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            pageLeft.Location = new Point(460, 763);
            pageLeft.Name = "pageLeft";
            pageLeft.Size = new Size(32, 32);
            pageLeft.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pageLeft.TabIndex = 53;
            pageLeft.TextColor = Color.Black;
            pageLeft.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            pageLeft.Vertical_Alignment = StringAlignment.Center;
            // 
            // pageRight
            // 
            pageRight.BackgroundColor = Color.FromArgb(37, 52, 68);
            pageRight.ButtonImage = Properties.Resources.right_arrow;
            pageRight.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Material;
            pageRight.ButtonText = "";
            pageRight.ClickBackColor = Color.FromArgb(195, 195, 195);
            pageRight.ClickTextColor = Color.DodgerBlue;
            pageRight.CornerRadius = 5;
            pageRight.Font = new Font("Microsoft Sans Serif", 14F);
            pageRight.Horizontal_Alignment = StringAlignment.Center;
            pageRight.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            pageRight.HoverTextColor = Color.DodgerBlue;
            pageRight.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            pageRight.Location = new Point(737, 763);
            pageRight.Name = "pageRight";
            pageRight.Size = new Size(32, 32);
            pageRight.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pageRight.TabIndex = 52;
            pageRight.TextColor = Color.Black;
            pageRight.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            pageRight.Vertical_Alignment = StringAlignment.Center;
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
            btnConfirmOfUDAdd.Location = new Point(1239, 24);
            btnConfirmOfUDAdd.Name = "btnConfirmOfUDAdd";
            btnConfirmOfUDAdd.RightToLeft = RightToLeft.No;
            btnConfirmOfUDAdd.Size = new Size(185, 50);
            btnConfirmOfUDAdd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnConfirmOfUDAdd.TabIndex = 51;
            btnConfirmOfUDAdd.TextColor = Color.White;
            btnConfirmOfUDAdd.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnConfirmOfUDAdd.Vertical_Alignment = StringAlignment.Center;
            btnConfirmOfUDAdd.Click += btnConfirmOfUDAdd_Click;
            // 
            // lbnamekhoa
            // 
            lbnamekhoa.AutoSize = true;
            lbnamekhoa.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbnamekhoa.ForeColor = SystemColors.ControlDark;
            lbnamekhoa.Location = new Point(439, 141);
            lbnamekhoa.Name = "lbnamekhoa";
            lbnamekhoa.Size = new Size(107, 30);
            lbnamekhoa.TabIndex = 50;
            lbnamekhoa.Text = "Tên Khoa";
            lbnamekhoa.Click += lbnamekhoa_Click;
            // 
            // lbkhoa
            // 
            lbkhoa.AutoSize = true;
            lbkhoa.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbkhoa.ForeColor = SystemColors.ControlDark;
            lbkhoa.Image = Properties.Resources.down_chevron;
            lbkhoa.ImageAlign = ContentAlignment.MiddleRight;
            lbkhoa.Location = new Point(47, 141);
            lbkhoa.Name = "lbkhoa";
            lbkhoa.Size = new Size(102, 30);
            lbkhoa.TabIndex = 48;
            lbkhoa.Text = "Mã khoa";
            lbkhoa.Click += lbkhoa_Click;
            // 
            // tablekhoa
            // 
            tablekhoa.ColumnCount = 1;
            tablekhoa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablekhoa.Location = new Point(47, 184);
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
            tablekhoa.Size = new Size(1483, 564);
            tablekhoa.TabIndex = 49;
            // 
            // pbnamekhoa
            // 
            pbnamekhoa.Location = new Point(552, 147);
            pbnamekhoa.Name = "pbnamekhoa";
            pbnamekhoa.Size = new Size(24, 24);
            pbnamekhoa.SizeMode = PictureBoxSizeMode.Zoom;
            pbnamekhoa.TabIndex = 63;
            pbnamekhoa.TabStop = false;
            // 
            // UserControlUDShow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 61);
            Controls.Add(panelMain);
            Name = "UserControlUDShow";
            Size = new Size(1820, 813);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbidkhoa).EndInit();
            cyberGroupBox1.ResumeLayout(false);
            cyberGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbnamekhoa).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMain;
        private ReaLTaiizor.Controls.ParrotButton btnSearch;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox1;
        private TextBox inputidKhoa;
        private ReaLTaiizor.Controls.ParrotButton page6;
        private ReaLTaiizor.Controls.ParrotButton page5;
        private ReaLTaiizor.Controls.ParrotButton page4;
        private ReaLTaiizor.Controls.ParrotButton page2;
        private ReaLTaiizor.Controls.ParrotButton page3;
        private ReaLTaiizor.Controls.ParrotButton page1;
        private ReaLTaiizor.Controls.ParrotButton pageLeft;
        private ReaLTaiizor.Controls.ParrotButton pageRight;
        private ReaLTaiizor.Controls.ParrotButton btnConfirmOfUDAdd;
        private Label lbnamekhoa;
        private Label lbkhoa;
        private TableLayoutPanel tablekhoa;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pbidkhoa;
        private PictureBox pbnamekhoa;
    }
}
