namespace StudentManager
{
    partial class UserControlUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlUD));
            panel2 = new Panel();
            btnUDSearch = new ReaLTaiizor.Controls.ParrotButton();
            btnUDShow = new ReaLTaiizor.Controls.ParrotButton();
            btnUDAdd = new ReaLTaiizor.Controls.ParrotButton();
            mainUD = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(5, 25, 30);
            panel2.Controls.Add(btnUDSearch);
            panel2.Controls.Add(btnUDShow);
            panel2.Controls.Add(btnUDAdd);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.No;
            panel2.Size = new Size(1575, 87);
            panel2.TabIndex = 7;
            // 
            // btnUDSearch
            // 
            btnUDSearch.BackgroundColor = Color.FromArgb(37, 52, 68);
            btnUDSearch.ButtonImage = (Image)resources.GetObject("btnUDSearch.ButtonImage");
            btnUDSearch.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnUDSearch.ButtonText = "Lọc";
            btnUDSearch.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnUDSearch.ClickTextColor = Color.DodgerBlue;
            btnUDSearch.CornerRadius = 40;
            btnUDSearch.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUDSearch.Horizontal_Alignment = StringAlignment.Center;
            btnUDSearch.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnUDSearch.HoverTextColor = Color.DodgerBlue;
            btnUDSearch.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnUDSearch.Location = new Point(1083, 4);
            btnUDSearch.Name = "btnUDSearch";
            btnUDSearch.Size = new Size(303, 79);
            btnUDSearch.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnUDSearch.TabIndex = 5;
            btnUDSearch.TextColor = Color.White;
            btnUDSearch.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnUDSearch.Vertical_Alignment = StringAlignment.Center;
            btnUDSearch.Click += btnUDSearch_Click;
            // 
            // btnUDShow
            // 
            btnUDShow.BackgroundColor = Color.FromArgb(37, 52, 68);
            btnUDShow.ButtonImage = (Image)resources.GetObject("btnUDShow.ButtonImage");
            btnUDShow.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnUDShow.ButtonText = "Xem";
            btnUDShow.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnUDShow.ClickTextColor = Color.DodgerBlue;
            btnUDShow.CornerRadius = 40;
            btnUDShow.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUDShow.Horizontal_Alignment = StringAlignment.Center;
            btnUDShow.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnUDShow.HoverTextColor = Color.DodgerBlue;
            btnUDShow.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnUDShow.Location = new Point(623, 4);
            btnUDShow.Name = "btnUDShow";
            btnUDShow.Size = new Size(303, 79);
            btnUDShow.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnUDShow.TabIndex = 4;
            btnUDShow.TextColor = Color.White;
            btnUDShow.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnUDShow.Vertical_Alignment = StringAlignment.Center;
            btnUDShow.Click += btnUDShow_Click;
            // 
            // btnUDAdd
            // 
            btnUDAdd.BackgroundColor = Color.FromArgb(37, 52, 68);
            btnUDAdd.ButtonImage = (Image)resources.GetObject("btnUDAdd.ButtonImage");
            btnUDAdd.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnUDAdd.ButtonText = "Thêm";
            btnUDAdd.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnUDAdd.ClickTextColor = Color.DodgerBlue;
            btnUDAdd.CornerRadius = 40;
            btnUDAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUDAdd.Horizontal_Alignment = StringAlignment.Center;
            btnUDAdd.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnUDAdd.HoverTextColor = Color.DodgerBlue;
            btnUDAdd.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnUDAdd.Location = new Point(183, 4);
            btnUDAdd.Name = "btnUDAdd";
            btnUDAdd.RightToLeft = RightToLeft.No;
            btnUDAdd.Size = new Size(303, 79);
            btnUDAdd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnUDAdd.TabIndex = 3;
            btnUDAdd.TextColor = Color.White;
            btnUDAdd.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnUDAdd.Vertical_Alignment = StringAlignment.Center;
            btnUDAdd.Click += btnUDAdd_Click;
            // 
            // mainUD
            // 
            mainUD.Dock = DockStyle.Fill;
            mainUD.Location = new Point(0, 87);
            mainUD.Name = "mainUD";
            mainUD.Size = new Size(1575, 813);
            mainUD.TabIndex = 8;
            // 
            // UserControlUD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(mainUD);
            Controls.Add(panel2);
            Name = "UserControlUD";
            Size = new Size(1575, 900);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private ReaLTaiizor.Controls.ParrotButton btnUDSearch;
        private ReaLTaiizor.Controls.ParrotButton btnUDShow;
        private ReaLTaiizor.Controls.ParrotButton btnUDAdd;
        private Panel mainUD;
    }
}
