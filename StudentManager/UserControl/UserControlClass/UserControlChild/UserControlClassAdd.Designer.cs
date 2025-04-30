namespace StudentManager
{
    partial class UserControlClassAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlClassAdd));
            btnBackOfClassAdd = new ReaLTaiizor.Controls.ParrotButton();
            btnConfirmOfClassAdd = new ReaLTaiizor.Controls.ParrotButton();
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            comboBox2 = new ComboBox();
            label3 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnBackOfClassAdd
            // 
            btnBackOfClassAdd.BackgroundColor = Color.Silver;
            btnBackOfClassAdd.ButtonImage = (Image)resources.GetObject("btnBackOfClassAdd.ButtonImage");
            btnBackOfClassAdd.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnBackOfClassAdd.ButtonText = "Trở về";
            btnBackOfClassAdd.ClickBackColor = Color.Transparent;
            btnBackOfClassAdd.ClickTextColor = Color.White;
            btnBackOfClassAdd.CornerRadius = 40;
            btnBackOfClassAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackOfClassAdd.Horizontal_Alignment = StringAlignment.Center;
            btnBackOfClassAdd.HoverBackgroundColor = Color.Red;
            btnBackOfClassAdd.HoverTextColor = Color.White;
            btnBackOfClassAdd.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnBackOfClassAdd.Location = new Point(37, 8);
            btnBackOfClassAdd.Name = "btnBackOfClassAdd";
            btnBackOfClassAdd.RightToLeft = RightToLeft.No;
            btnBackOfClassAdd.Size = new Size(283, 83);
            btnBackOfClassAdd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnBackOfClassAdd.TabIndex = 13;
            btnBackOfClassAdd.TextColor = Color.Black;
            btnBackOfClassAdd.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnBackOfClassAdd.Vertical_Alignment = StringAlignment.Center;
            // 
            // btnConfirmOfClassAdd
            // 
            btnConfirmOfClassAdd.BackgroundColor = Color.Silver;
            btnConfirmOfClassAdd.ButtonImage = (Image)resources.GetObject("btnConfirmOfClassAdd.ButtonImage");
            btnConfirmOfClassAdd.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnConfirmOfClassAdd.ButtonText = "Thêm";
            btnConfirmOfClassAdd.ClickBackColor = Color.Transparent;
            btnConfirmOfClassAdd.ClickTextColor = Color.White;
            btnConfirmOfClassAdd.CornerRadius = 40;
            btnConfirmOfClassAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmOfClassAdd.Horizontal_Alignment = StringAlignment.Center;
            btnConfirmOfClassAdd.HoverBackgroundColor = Color.Lime;
            btnConfirmOfClassAdd.HoverTextColor = Color.White;
            btnConfirmOfClassAdd.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnConfirmOfClassAdd.Location = new Point(1250, 300);
            btnConfirmOfClassAdd.Name = "btnConfirmOfClassAdd";
            btnConfirmOfClassAdd.RightToLeft = RightToLeft.No;
            btnConfirmOfClassAdd.Size = new Size(283, 83);
            btnConfirmOfClassAdd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnConfirmOfClassAdd.TabIndex = 12;
            btnConfirmOfClassAdd.TextColor = Color.Black;
            btnConfirmOfClassAdd.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnConfirmOfClassAdd.Vertical_Alignment = StringAlignment.Center;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(5, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 229);
            panel2.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 16F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(234, 83);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(254, 45);
            comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(40, 80);
            label1.Name = "label1";
            label1.Size = new Size(188, 46);
            label1.TabIndex = 2;
            label1.Text = "Khoa/Viện";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1042, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 229);
            panel1.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.Location = new Point(211, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 43);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.Location = new Point(19, 80);
            label2.Name = "label2";
            label2.Size = new Size(137, 46);
            label2.TabIndex = 2;
            label2.Text = "Tên lớp";
            // 
            // panel3
            // 
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(535, 102);
            panel3.Name = "panel3";
            panel3.Size = new Size(489, 229);
            panel3.TabIndex = 11;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 16F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(200, 83);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(254, 45);
            comboBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.Location = new Point(40, 80);
            label3.Name = "label3";
            label3.Size = new Size(127, 46);
            label3.TabIndex = 2;
            label3.Text = "Ngành";
            // 
            // UserControlClassAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(btnBackOfClassAdd);
            Controls.Add(btnConfirmOfClassAdd);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserControlClassAdd";
            Size = new Size(1390, 525);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotButton btnBackOfClassAdd;
        private ReaLTaiizor.Controls.ParrotButton btnConfirmOfClassAdd;
        private Panel panel2;
        private ComboBox comboBox1;
        private Label label1;
        private Panel panel1;
        private TextBox textBox1;
        private Label label2;
        private Panel panel3;
        private ComboBox comboBox2;
        private Label label3;
    }
}
