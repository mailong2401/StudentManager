namespace StudentManager
{
    partial class UserControlClassShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlClassShow));
            btnBackOfClassShow = new ReaLTaiizor.Controls.ParrotButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnBackOfClassShow
            // 
            btnBackOfClassShow.BackgroundColor = Color.Silver;
            btnBackOfClassShow.ButtonImage = (Image)resources.GetObject("btnBackOfClassShow.ButtonImage");
            btnBackOfClassShow.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnBackOfClassShow.ButtonText = "Trở về";
            btnBackOfClassShow.ClickBackColor = Color.Transparent;
            btnBackOfClassShow.ClickTextColor = Color.White;
            btnBackOfClassShow.CornerRadius = 40;
            btnBackOfClassShow.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackOfClassShow.Horizontal_Alignment = StringAlignment.Center;
            btnBackOfClassShow.HoverBackgroundColor = Color.Red;
            btnBackOfClassShow.HoverTextColor = Color.White;
            btnBackOfClassShow.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnBackOfClassShow.Location = new Point(37, 8);
            btnBackOfClassShow.Name = "btnBackOfClassShow";
            btnBackOfClassShow.RightToLeft = RightToLeft.No;
            btnBackOfClassShow.Size = new Size(283, 83);
            btnBackOfClassShow.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnBackOfClassShow.TabIndex = 11;
            btnBackOfClassShow.TextColor = Color.Black;
            btnBackOfClassShow.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnBackOfClassShow.Vertical_Alignment = StringAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(533, 321);
            label1.Name = "label1";
            label1.Size = new Size(655, 62);
            label1.TabIndex = 10;
            label1.Text = "show thông tin của các ngành";
            // 
            // UserControlClassShow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBackOfClassShow);
            Controls.Add(label1);
            Name = "UserControlClassShow";
            Size = new Size(1390, 803);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotButton btnBackOfClassShow;
        private Label label1;
    }
}
