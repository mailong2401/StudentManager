namespace StudentManager
{
    partial class UserControlBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlBranch));
            panelUserControlChild = new Panel();
            panel1 = new Panel();
            btnBranchSearch = new ReaLTaiizor.Controls.ParrotButton();
            btnBranchShow = new ReaLTaiizor.Controls.ParrotButton();
            btnBranchAdd = new ReaLTaiizor.Controls.ParrotButton();
            panelUserControlChild.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelUserControlChild
            // 
            panelUserControlChild.BackColor = Color.White;
            panelUserControlChild.Controls.Add(panel1);
            panelUserControlChild.Dock = DockStyle.Fill;
            panelUserControlChild.Location = new Point(0, 0);
            panelUserControlChild.Name = "panelUserControlChild";
            panelUserControlChild.Size = new Size(1390, 751);
            panelUserControlChild.TabIndex = 1;
          
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnBranchSearch);
            panel1.Controls.Add(btnBranchShow);
            panel1.Controls.Add(btnBranchAdd);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(1390, 226);
            panel1.TabIndex = 1;
            // 
            // btnBranchSearch
            // 
            btnBranchSearch.BackgroundColor = Color.FromArgb(255, 255, 255);
            btnBranchSearch.ButtonImage = (Image)resources.GetObject("btnBranchSearch.ButtonImage");
            btnBranchSearch.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnBranchSearch.ButtonText = "Lọc";
            btnBranchSearch.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnBranchSearch.ClickTextColor = Color.DodgerBlue;
            btnBranchSearch.CornerRadius = 40;
            btnBranchSearch.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBranchSearch.Horizontal_Alignment = StringAlignment.Center;
            btnBranchSearch.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnBranchSearch.HoverTextColor = Color.DodgerBlue;
            btnBranchSearch.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnBranchSearch.Location = new Point(1100, 60);
            btnBranchSearch.Name = "btnBranchSearch";
            btnBranchSearch.Size = new Size(303, 79);
            btnBranchSearch.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnBranchSearch.TabIndex = 5;
            btnBranchSearch.TextColor = Color.Black;
            btnBranchSearch.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnBranchSearch.Vertical_Alignment = StringAlignment.Center;
            btnBranchSearch.Click += btnBranchSearch_Click;
            // 
            // btnBranchShow
            // 
            btnBranchShow.BackgroundColor = Color.FromArgb(255, 255, 255);
            btnBranchShow.ButtonImage = (Image)resources.GetObject("btnBranchShow.ButtonImage");
            btnBranchShow.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnBranchShow.ButtonText = "Xem";
            btnBranchShow.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnBranchShow.ClickTextColor = Color.DodgerBlue;
            btnBranchShow.CornerRadius = 40;
            btnBranchShow.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBranchShow.Horizontal_Alignment = StringAlignment.Center;
            btnBranchShow.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnBranchShow.HoverTextColor = Color.DodgerBlue;
            btnBranchShow.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnBranchShow.Location = new Point(650, 60);
            btnBranchShow.Name = "btnBranchShow";
            btnBranchShow.Size = new Size(303, 79);
            btnBranchShow.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnBranchShow.TabIndex = 4;
            btnBranchShow.TextColor = Color.Black;
            btnBranchShow.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnBranchShow.Vertical_Alignment = StringAlignment.Center;
            btnBranchShow.Click += btnBrandShow_Click;
            // 
            // btnBranchAdd
            // 
            btnBranchAdd.BackgroundColor = Color.FromArgb(255, 255, 255);
            btnBranchAdd.ButtonImage = (Image)resources.GetObject("btnBranchAdd.ButtonImage");
            btnBranchAdd.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnBranchAdd.ButtonText = "Thêm";
            btnBranchAdd.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnBranchAdd.ClickTextColor = Color.DodgerBlue;
            btnBranchAdd.CornerRadius = 40;
            btnBranchAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBranchAdd.Horizontal_Alignment = StringAlignment.Center;
            btnBranchAdd.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnBranchAdd.HoverTextColor = Color.DodgerBlue;
            btnBranchAdd.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnBranchAdd.Location = new Point(200, 60);
            btnBranchAdd.Name = "btnBranchAdd";
            btnBranchAdd.RightToLeft = RightToLeft.No;
            btnBranchAdd.Size = new Size(303, 79);
            btnBranchAdd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnBranchAdd.TabIndex = 3;
            btnBranchAdd.TextColor = Color.Black;
            btnBranchAdd.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnBranchAdd.Vertical_Alignment = StringAlignment.Center;
            btnBranchAdd.Click += btnBranchAdd_Click;
            // 
            // UserControlBranch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelUserControlChild);
            Name = "UserControlBranch";
            Size = new Size(1390, 751);
            panelUserControlChild.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUserControlChild;
        private Panel panel1;
        private ReaLTaiizor.Controls.ParrotButton btnBranchSearch;
        private ReaLTaiizor.Controls.ParrotButton btnBranchShow;
        private ReaLTaiizor.Controls.ParrotButton btnBranchAdd;
    }
}
