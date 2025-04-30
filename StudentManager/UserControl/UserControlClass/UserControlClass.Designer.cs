namespace StudentManager
{
    partial class UserControlClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlClass));
            panelUserControlChild = new Panel();
            panel1 = new Panel();
            btnClassSearch = new ReaLTaiizor.Controls.ParrotButton();
            btnClassShow = new ReaLTaiizor.Controls.ParrotButton();
            btnClassAdd = new ReaLTaiizor.Controls.ParrotButton();
            panel2 = new Panel();
            panelUserControlChild.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelUserControlChild
            // 
            panelUserControlChild.BackColor = Color.White;
            panelUserControlChild.Controls.Add(panel2);
            panelUserControlChild.Controls.Add(panel1);
            panelUserControlChild.Dock = DockStyle.Fill;
            panelUserControlChild.Location = new Point(0, 0);
            panelUserControlChild.Name = "panelUserControlChild";
            panelUserControlChild.Size = new Size(1500, 900);
            panelUserControlChild.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnClassSearch);
            panel1.Controls.Add(btnClassShow);
            panel1.Controls.Add(btnClassAdd);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(1500, 226);
            panel1.TabIndex = 1;
            // 
            // btnClassSearch
            // 
            btnClassSearch.BackgroundColor = Color.FromArgb(255, 255, 255);
            btnClassSearch.ButtonImage = (Image)resources.GetObject("btnClassSearch.ButtonImage");
            btnClassSearch.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnClassSearch.ButtonText = "Lọc";
            btnClassSearch.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnClassSearch.ClickTextColor = Color.DodgerBlue;
            btnClassSearch.CornerRadius = 40;
            btnClassSearch.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClassSearch.Horizontal_Alignment = StringAlignment.Center;
            btnClassSearch.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnClassSearch.HoverTextColor = Color.DodgerBlue;
            btnClassSearch.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnClassSearch.Location = new Point(1100, 60);
            btnClassSearch.Name = "btnClassSearch";
            btnClassSearch.Size = new Size(303, 79);
            btnClassSearch.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnClassSearch.TabIndex = 5;
            btnClassSearch.TextColor = Color.Black;
            btnClassSearch.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnClassSearch.Vertical_Alignment = StringAlignment.Center;
            btnClassSearch.Click += btnClassSearch_Click;
            // 
            // btnClassShow
            // 
            btnClassShow.BackgroundColor = Color.FromArgb(255, 255, 255);
            btnClassShow.ButtonImage = (Image)resources.GetObject("btnClassShow.ButtonImage");
            btnClassShow.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnClassShow.ButtonText = "Xem";
            btnClassShow.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnClassShow.ClickTextColor = Color.DodgerBlue;
            btnClassShow.CornerRadius = 40;
            btnClassShow.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClassShow.Horizontal_Alignment = StringAlignment.Center;
            btnClassShow.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnClassShow.HoverTextColor = Color.DodgerBlue;
            btnClassShow.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnClassShow.Location = new Point(650, 60);
            btnClassShow.Name = "btnClassShow";
            btnClassShow.Size = new Size(303, 79);
            btnClassShow.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnClassShow.TabIndex = 4;
            btnClassShow.TextColor = Color.Black;
            btnClassShow.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnClassShow.Vertical_Alignment = StringAlignment.Center;
            btnClassShow.Click += btnClassShow_Click;
            // 
            // btnClassAdd
            // 
            btnClassAdd.BackgroundColor = Color.FromArgb(255, 255, 255);
            btnClassAdd.ButtonImage = (Image)resources.GetObject("btnClassAdd.ButtonImage");
            btnClassAdd.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnClassAdd.ButtonText = "Thêm";
            btnClassAdd.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnClassAdd.ClickTextColor = Color.DodgerBlue;
            btnClassAdd.CornerRadius = 40;
            btnClassAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClassAdd.Horizontal_Alignment = StringAlignment.Center;
            btnClassAdd.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnClassAdd.HoverTextColor = Color.DodgerBlue;
            btnClassAdd.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnClassAdd.Location = new Point(200, 60);
            btnClassAdd.Name = "btnClassAdd";
            btnClassAdd.RightToLeft = RightToLeft.No;
            btnClassAdd.Size = new Size(303, 79);
            btnClassAdd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnClassAdd.TabIndex = 3;
            btnClassAdd.TextColor = Color.Black;
            btnClassAdd.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnClassAdd.Vertical_Alignment = StringAlignment.Center;
            btnClassAdd.Click += btnClassAdd_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 224);
            panel2.Name = "panel2";
            panel2.Size = new Size(1500, 676);
            panel2.TabIndex = 2;
            // 
            // UserControlClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelUserControlChild);
            Name = "UserControlClass";
            Size = new Size(1500, 900);
            panelUserControlChild.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUserControlChild;
        private Panel panel1;
        private ReaLTaiizor.Controls.ParrotButton btnClassSearch;
        private ReaLTaiizor.Controls.ParrotButton btnClassShow;
        private ReaLTaiizor.Controls.ParrotButton btnClassAdd;
        private Panel panel2;
    }
}
