namespace StudentManager
{
    partial class UserControlBranchShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlBranchShow));
            label1 = new Label();
            btnBackOfBranchShow = new ReaLTaiizor.Controls.ParrotButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(368, 187);
            label1.Name = "label1";
            label1.Size = new Size(655, 62);
            label1.TabIndex = 0;
            label1.Text = "show thông tin của các ngành";
            // 
            // btnBackOfBranchShow
            // 
            btnBackOfBranchShow.BackgroundColor = Color.Silver;
            btnBackOfBranchShow.ButtonImage = (Image)resources.GetObject("btnBackOfBranchShow.ButtonImage");
            btnBackOfBranchShow.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnBackOfBranchShow.ButtonText = "Trở về";
            btnBackOfBranchShow.ClickBackColor = Color.Transparent;
            btnBackOfBranchShow.ClickTextColor = Color.White;
            btnBackOfBranchShow.CornerRadius = 40;
            btnBackOfBranchShow.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackOfBranchShow.Horizontal_Alignment = StringAlignment.Center;
            btnBackOfBranchShow.HoverBackgroundColor = Color.Red;
            btnBackOfBranchShow.HoverTextColor = Color.White;
            btnBackOfBranchShow.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnBackOfBranchShow.Location = new Point(37, 8);
            btnBackOfBranchShow.Name = "btnBackOfBranchShow";
            btnBackOfBranchShow.RightToLeft = RightToLeft.No;
            btnBackOfBranchShow.Size = new Size(283, 83);
            btnBackOfBranchShow.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnBackOfBranchShow.TabIndex = 9;
            btnBackOfBranchShow.TextColor = Color.Black;
            btnBackOfBranchShow.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnBackOfBranchShow.Vertical_Alignment = StringAlignment.Center;
            // 
            // UserControlBranchShow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBackOfBranchShow);
            Controls.Add(label1);
            Name = "UserControlBranchShow";
            Size = new Size(1390, 525);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ReaLTaiizor.Controls.ParrotButton btnBackOfBranchShow;
    }
}
