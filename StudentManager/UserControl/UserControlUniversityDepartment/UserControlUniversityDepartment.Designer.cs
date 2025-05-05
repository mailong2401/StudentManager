namespace StudentManager
{
    partial class UserControlUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlUD));
            panel2 = new Panel();
            btnUDShow = new ReaLTaiizor.Controls.ParrotButton();
            mainUD = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(5, 25, 30);
            panel2.Controls.Add(btnUDShow);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.No;
            panel2.Size = new Size(1575, 87);
            panel2.TabIndex = 7;
            // 
            // btnUDShow
            // 
            btnUDShow.BackgroundColor = Color.FromArgb(37, 52, 68);
            btnUDShow.ButtonImage = (Image)resources.GetObject("btnUDShow.ButtonImage");
            btnUDShow.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnUDShow.ButtonText = "Xem";
            btnUDShow.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnUDShow.ClickTextColor = Color.DodgerBlue;
            btnUDShow.CornerRadius = 40;
            btnUDShow.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUDShow.Horizontal_Alignment = StringAlignment.Center;
            btnUDShow.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnUDShow.HoverTextColor = Color.DodgerBlue;
            btnUDShow.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnUDShow.Location = new Point(623, 4);
            btnUDShow.Name = "btnUDShow";
            btnUDShow.Size = new Size(303, 79);
            btnUDShow.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnUDShow.TabIndex = 4;
            btnUDShow.TextColor = Color.White;
            btnUDShow.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnUDShow.Vertical_Alignment = StringAlignment.Center;
            btnUDShow.Click += btnUDShow_Click;
            // 
            // mainUD
            // 
            mainUD.Dock = DockStyle.Fill;
            mainUD.Location = new Point(0, 87);
            mainUD.Name = "mainUD";
            mainUD.Size = new Size(1575, 813);
            mainUD.TabIndex = 8;
            // 
            // UserControlUD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(mainUD);
            Controls.Add(panel2);
            Name = "UserControlUD";
            Size = new Size(1575, 900);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private ReaLTaiizor.Controls.ParrotButton btnUDShow;
        private Panel mainUD;
    }
}
