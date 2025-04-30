namespace StudentManager
{
    partial class UserControlBranchAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlBranchAdd));
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            btnConfirmOfBranchAdd = new ReaLTaiizor.Controls.ParrotButton();
            panel3 = new Panel();
            btnBackOfBranchAdd = new ReaLTaiizor.Controls.ParrotButton();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(96, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(608, 229);
            panel2.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(321, 89);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(254, 58);
            comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(40, 80);
            label1.Name = "label1";
            label1.Size = new Size(275, 67);
            label1.TabIndex = 2;
            label1.Text = "Khoa/Viện";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(800, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 229);
            panel1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 22.2F);
            textBox1.Location = new Point(321, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 57);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label2.Location = new Point(40, 80);
            label2.Name = "label2";
            label2.Size = new Size(273, 67);
            label2.TabIndex = 2;
            label2.Text = "Tên ngành";
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
            btnConfirmOfBranchAdd.ImeMode = ImeMode.NoControl;
            btnConfirmOfBranchAdd.Location = new Point(1250, 300);
            btnConfirmOfBranchAdd.Name = "btnConfirmOfBranchAdd";
            btnConfirmOfBranchAdd.RightToLeft = RightToLeft.No;
            btnConfirmOfBranchAdd.Size = new Size(283, 83);
            btnConfirmOfBranchAdd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnConfirmOfBranchAdd.TabIndex = 6;
            btnConfirmOfBranchAdd.TextColor = Color.Black;
            btnConfirmOfBranchAdd.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnConfirmOfBranchAdd.Vertical_Alignment = StringAlignment.Center;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnBackOfBranchAdd);
            panel3.Controls.Add(btnConfirmOfBranchAdd);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1390, 525);
            panel3.TabIndex = 7;
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
            btnBackOfBranchAdd.TabIndex = 9;
            btnBackOfBranchAdd.TextColor = Color.Black;
            btnBackOfBranchAdd.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnBackOfBranchAdd.Vertical_Alignment = StringAlignment.Center;
            // 
            // UserControlBranchAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Name = "UserControlBranchAdd";
            Size = new Size(1390, 525);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private ComboBox comboBox1;
        private Label label1;
        private Panel panel1;
        private TextBox textBox1;
        private Label label2;
        private ReaLTaiizor.Controls.ParrotButton btnConfirmOfBranchAdd;
        private Panel panel3;
        private ReaLTaiizor.Controls.ParrotButton btnBackOfBranchAdd;
    }
}
