namespace StudentManager.UI
{
    partial class fClassBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fClassBar));
            btnClassShow = new ReaLTaiizor.Controls.ParrotButton();
            btnClassAdd = new ReaLTaiizor.Controls.ParrotButton();
            SuspendLayout();
            // 
            // btnClassShow
            // 
            btnClassShow.BackgroundColor = Color.FromArgb(37, 52, 68);
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
            btnClassShow.Location = new Point(623, 4);
            btnClassShow.Name = "btnClassShow";
            btnClassShow.Size = new Size(303, 79);
            btnClassShow.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnClassShow.TabIndex = 6;
            btnClassShow.TextColor = Color.White;
            btnClassShow.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnClassShow.Vertical_Alignment = StringAlignment.Center;
            // 
            // btnClassAdd
            // 
            btnClassAdd.BackgroundColor = Color.FromArgb(37, 52, 68);
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
            btnClassAdd.Location = new Point(183, 4);
            btnClassAdd.Name = "btnClassAdd";
            btnClassAdd.RightToLeft = RightToLeft.No;
            btnClassAdd.Size = new Size(303, 79);
            btnClassAdd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnClassAdd.TabIndex = 5;
            btnClassAdd.TextColor = Color.White;
            btnClassAdd.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnClassAdd.Vertical_Alignment = StringAlignment.Center;
            btnClassAdd.Click += btnClassAdd_Click;
            // 
            // fClassBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 25, 30);
            ClientSize = new Size(1575, 87);
            Controls.Add(btnClassShow);
            Controls.Add(btnClassAdd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fClassBar";
            Text = "fClass";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotButton btnClassShow;
        private ReaLTaiizor.Controls.ParrotButton btnClassAdd;
    }
}