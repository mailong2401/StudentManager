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
            btnConfirmOfUDAdd = new ReaLTaiizor.Controls.ParrotButton();
            pageRight = new ReaLTaiizor.Controls.ParrotButton();
            pageLeft = new ReaLTaiizor.Controls.ParrotButton();
            page1 = new ReaLTaiizor.Controls.ParrotButton();
            page3 = new ReaLTaiizor.Controls.ParrotButton();
            page2 = new ReaLTaiizor.Controls.ParrotButton();
            page4 = new ReaLTaiizor.Controls.ParrotButton();
            page5 = new ReaLTaiizor.Controls.ParrotButton();
            page6 = new ReaLTaiizor.Controls.ParrotButton();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(574, 145);
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
            label1.Location = new Point(297, 145);
            label1.Name = "label1";
            label1.Size = new Size(102, 30);
            label1.TabIndex = 28;
            label1.Text = "Mã khoa";
            // 
            // tablekhoa
            // 
            tablekhoa.ColumnCount = 1;
            tablekhoa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablekhoa.Location = new Point(287, 188);
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
            btnConfirmOfUDAdd.Location = new Point(1350, 15);
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
            pageRight.Location = new Point(872, 767);
            pageRight.Name = "pageRight";
            pageRight.Size = new Size(32, 32);
            pageRight.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pageRight.TabIndex = 36;
            pageRight.TextColor = Color.Black;
            pageRight.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            pageRight.Vertical_Alignment = StringAlignment.Center;
            pageRight.Click += pageRight_Click;
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
            pageLeft.Location = new Point(595, 767);
            pageLeft.Name = "pageLeft";
            pageLeft.Size = new Size(32, 32);
            pageLeft.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pageLeft.TabIndex = 37;
            pageLeft.TextColor = Color.Black;
            pageLeft.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            pageLeft.Vertical_Alignment = StringAlignment.Center;
            pageLeft.Click += pageLeft_Click;
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
            page1.Location = new Point(638, 767);
            page1.Name = "page1";
            page1.Size = new Size(32, 32);
            page1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            page1.TabIndex = 38;
            page1.TextColor = Color.White;
            page1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            page1.Vertical_Alignment = StringAlignment.Center;
            page1.Click += page1_Click;
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
            page3.Location = new Point(714, 767);
            page3.Name = "page3";
            page3.Size = new Size(32, 32);
            page3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            page3.TabIndex = 39;
            page3.TextColor = Color.White;
            page3.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            page3.Vertical_Alignment = StringAlignment.Center;
            page3.Click += page3_Click;
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
            page2.Location = new Point(676, 767);
            page2.Name = "page2";
            page2.Size = new Size(32, 32);
            page2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            page2.TabIndex = 40;
            page2.TextColor = Color.White;
            page2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            page2.Vertical_Alignment = StringAlignment.Center;
            page2.Click += page2_Click;
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
            page4.Location = new Point(752, 767);
            page4.Name = "page4";
            page4.Size = new Size(32, 32);
            page4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            page4.TabIndex = 41;
            page4.TextColor = Color.White;
            page4.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            page4.Vertical_Alignment = StringAlignment.Center;
            page4.Click += page4_Click;
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
            page5.Location = new Point(790, 767);
            page5.Name = "page5";
            page5.Size = new Size(32, 32);
            page5.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            page5.TabIndex = 42;
            page5.TextColor = Color.White;
            page5.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            page5.Vertical_Alignment = StringAlignment.Center;
            page5.Click += page5_Click;
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
            page6.Location = new Point(828, 767);
            page6.Name = "page6";
            page6.Size = new Size(32, 32);
            page6.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            page6.TabIndex = 43;
            page6.TextColor = Color.White;
            page6.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            page6.Vertical_Alignment = StringAlignment.Center;
            page6.Click += page6_Click;
            // 
            // UserControlUDShow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 61);
            Controls.Add(page6);
            Controls.Add(page5);
            Controls.Add(page4);
            Controls.Add(page2);
            Controls.Add(page3);
            Controls.Add(page1);
            Controls.Add(pageLeft);
            Controls.Add(pageRight);
            Controls.Add(btnConfirmOfUDAdd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tablekhoa);
            Name = "UserControlUDShow";
            Size = new Size(1575, 813);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private ReaLTaiizor.Controls.ParrotButton btnConfirmOfUDAdd;
        private ReaLTaiizor.Controls.ParrotButton pageRight;
        private ReaLTaiizor.Controls.ParrotButton pageLeft;
        private ReaLTaiizor.Controls.ParrotButton page1;
        private ReaLTaiizor.Controls.ParrotButton page3;
        private ReaLTaiizor.Controls.ParrotButton page2;
        private ReaLTaiizor.Controls.ParrotButton page4;
        private ReaLTaiizor.Controls.ParrotButton page5;
        private ReaLTaiizor.Controls.ParrotButton page6;
        public static TableLayoutPanel tablekhoa;
    }
}
