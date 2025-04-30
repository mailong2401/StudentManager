namespace StudentManager
{
    partial class UserControlUDSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlUDSearch));
            label3 = new Label();
            btnBackOfBranchSearch = new ReaLTaiizor.Controls.ParrotButton();
            btnConfirmOfBranchSearch = new ReaLTaiizor.Controls.ParrotButton();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(540, 531);
            label3.Name = "label3";
            label3.Size = new Size(308, 46);
            label3.TabIndex = 14;
            label3.Text = "hiển thị bảng ở đây";
            // 
            // btnBackOfBranchSearch
            // 
            btnBackOfBranchSearch.BackgroundColor = Color.Silver;
            btnBackOfBranchSearch.ButtonImage = (Image)resources.GetObject("btnBackOfBranchSearch.ButtonImage");
            btnBackOfBranchSearch.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnBackOfBranchSearch.ButtonText = "Trở về";
            btnBackOfBranchSearch.ClickBackColor = Color.Transparent;
            btnBackOfBranchSearch.ClickTextColor = Color.White;
            btnBackOfBranchSearch.CornerRadius = 40;
            btnBackOfBranchSearch.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackOfBranchSearch.Horizontal_Alignment = StringAlignment.Center;
            btnBackOfBranchSearch.HoverBackgroundColor = Color.Red;
            btnBackOfBranchSearch.HoverTextColor = Color.White;
            btnBackOfBranchSearch.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnBackOfBranchSearch.Location = new Point(37, 8);
            btnBackOfBranchSearch.Name = "btnBackOfBranchSearch";
            btnBackOfBranchSearch.RightToLeft = RightToLeft.No;
            btnBackOfBranchSearch.Size = new Size(283, 83);
            btnBackOfBranchSearch.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnBackOfBranchSearch.TabIndex = 13;
            btnBackOfBranchSearch.TextColor = Color.Black;
            btnBackOfBranchSearch.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnBackOfBranchSearch.Vertical_Alignment = StringAlignment.Center;
            // 
            // btnConfirmOfBranchSearch
            // 
            btnConfirmOfBranchSearch.BackgroundColor = Color.Silver;
            btnConfirmOfBranchSearch.ButtonImage = (Image)resources.GetObject("btnConfirmOfBranchSearch.ButtonImage");
            btnConfirmOfBranchSearch.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnConfirmOfBranchSearch.ButtonText = "Tìm kiếm";
            btnConfirmOfBranchSearch.ClickBackColor = Color.Transparent;
            btnConfirmOfBranchSearch.ClickTextColor = Color.White;
            btnConfirmOfBranchSearch.CornerRadius = 40;
            btnConfirmOfBranchSearch.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmOfBranchSearch.Horizontal_Alignment = StringAlignment.Center;
            btnConfirmOfBranchSearch.HoverBackgroundColor = Color.Lime;
            btnConfirmOfBranchSearch.HoverTextColor = Color.White;
            btnConfirmOfBranchSearch.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnConfirmOfBranchSearch.Location = new Point(1100, 300);
            btnConfirmOfBranchSearch.Name = "btnConfirmOfBranchSearch";
            btnConfirmOfBranchSearch.RightToLeft = RightToLeft.No;
            btnConfirmOfBranchSearch.Size = new Size(283, 83);
            btnConfirmOfBranchSearch.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnConfirmOfBranchSearch.TabIndex = 12;
            btnConfirmOfBranchSearch.TextColor = Color.Black;
            btnConfirmOfBranchSearch.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnConfirmOfBranchSearch.Vertical_Alignment = StringAlignment.Center;
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
            // UserControlUDSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(btnBackOfBranchSearch);
            Controls.Add(btnConfirmOfBranchSearch);
            Controls.Add(panel1);
            Name = "UserControlUDSearch";
            Size = new Size(1390, 757);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ReaLTaiizor.Controls.ParrotButton btnBackOfBranchSearch;
        private ReaLTaiizor.Controls.ParrotButton btnConfirmOfBranchSearch;
        private Panel panel1;
        private TextBox textBox1;
        private Label label2;
    }
}
