namespace StudentManager.UI
{
    partial class fStatisticBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStatisticBar));
            btnStatisticShow = new ReaLTaiizor.Controls.ParrotButton();
            btnStatisticAdd = new ReaLTaiizor.Controls.ParrotButton();
            SuspendLayout();
            // 
            // btnStatisticShow
            // 
            btnStatisticShow.BackgroundColor = Color.FromArgb(37, 52, 68);
            btnStatisticShow.ButtonImage = (Image)resources.GetObject("btnStatisticShow.ButtonImage");
            btnStatisticShow.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnStatisticShow.ButtonText = "Xem";
            btnStatisticShow.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnStatisticShow.ClickTextColor = Color.DodgerBlue;
            btnStatisticShow.CornerRadius = 40;
            btnStatisticShow.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStatisticShow.Horizontal_Alignment = StringAlignment.Center;
            btnStatisticShow.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnStatisticShow.HoverTextColor = Color.DodgerBlue;
            btnStatisticShow.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnStatisticShow.Location = new Point(623, 4);
            btnStatisticShow.Name = "btnStatisticShow";
            btnStatisticShow.Size = new Size(303, 79);
            btnStatisticShow.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnStatisticShow.TabIndex = 6;
            btnStatisticShow.TextColor = Color.White;
            btnStatisticShow.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnStatisticShow.Vertical_Alignment = StringAlignment.Center;
            // 
            // btnStatisticAdd
            // 
            btnStatisticAdd.BackgroundColor = Color.FromArgb(37, 52, 68);
            btnStatisticAdd.ButtonImage = (Image)resources.GetObject("btnStatisticAdd.ButtonImage");
            btnStatisticAdd.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnStatisticAdd.ButtonText = "Thêm";
            btnStatisticAdd.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnStatisticAdd.ClickTextColor = Color.DodgerBlue;
            btnStatisticAdd.CornerRadius = 40;
            btnStatisticAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStatisticAdd.Horizontal_Alignment = StringAlignment.Center;
            btnStatisticAdd.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnStatisticAdd.HoverTextColor = Color.DodgerBlue;
            btnStatisticAdd.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnStatisticAdd.Location = new Point(183, 4);
            btnStatisticAdd.Name = "btnStatisticAdd";
            btnStatisticAdd.RightToLeft = RightToLeft.No;
            btnStatisticAdd.Size = new Size(303, 79);
            btnStatisticAdd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnStatisticAdd.TabIndex = 5;
            btnStatisticAdd.TextColor = Color.White;
            btnStatisticAdd.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnStatisticAdd.Vertical_Alignment = StringAlignment.Center;
            // 
            // fStatisticBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 25, 30);
            ClientSize = new Size(1575, 87);
            Controls.Add(btnStatisticShow);
            Controls.Add(btnStatisticAdd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fStatisticBar";
            Text = "fStatistic";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotButton btnStatisticShow;
        private ReaLTaiizor.Controls.ParrotButton btnStatisticAdd;
    }
}