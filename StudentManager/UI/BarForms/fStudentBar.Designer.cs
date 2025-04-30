namespace StudentManager.UI
{
    partial class fStudentBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStudentBar));
            btnStudentSearch = new ReaLTaiizor.Controls.ParrotButton();
            btnStudentShow = new ReaLTaiizor.Controls.ParrotButton();
            btnStudentAdd = new ReaLTaiizor.Controls.ParrotButton();
            SuspendLayout();
            // 
            // btnStudentSearch
            // 
            btnStudentSearch.BackgroundColor = Color.FromArgb(37, 52, 68);
            btnStudentSearch.ButtonImage = (Image)resources.GetObject("btnStudentSearch.ButtonImage");
            btnStudentSearch.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnStudentSearch.ButtonText = "Lọc";
            btnStudentSearch.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnStudentSearch.ClickTextColor = Color.DodgerBlue;
            btnStudentSearch.CornerRadius = 40;
            btnStudentSearch.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentSearch.Horizontal_Alignment = StringAlignment.Center;
            btnStudentSearch.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnStudentSearch.HoverTextColor = Color.DodgerBlue;
            btnStudentSearch.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnStudentSearch.Location = new Point(1083, 4);
            btnStudentSearch.Name = "btnStudentSearch";
            btnStudentSearch.Size = new Size(303, 79);
            btnStudentSearch.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnStudentSearch.TabIndex = 8;
            btnStudentSearch.TextColor = Color.WhiteSmoke;
            btnStudentSearch.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnStudentSearch.Vertical_Alignment = StringAlignment.Center;
            btnStudentSearch.Click += btnStudentSearch_Click;
            // 
            // btnStudentShow
            // 
            btnStudentShow.BackgroundColor = Color.FromArgb(37, 52, 68);
            btnStudentShow.ButtonImage = (Image)resources.GetObject("btnStudentShow.ButtonImage");
            btnStudentShow.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnStudentShow.ButtonText = "Xem";
            btnStudentShow.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnStudentShow.ClickTextColor = Color.DodgerBlue;
            btnStudentShow.CornerRadius = 40;
            btnStudentShow.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentShow.Horizontal_Alignment = StringAlignment.Center;
            btnStudentShow.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnStudentShow.HoverTextColor = Color.DodgerBlue;
            btnStudentShow.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnStudentShow.Location = new Point(623, 4);
            btnStudentShow.Name = "btnStudentShow";
            btnStudentShow.Size = new Size(303, 79);
            btnStudentShow.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnStudentShow.TabIndex = 7;
            btnStudentShow.TextColor = Color.WhiteSmoke;
            btnStudentShow.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnStudentShow.Vertical_Alignment = StringAlignment.Center;
            // 
            // btnStudentAdd
            // 
            btnStudentAdd.BackgroundColor = Color.FromArgb(37, 52, 68);
            btnStudentAdd.ButtonImage = (Image)resources.GetObject("btnStudentAdd.ButtonImage");
            btnStudentAdd.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnStudentAdd.ButtonText = "Thêm";
            btnStudentAdd.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnStudentAdd.ClickTextColor = Color.DodgerBlue;
            btnStudentAdd.CornerRadius = 40;
            btnStudentAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentAdd.Horizontal_Alignment = StringAlignment.Center;
            btnStudentAdd.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnStudentAdd.HoverTextColor = Color.DodgerBlue;
            btnStudentAdd.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnStudentAdd.Location = new Point(183, 4);
            btnStudentAdd.Name = "btnStudentAdd";
            btnStudentAdd.RightToLeft = RightToLeft.No;
            btnStudentAdd.Size = new Size(303, 79);
            btnStudentAdd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnStudentAdd.TabIndex = 6;
            btnStudentAdd.TextColor = Color.WhiteSmoke;
            btnStudentAdd.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnStudentAdd.Vertical_Alignment = StringAlignment.Center;
            btnStudentAdd.Click += btnStudentAdd_Click;
            // 
            // fStudentBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 25, 30);
            ClientSize = new Size(1575, 87);
            Controls.Add(btnStudentSearch);
            Controls.Add(btnStudentShow);
            Controls.Add(btnStudentAdd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fStudentBar";
            Text = "fStudentBar";
            Load += fStudentBar_Load;
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotButton btnStudentSearch;
        private ReaLTaiizor.Controls.ParrotButton btnStudentShow;
        private ReaLTaiizor.Controls.ParrotButton btnStudentAdd;
    }
}