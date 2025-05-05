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
            panel1 = new Panel();
            btnBranchShow = new ReaLTaiizor.Controls.ParrotButton();
            mainBranch = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(5, 25, 30);
            panel1.Controls.Add(btnBranchShow);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(1575, 87);
            panel1.TabIndex = 3;
            // 
            // btnBranchShow
            // 
            btnBranchShow.BackgroundColor = Color.FromArgb(37, 52, 68);
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
            btnBranchShow.Location = new Point(623, 4);
            btnBranchShow.Name = "btnBranchShow";
            btnBranchShow.Size = new Size(303, 79);
            btnBranchShow.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnBranchShow.TabIndex = 4;
            btnBranchShow.TextColor = Color.White;
            btnBranchShow.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnBranchShow.Vertical_Alignment = StringAlignment.Center;
            btnBranchShow.Click += btnBrandShow_Click;
            // 
            // mainBranch
            // 
            mainBranch.Dock = DockStyle.Fill;
            mainBranch.Location = new Point(0, 87);
            mainBranch.Name = "mainBranch";
            mainBranch.Size = new Size(1575, 813);
            mainBranch.TabIndex = 4;
            // 
            // UserControlBranch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(mainBranch);
            Controls.Add(panel1);
            Name = "UserControlBranch";
            Size = new Size(1575, 900);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.ParrotButton btnBranchShow;
        private Panel mainBranch;
    }
}
