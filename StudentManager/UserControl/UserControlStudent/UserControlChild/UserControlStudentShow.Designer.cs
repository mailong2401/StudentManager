namespace StudentManager
{
    partial class UserControlStudentShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlStudentShow));
            btnBackOfStudentShow = new ReaLTaiizor.Controls.ParrotButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnBackOfStudentShow
            // 
            btnBackOfStudentShow.BackgroundColor = Color.Silver;
            btnBackOfStudentShow.ButtonImage = (Image)resources.GetObject("btnBackOfStudentShow.ButtonImage");
            btnBackOfStudentShow.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnBackOfStudentShow.ButtonText = "Trở về";
            btnBackOfStudentShow.ClickBackColor = Color.Transparent;
            btnBackOfStudentShow.ClickTextColor = Color.White;
            btnBackOfStudentShow.CornerRadius = 40;
            btnBackOfStudentShow.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackOfStudentShow.Horizontal_Alignment = StringAlignment.Center;
            btnBackOfStudentShow.HoverBackgroundColor = Color.Red;
            btnBackOfStudentShow.HoverTextColor = Color.White;
            btnBackOfStudentShow.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnBackOfStudentShow.Location = new Point(37, 8);
            btnBackOfStudentShow.Name = "btnBackOfStudentShow";
            btnBackOfStudentShow.RightToLeft = RightToLeft.No;
            btnBackOfStudentShow.Size = new Size(283, 83);
            btnBackOfStudentShow.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnBackOfStudentShow.TabIndex = 16;
            btnBackOfStudentShow.TextColor = Color.Black;
            btnBackOfStudentShow.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnBackOfStudentShow.Vertical_Alignment = StringAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(474, 229);
            label1.Name = "label1";
            label1.Size = new Size(552, 67);
            label1.TabIndex = 17;
            label1.Text = "Chưa biết làm gì hết =))";
            // 
            // UserControlStudentShow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(btnBackOfStudentShow);
            Name = "UserControlStudentShow";
            Size = new Size(1500, 525);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotButton btnBackOfStudentShow;
        private Label label1;
    }
}
