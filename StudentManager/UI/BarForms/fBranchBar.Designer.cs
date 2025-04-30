namespace StudentManager.UI
{
    partial class fBranchBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBranchBar));
            btnBranchShow = new ReaLTaiizor.Controls.ParrotButton();
            btnBranchAdd = new ReaLTaiizor.Controls.ParrotButton();
            SuspendLayout();
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
            btnBranchShow.TabIndex = 6;
            btnBranchShow.TextColor = Color.White;
            btnBranchShow.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnBranchShow.Vertical_Alignment = StringAlignment.Center;
            // 
            // btnBranchAdd
            // 
            btnBranchAdd.BackgroundColor = Color.FromArgb(37, 52, 68);
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
            btnBranchAdd.Location = new Point(183, 4);
            btnBranchAdd.Name = "btnBranchAdd";
            btnBranchAdd.RightToLeft = RightToLeft.No;
            btnBranchAdd.Size = new Size(303, 79);
            btnBranchAdd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnBranchAdd.TabIndex = 5;
            btnBranchAdd.TextColor = Color.White;
            btnBranchAdd.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnBranchAdd.Vertical_Alignment = StringAlignment.Center;
            // 
            // fBranchBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 25, 30);
            ClientSize = new Size(1575, 87);
            Controls.Add(btnBranchShow);
            Controls.Add(btnBranchAdd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fBranchBar";
            Text = "fBranch";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotButton btnBranchShow;
        private ReaLTaiizor.Controls.ParrotButton btnBranchAdd;
    }
}