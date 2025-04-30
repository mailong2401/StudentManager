namespace StudentManager
{
    partial class UserControlUDAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlUDAdd));
            btnBackOfBranchAdd = new ReaLTaiizor.Controls.ParrotButton();
            btnConfirmOfBranchAdd = new ReaLTaiizor.Controls.ParrotButton();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBackOfBranchAdd
            // 
            btnBackOfBranchAdd.BackgroundColor = Color.Silver;
            btnBackOfBranchAdd.ButtonImage = (Image)resources.GetObject("btnBackOfBranchAdd.ButtonImage");
            btnBackOfBranchAdd.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnBackOfBranchAdd.ButtonText = "Trở về";
            btnBackOfBranchAdd.ClickBackColor = Color.Transparent;
            btnBackOfBranchAdd.ClickTextColor = Color.White;
            btnBackOfBranchAdd.CornerRadius = 40;
            btnBackOfBranchAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackOfBranchAdd.Horizontal_Alignment = StringAlignment.Center;
            btnBackOfBranchAdd.HoverBackgroundColor = Color.Red;
            btnBackOfBranchAdd.HoverTextColor = Color.White;
            btnBackOfBranchAdd.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnBackOfBranchAdd.Location = new Point(37, 8);
            btnBackOfBranchAdd.Name = "btnBackOfBranchAdd";
            btnBackOfBranchAdd.RightToLeft = RightToLeft.No;
            btnBackOfBranchAdd.Size = new Size(283, 83);
            btnBackOfBranchAdd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnBackOfBranchAdd.TabIndex = 13;
            btnBackOfBranchAdd.TextColor = Color.Black;
            btnBackOfBranchAdd.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnBackOfBranchAdd.Vertical_Alignment = StringAlignment.Center;
            // 
            // btnConfirmOfBranchAdd
            // 
            btnConfirmOfBranchAdd.BackgroundColor = Color.Silver;
            btnConfirmOfBranchAdd.ButtonImage = (Image)resources.GetObject("btnConfirmOfBranchAdd.ButtonImage");
            btnConfirmOfBranchAdd.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnConfirmOfBranchAdd.ButtonText = "Thêm";
            btnConfirmOfBranchAdd.ClickBackColor = Color.Transparent;
            btnConfirmOfBranchAdd.ClickTextColor = Color.White;
            btnConfirmOfBranchAdd.CornerRadius = 40;
            btnConfirmOfBranchAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmOfBranchAdd.Horizontal_Alignment = StringAlignment.Center;
            btnConfirmOfBranchAdd.HoverBackgroundColor = Color.Lime;
            btnConfirmOfBranchAdd.HoverTextColor = Color.White;
            btnConfirmOfBranchAdd.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnConfirmOfBranchAdd.Location = new Point(1043, 376);
            btnConfirmOfBranchAdd.Name = "btnConfirmOfBranchAdd";
            btnConfirmOfBranchAdd.RightToLeft = RightToLeft.No;
            btnConfirmOfBranchAdd.Size = new Size(283, 83);
            btnConfirmOfBranchAdd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnConfirmOfBranchAdd.TabIndex = 12;
            btnConfirmOfBranchAdd.TextColor = Color.Black;
            btnConfirmOfBranchAdd.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnConfirmOfBranchAdd.Vertical_Alignment = StringAlignment.Center;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(211, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(911, 229);
            panel1.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 22.2F);
            textBox1.Location = new Point(497, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(360, 57);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label2.Location = new Point(40, 80);
            label2.Name = "label2";
            label2.Size = new Size(361, 67);
            label2.TabIndex = 2;
            label2.Text = "Tên khoa/viện";
            // 
            // UserControlUDAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBackOfBranchAdd);
            Controls.Add(btnConfirmOfBranchAdd);
            Controls.Add(panel1);
            Name = "UserControlUDAdd";
            Size = new Size(1390, 525);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotButton btnBackOfBranchAdd;
        private ReaLTaiizor.Controls.ParrotButton btnConfirmOfBranchAdd;
        private Panel panel1;
        private TextBox textBox1;
        private Label label2;
    }
}
