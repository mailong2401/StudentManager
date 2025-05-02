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
            tableLayoutPanel1 = new TableLayoutPanel();
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
            btnBackOfClassShow.Location = new Point(236, 32);
            btnBackOfClassShow.Name = "btnBackOfClassShow";
            btnBackOfClassShow.RightToLeft = RightToLeft.No;
            btnBackOfClassShow.Size = new Size(283, 83);
            btnBackOfClassShow.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnBackOfClassShow.TabIndex = 11;
            btnBackOfClassShow.TextColor = Color.Black;
            btnBackOfClassShow.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnBackOfClassShow.Vertical_Alignment = StringAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Location = new Point(180, 136);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(884, 423);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // UserControlClassShow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnBackOfClassShow);
            Name = "UserControlClassShow";
            Size = new Size(1390, 803);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotButton btnBackOfClassShow;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
