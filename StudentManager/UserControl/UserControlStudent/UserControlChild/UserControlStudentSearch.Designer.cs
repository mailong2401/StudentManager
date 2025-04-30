namespace StudentManager
{
    partial class UserControlStudentSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlStudentSearch));
            label1 = new Label();
            btnBackOfStudentSearch = new ReaLTaiizor.Controls.ParrotButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(500, 233);
            label1.Name = "label1";
            label1.Size = new Size(552, 67);
            label1.TabIndex = 0;
            label1.Text = "Chưa biết làm gì hết =))";
            // 
            // btnBackOfStudentSearch
            // 
            btnBackOfStudentSearch.BackgroundColor = Color.Silver;
            btnBackOfStudentSearch.ButtonImage = (Image)resources.GetObject("btnBackOfStudentSearch.ButtonImage");
            btnBackOfStudentSearch.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnBackOfStudentSearch.ButtonText = "Trở về";
            btnBackOfStudentSearch.ClickBackColor = Color.Transparent;
            btnBackOfStudentSearch.ClickTextColor = Color.White;
            btnBackOfStudentSearch.CornerRadius = 40;
            btnBackOfStudentSearch.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackOfStudentSearch.Horizontal_Alignment = StringAlignment.Center;
            btnBackOfStudentSearch.HoverBackgroundColor = Color.Red;
            btnBackOfStudentSearch.HoverTextColor = Color.White;
            btnBackOfStudentSearch.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnBackOfStudentSearch.Location = new Point(37, 8);
            btnBackOfStudentSearch.Name = "btnBackOfStudentSearch";
            btnBackOfStudentSearch.RightToLeft = RightToLeft.No;
            btnBackOfStudentSearch.Size = new Size(283, 83);
            btnBackOfStudentSearch.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnBackOfStudentSearch.TabIndex = 17;
            btnBackOfStudentSearch.TextColor = Color.Black;
            btnBackOfStudentSearch.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnBackOfStudentSearch.Vertical_Alignment = StringAlignment.Center;
            // 
            // UserControlStudentSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBackOfStudentSearch);
            Controls.Add(label1);
            Name = "UserControlStudentSearch";
            Size = new Size(1500, 525);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ReaLTaiizor.Controls.ParrotButton btnBackOfStudentSearch;
    }
}
